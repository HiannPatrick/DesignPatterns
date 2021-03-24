using FactoryMethod_Exemplo2.Enums;
using FactoryMethod_Exemplo2.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Exemplo2.Factories
{
	class DatabaseFactory
	{
		public static IDatabase CreateDatabase( DatabaseType databaseType )
		{
			switch ( databaseType )
			{
				case DatabaseType.Oracle:
					return new OracleDatabase();
				case DatabaseType.SqlServer:
					return new SqlServerDatabase();
				default:
					throw new Exception();
			}
		}
	}
}
