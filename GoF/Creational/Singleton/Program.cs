using System;

namespace Singleton
{
	class Program
	{
		static void Main( string[] args )
		{
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
			Console.WriteLine( "Observe que os dados da classe singletonClass1 e singletonClass2, são iguais! Pois, mesmo pertencendo a objetos diferentes, os dois pertencem a mesma intância!" );
		}
	}
}
