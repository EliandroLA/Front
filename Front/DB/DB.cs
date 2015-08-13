using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using static Front.DB.Utilities;
using Front.Form;

namespace Front.DB
{
    public class DataBase
    {
        public SqlConnection SqlServerConnection { get; private set; }

        public ConnectionString ConnectionString { get; set; } = new ConnectionString();

        public DataBase() { }

        public DataBase(ConnectionString connectionString)
        {
            ConnectionString = connectionString;
            SetConnection();
        }

        public DataBase(SqlConnection sqlServerConnection)
        {
            SqlServerConnection = sqlServerConnection;
            ConnectionString = GetConnectionString(SqlServerConnection.ConnectionString, DataBaseType.SqlServer);
        }

        public DataBase(string connectionString, DataBaseType type = DataBaseType.SqlServer)
        {
            ConnectionString = GetConnectionString(connectionString, type);
            SetConnection();
        }

        public DataBase(string server, string user, string dataSource, string password, DataBaseType type = DataBaseType.SqlServer)
        {
            ConnectionString = GetConnectionString(server, user, dataSource, password, type);
            SetConnection();
        }

        ~DataBase()
        {
            try
            {
                if (SqlServerConnection != null) SqlServerConnection.Close();
            }
            catch { }
        }

        public Query CreateQuery(string sql)
        {
            return new Query(this, sql);
        }

        public NonQuery CreateNonQuery(string sql)
        {
            return new NonQuery(this, sql);
        }

        public void SetConnectionString(string connectionString, DataBaseType type = DataBaseType.SqlServer)
        {
            ConnectionString = GetConnectionString(connectionString, type);
            SetConnection();
        }

        public void SetConnectionString(ConnectionString connectioString)
        {
            ConnectionString = connectioString;
            SetConnection();
        }

        private void SetConnection()
        {
            SqlServerConnection = new SqlConnection(ConnectionString.String);
        }
    }

    public class Query
    {
        public DataBase DataBase { get; set; }

        public string SQL { get; set; }

        public Query() { }

        public Query(string sql)
        {
            SQL = sql;
        }

        public Query(DataBase dataBase, string sql)
        {
            DataBase = dataBase;
            SQL = sql;
        }

        public List<Dictionary<string, string>> Execute()
        {
            throw new NotImplementedException("NotImplementedException");
        }

        public T Execute<T>()
        {
            return InternalExecute<T>(SQL);
        }

        public T Execute<T>(params object[] args)
        {
            return InternalExecute<T>(string.Format(SQL, args));
        }

        public TReturn Execute<TReturn, TInner>()
        {
            return InternalExecute<TReturn, TInner>(SQL);
        }

        public TReturn Execute<TReturn, TInner>(params object[] args)
        {
            return InternalExecute<TReturn, TInner>(string.Format(SQL, args));
        }

        public bool HasRows()
        {
            return Execute<bool>();
        }

        public bool HasRows(params object[] args)
        {
            return Execute<bool>(args);
        }

        public bool HasRows<T>(out T result)
        {
            var adapter = Execute<SqlDataAdapter>();
            result = AdapterToT<T>(adapter);
            return AdapterToT<bool>(adapter);
        }

        public bool HasRows<T>(out T result, params object[] args)
        {
            var adapter = Execute<SqlDataAdapter>(args);
            result = AdapterToT<T>(adapter);
            return AdapterToT<bool>(adapter);
        }

        public bool HasRows<TResult, TInner>(out TResult result)
        {
            var adapter = Execute<SqlDataAdapter>();
            result = AdapterToTList<TResult, TInner>(adapter);
            return AdapterToT<bool>(adapter);
        }

        public bool HasRows<TResult, TInner>(out TResult result, params object[] args)
        {
            var adapter = Execute<SqlDataAdapter>(args);
            result = AdapterToTList<TResult, TInner>(adapter);
            return AdapterToT<bool>(adapter);
        }


        public static explicit operator NonQuery(Query input)
        {
            return new NonQuery(input.DataBase, input.SQL);
        }

        private T InternalExecute<T>(string sql)
        {
            return AdapterToT<T>(GetAdapter(sql));
        }

        private TReturn InternalExecute<TReturn, TInner>(string sql)
        {
            return AdapterToTList<TReturn, TInner>(GetAdapter(sql));
        }

        private TReturn InternalExecute<TReturn, TKey, TValue>(string sql)
        {
            return AdapterToTList<TReturn, TKey, TValue>(GetAdapter(sql));
        }

