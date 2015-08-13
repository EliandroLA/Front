using System;
using static Front.DB.Utilities;

namespace Front.DB
{
    public static class Utilities
    {
        public static ConnectionString GetConnectionString(string server, string user, string dataBaseName, string password, DataBaseType type)
        {
            return GetConnectionString(string.Format(type.ToConnectionString(), dataBaseName, user, password, server), type);
        }

        public static ConnectionString GetConnectionString(string connectionString, DataBaseType type)
        {
            var values = connectionString.Split((";").ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var eConnectionString = new ConnectionString();

            eConnectionString.String = connectionString;
            eConnectionString.Type = type;

            switch (eConnectionString.Type)
            {
                case DataBaseType.SqlServer:
                    eConnectionString.Server = values[0].Split('=')[1];
                    eConnectionString.DataSource = values[1].Split('=')[1];
                    eConnectionString.User = values[2].Split('=')[1];
                    eConnectionString.Password = values[3].Split('=')[1];
                    break;
                case DataBaseType.Oracle:
                    eConnectionString.DataSource = values[0].Split('=')[1];
                    eConnectionString.User = values[1].Split('=')[1];
                    eConnectionString.Password = values[2].Split('=')[1];
                    break;
            }

            return eConnectionString;
        }

        public enum DataBaseType
        {
            SqlServer = 4,
            Oracle = 3,
        }

        public static string ToConnectionString(this DataBaseType input)
        {
            switch (input)
            {
                case DataBaseType.SqlServer:
                    return "Server={3};Database={0};User Id={1};Password={2};";
                case DataBaseType.Oracle:
                    return "Data Source={0};User Id={1};Password={2};{3}";
                default:
                    return null;
            }
        }

    }

    public class ConnectionString
    {
        public string String { get; set; }
        public string Server { get; set; }
        public string User { get; set; }
        public string DataSource { get; set; }
        public string Password { get; set; }
        public DataBaseType Type { get; set; }
    }
}
