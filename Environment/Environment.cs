using Microsoft.Extensions.Configuration;
using System;

namespace Environment
{
    public class Environment
    {

        private static Environment _environmentManager;

        private Environment()
        {
            GetEnvironment();
        }
        private static object _lock = new object();
        public static Environment Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_environmentManager == null)
                        _environmentManager = new Environment();
                    return _environmentManager;
                }
            }
        }

        private string environment { get; set; }
        private IConfiguration configuration { get; set; }

        public IConfiguration GetConfiguration()
        {
            if (configuration == null)
            {
                var builder = new ConfigurationBuilder().AddJsonFile($"appsettings.{environment}.json", true, true);
                configuration = builder.Build();
            }
            return configuration;
        }

        public string GetEnvironment()
        {
            if (String.IsNullOrEmpty(environment))
            {
                try
                {

                    environment = System.Environment.GetEnvironmentVariable("MODE").ToLower();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return environment;
        }

        public bool IsDevelopment => environment == "development" ? true : false;

        public bool IsProduction => environment == "production" ? true : false;

        public bool IsStaging => environment == "staging" ? true : false;
    }
}
