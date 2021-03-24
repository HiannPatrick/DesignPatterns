using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Exemplo1.Database
{
	public class DbConnection
	{
		private readonly string _nameConnection;

		public string NameConnection
		{
			get
			{
				return _nameConnection;
			}
		}

		public DbConnection( string @nameConnection )
		{
			_nameConnection = nameConnection;
		}

		public void OpenConnection()
		{
			Console.WriteLine( "Abrindo conexao com o " + _nameConnection );
		}

		public void CloseConnection()
		{
			Console.WriteLine( "Fechando conexao com o " + _nameConnection );
		}
	}
}
