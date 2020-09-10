namespace Zappos.Core.DataAccess
{
	using System.Data;
	interface IDbConnectionFactory
	{
		/// <summary>
		/// Property to get connectionstring Name 
		/// </summary>
		string ConnectionString { get; }

		/// <summary>
		/// Creates and returns a new IDbConnection.
		/// </summary>
		/// <param name="connectionStringName">The name of the connection string to use.</param>
		/// <returns>Returns a new instance of an IDbConnection.</returns>
		IDbConnection CreateConnection();
	}
}
