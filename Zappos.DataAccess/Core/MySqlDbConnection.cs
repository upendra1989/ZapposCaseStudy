
namespace Zappos.Core.DataAccess
{
    using System.Configuration;
    using System.Data;

    public class MySqlDbConnection
    {
        private volatile static IDbConnection singleTonObject;
        private static readonly object lockingObject = new object();

        public static IDbConnection Connection()
        {
            if (singleTonObject == null)
            {
                lock (lockingObject)
                {
                    singleTonObject = new MySqlConnectionFactory().CreateConnection();
                }
            }
            if (string.IsNullOrEmpty(singleTonObject.ConnectionString))
            {
                singleTonObject.ConnectionString = ConfigurationManager.ConnectionStrings.ToString();
            }
            return singleTonObject;
        }

        private MySqlDbConnection()
        {
        }
    }
}
