using System;

namespace Mediator_Exemplo2
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Mediator - Exemplo 2" );
			Console.WriteLine( "____________________________" );

			var uberEats = new UberEats();

			McDonalds mcDonalds1 = new McDonalds(uberEats, "Mc Donalds Shopping", (new string[] { "Dinheiro", "PIX", "VISA", "MASTER" }));
			McDonalds mcDonalds2 = new McDonalds(uberEats, "Mc Donalds Centro", (new string[] { "Dinheiro", "PIX", "VISA", "MASTER" }));
			BurgerKing burgerKing1 = new BurgerKing(uberEats, "Burger King Shopping", (new string[] { "Cheque", "Boleto" }));
			BurgerKing burgerKing2 = new BurgerKing(uberEats, "Burger King Centro", (new string[] { "Cheque", "Boleto" }));

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