        private T AdapterToT<T>(SqlDataAdapter adapter)
        {
            if (typeof(T) == typeof(int) ||
                typeof(T) == typeof(double) ||
                typeof(T) == typeof(float) ||
                typeof(T) == typeof(decimal) ||
                typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(AdapterToT<DataTable>(adapter).Rows.Count, typeof(int));
            }
            else if (typeof(T) == typeof(bool))
            {
                return (T)Convert.ChangeType(AdapterToT<int>(adapter) > 0, typeof(bool));
            }
            else if (typeof(T) == typeof(SqlDataAdapter))
            {
                return (T)Convert.ChangeType(adapter, typeof(T));
            }
            else if (typeof(T) == typeof(DataTable))
            {
                var table = new DataTable();
                adapter.Fill(table);
                return (T)Convert.ChangeType(table, typeof(T));
            }
            else if (typeof(T) == typeof(DataSet))
            {
                var table = new DataSet();
                adapter.Fill(table);
                return (T)Convert.ChangeType(table, typeof(T));
            }

            throw new ArgumentException("Type not supported exception");
        }

        private TResult AdapterToTList<TResult, TInner>(SqlDataAdapter adapter)
        {
            if (typeof(TResult) == typeof(List<TInner>))
            {
                return (TResult)Convert.ChangeType(ToListClass<TInner>(adapter), typeof(TResult));
            }

            throw new ArgumentException("Type not supported exception");
        }

        private TResult AdapterToTList<TResult, TKey, TValue>(SqlDataAdapter adapter)
        {
            //if (typeof(TResult) == typeof(Dictionary<TKey, TValue>))
            //{
            //    return (TResult)Convert.ChangeType(ToListClass<TInner>(adapter), typeof(TResult));
            //}
            //else if (typeof(TResult) == typeof(List<Dictionary<TKey, TValue>>))
            //{
            //    return (TResult)Convert.ChangeType(ToListClass<TInner>(adapter), typeof(TResult));
            //}

            //throw new ArgumentException("Type not supported exception");

            throw new NotImplementedException("Not Implemented Exception");
        }

        private SqlDataAdapter GetAdapter(string sql)
        {
            DataBase.SqlServerConnection.Open();
            var adapter = new SqlDataAdapter(sql, DataBase.SqlServerConnection);
            DataBase.SqlServerConnection.Close();
            return adapter;
        }

        private List<TInner> ToListClass<TInner>(SqlDataAdapter adapter)
        {
            var table = AdapterToT<DataTable>(adapter);
            var columns = table.AsEnumerable().Cast<DataColumn>();
            var list = new List<TInner>();

            foreach (DataRow row in table.Rows)
            {
                TInner genericClass = (TInner)Activator.CreateInstance(typeof(TInner));

                foreach (PropertyInfo prop in typeof(TInner).GetProperties())
                {
                    prop.SetValue(genericClass, row[prop.Name]);
                }

                list.Add(genericClass);
            }

            return list;
        }

        //private Dictionary<TKey, TValue> ToDictonary<TKey, TValue>(SqlDataAdapter adapter)
        //{
        //    var table = AdapterToT<DataTable>(adapter);
        //    var a = table.AsEnumerable().Select(dr => table.Columns.Cast<DataColumn>().ToDictionary(dc => dc.ColumnName, dc => dr[dc]));
        //}

    }

    public class NonQuery
    {
        public DataBase DataBase { get; set; }

        public string SQL { get; set; }

        public NonQuery() { }

        public NonQuery(string sql)
        {
            SQL = sql;
        }

        public NonQuery(DataBase dataBase, string sql)
        {
            DataBase = dataBase;
            SQL = sql;
        }

        public T Inject<T>()
        {
            return InternalInject<T>(SQL, false);
        }

        public T Inject<T>(params object[] args)
        {
            return InternalInject<T>(string.Format(SQL, args), false);
        }

        public void Inject()
        {
            InternalInject<int>(SQL, false);
        }

        public void Inject(params object[] args)
        {
            InternalInject<int>(string.Format(SQL, args), false);
        }

        public static explicit operator Query(NonQuery input)
        {
            return new Query(input.DataBase, input.SQL);
        }

        private T InternalInject<T>(string sql, bool isQuery = true)
        {
            DataBase.SqlServerConnection.Open();
            var command = new SqlCommand(sql, DataBase.SqlServerConnection);
            var affected = command.ExecuteNonQuery();
            DataBase.SqlServerConnection.Close();

            if (typeof(T) == typeof(int) ||
                typeof(T) == typeof(double) ||
                typeof(T) == typeof(float) ||
                typeof(T) == typeof(decimal) ||
                typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(affected, typeof(T));
            }
            else if (typeof(T) == typeof(bool))
            {
                return (T)Convert.ChangeType(affected > 0, typeof(T));
            }

            throw new ArgumentException("Type not supported exception");
        }

    }

}
