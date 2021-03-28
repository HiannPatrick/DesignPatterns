using AbstractFactory_Exemplo1.Abstract;
using AbstractFactory_Exemplo1.Database;

namespace AbstractFactory_Exemplo1
{
	public class SQLServerDatabase : AbstractDatabase
	{
		private DbConnection _connectionString;

		public override DbConnection Connection
		{
			get
			{
				if ( _connectionString == null )
				{
					_connectionString = new DbConnection( "SqlServer" );
				}

				return _connectionString;
			}
		}
	}
}
