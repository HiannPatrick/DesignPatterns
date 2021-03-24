using FactoryMethod_Exemplo2.Factories;

using System;

namespace FactoryMethod_Exemplo2
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "FactoryMethod - Exemplo 2" );
			Console.WriteLine( "____________________________" );

			var sqlServer = DatabaseFactory.CreateDatabase(Enums.DatabaseType.SqlServer);

			Console.WriteLine( "Connectionstring do SQL Server: " + sqlServer.ConnectionString );

			sqlServer.OpenConnection();
			sqlServer.CloseConnection();

			Console.WriteLine( "____________________________" );

			var oracle = DatabaseFactory.CreateDatabase(Enums.DatabaseType.Oracle);

			Console.WriteLine( "Connectionstring do Oracle: " + oracle.ConnectionString );

			oracle.OpenConnection();
			oracle.CloseConnection();

			Console.WriteLine( "____________________________" );

			Console.ReadKey();
		}
	}
}
