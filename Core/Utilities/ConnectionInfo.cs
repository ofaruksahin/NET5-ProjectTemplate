using Microsoft.Extensions.Configuration;

namespace Core.Utilities
{
    public class ConnectionInfo
    {
        static volatile ConnectionInfo _instance;

        public static ConnectionInfo Instance
        {
            get
            {
                return _instance ?? (_instance = new ConnectionInfo());
            }
        }

        readonly IConfiguration configuration;

        private ConnectionInfo()
        {
            Environment.Environment environment = Environment.Environment.Instance;
            configuration = environment.GetConfiguration();
        }
        public string MySQLConnectionString => (string)configuration.GetValue(typeof(string),"mysql_connection");
    }
}
