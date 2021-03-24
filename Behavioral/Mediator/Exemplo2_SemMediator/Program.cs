using System;

namespace Exemplo2_SemMediator
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Exemplo 2 - Sem Mediator" );
			Console.WriteLine( "____________________________" );

			var uberEats = new UberEats();

			var mcDonalds1 = new McDonalds("Mc Donalds Shopping", (new string[] { "Dinheiro", "PIX", "VISA", "MASTER" }));
			var mcDonalds2 = new McDonalds("Mc Donalds Centro", (new string[] { "Dinheiro", "PIX", "VISA", "MASTER" }));
			var burgerKing1 = new BurgerKing("Burger King Shopping", (new string[] { "Cheque", "Boleto" }));
			var burgerKing2 = new BurgerKing("Burger King Centro", (new string[] { "Cheque", "Boleto" }));

			uberEats.AcessarRestaurante( mcDonalds1 );
			uberEats.ObterFormasDePagamento( mcDonalds1 );

			uberEats.AcessarRestaurante( mcDonalds2 );
			uberEats.ObterFormasDePagamento( mcDonalds2 );

			uberEats.AcessarRestaurante( burgerKing1 );
			uberEats.ObterFormasDePagamento( burgerKing1 );

			uberEats.AcessarRestaurante( burgerKing2 );
			uberEats.ObterFormasDePagamento( burgerKing2 );

			Console.ReadKey();
		}
	}
}
