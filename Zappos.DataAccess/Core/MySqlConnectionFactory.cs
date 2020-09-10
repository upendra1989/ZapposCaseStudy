namespace Zappos.Core.DataAccess
{
    using MySql.Data.MySqlClient;
    using System.Configuration;
    using System.Data;
    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        /// <summary>
        /// Default Constructor, initilize the connection string provided in config file
        /// </summary>
        public MySqlConnectionFactory()
        {
            //this.ConnectionString = Configuration.Manager.Configuration.ConnectionString;
        }


        /// <summary>
        /// CreateConnection, Create the connection based upon the coonection string and return the IDbConnection object.
        /// </summary>
        /// <returns>return IDbConnection object</returns>
        public IDbConnection CreateConnection()
        {
            MySqlConnection objMySqlConnection = null;
            if (!string.IsNullOrEmpty(this.ConnectionString))
            {
                objMySqlConnection = new MySqlConnection(ConnectionString);
                objMySqlConnection.ConnectionString = this.ConnectionString;
            }

            return objMySqlConnection;
        }

        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings.ToString();
            }
        }
    }
}
