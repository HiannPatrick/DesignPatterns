using AbstractFactory_Exemplo1.Abstract;
using AbstractFactory_Exemplo1.Database;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Exemplo1
{
	public class OracleDatabase : AbstractDatabase
	{
		private DbConnection _connectionString;

		public override DbConnection Connection
		{
			get
			{
				if ( _connectionString == null )
				{
					_connectionString = new DbConnection( "Oracle" );
				}

				return _connectionString;
			}
		}
	}
}
