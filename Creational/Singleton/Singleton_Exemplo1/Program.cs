using System;

namespace Singleton_Exemplo1
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Singleton - Exemplo 1" );
			Console.WriteLine( "____________________________" );

			SingletonClass singletonClass1 = SingletonClass.GetInstance();

			singletonClass1.PropriedadeExemplo1 = "Teste 1";
			singletonClass1.PropriedadeExemplo2 = 0;

			Console.WriteLine( "Exibindo dados de singletonClass1:" );
			Console.WriteLine( "PropriedadeExemplo1: " + singletonClass1.PropriedadeExemplo1 );
			Console.WriteLine( "PropriedadeExemplo2: " + singletonClass1.PropriedadeExemplo2 );
			Console.WriteLine( "Pressione ENTER para continuar" );
			Console.ReadKey();

			SingletonClass singletonClass2 = SingletonClass.GetInstance();

			singletonClass2.PropriedadeExemplo1 = "Teste 2";
			singletonClass2.PropriedadeExemplo2 = 1;

			Console.WriteLine( "----------------------------------" );
			Console.WriteLine( "Exibindo dados de singletonClass2:" );
			Console.WriteLine( "PropriedadeExemplo1: " + singletonClass2.PropriedadeExemplo1 );
			Console.WriteLine( "PropriedadeExemplo2: " + singletonClass2.PropriedadeExemplo2 );
			Console.WriteLine( "Pressione ENTER para continuar" );
			Console.ReadKey();

			Console.WriteLine( "----------------------------------" );
			Console.WriteLine( "Exibindo dados de singletonClass1:" );
			Console.WriteLine( "PropriedadeExemplo1: " + singletonClass1.PropriedadeExemplo1 );
			Console.WriteLine( "PropriedadeExemplo2: " + singletonClass1.PropriedadeExemplo2 );
			Console.WriteLine( "Pressione ENTER para continuar" );
			Console.ReadKey();

			Console.WriteLine( "----------------------------------" );
			Console.WriteLine( "Observe que, ao modificar os dados das propriedades do objeto singletonClass2, os dados das propriedades do objeto singletonClass1, tambem se modificam! Pois, mesmo pertencendo a objetos diferentes, os dois pertencem a mesma intancia!" );
			Console.WriteLine( "" );
			Console.WriteLine( "" );
			Console.WriteLine( "" );
		}
	}
}
