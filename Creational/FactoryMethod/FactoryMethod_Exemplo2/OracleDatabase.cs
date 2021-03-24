using FactoryMethod_Exemplo2.Abstract;
using FactoryMethod_Exemplo2.Interfaces;

using System;

namespace FactoryMethod_Exemplo2
{
	public class OracleDatabase : AbstractDatabase, IDatabase
	{
		private string _connectionString;

		public string ConnectionString
		{
			get
			{
				if ( _connectionString == null )
				{
					_connectionString = this.GetConnectionString();
				}

				return _connectionString;
			}
		}

		protected override string GetConnectionString()
		{
			Console.WriteLine( "Retornando conexão com o Oracle!" );

			return @"C:\Oracle\";
		}

		public void OpenConnection()
		{
			Console.WriteLine( "Abrindo conexão com o Oracle!" );
		}

		public void CloseConnection()
		{
			Console.WriteLine( "Fechando conexão com o Oracle!" );
		}
	}
}
