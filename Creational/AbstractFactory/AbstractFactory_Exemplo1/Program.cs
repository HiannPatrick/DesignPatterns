using AbstractFactory_Exemplo1.Abstract;

using System;

namespace AbstractFactory_Exemplo1
{
	class Program
	{
		static void Main( string[] args )
		{
			while ( true )
			{
				Console.Clear();
				Console.WriteLine( "Abstract Factory - Exemplo 1" );
				Console.WriteLine( "_____________________________" );

				Console.WriteLine( "Escolha uma conexao: " );
				Console.WriteLine( "1. Oracle" );
				Console.WriteLine( "2. SQL Server" );
				Console.WriteLine( "0. Sair" );
				Console.Write( "Escolha: " );

				var escolha = Console.ReadKey();

				Console.WriteLine();

				AbstractDatabase database = null;

				switch ( escolha.KeyChar )
				{
					case '0':
						break;
					case '1':
						database = new OracleDatabase();
						break;
					case '2':
						database = new SQLServerDatabase();
						break;
					default:
						Console.WriteLine( "Opcao inválida!" );
						continue;
				}

				if ( database == null )
					break;

				Console.Clear();
				Console.WriteLine( "Nome da Conexao: " + database.Connection.NameConnection );

				database.Connection.OpenConnection();
				database.Connection.CloseConnection();

				Console.ReadKey();
			}
		}
	}
}
