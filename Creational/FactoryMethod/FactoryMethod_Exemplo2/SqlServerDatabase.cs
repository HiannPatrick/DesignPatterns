using FactoryMethod_Exemplo2.Abstract;
using FactoryMethod_Exemplo2.Interfaces;

using System;

namespace FactoryMethod_Exemplo2
{
	public class SqlServerDatabase : AbstractDatabase, IDatabase
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
			Console.WriteLine( "Retornando conexão com o SQL Server!" );

			return @"C:\SqlServer\";
		}

		public void OpenConnection()
		{
			Console.WriteLine( "Abrindo conexão com o SQL Server!" );
		}

		public void CloseConnection()
		{
			Console.WriteLine( "Fechando conexão com o SQL Server!" );
		}
	}
}
