using System;

namespace Mediator_Exemplo2
{
	class Program
	{
		static void Main( string[] args )
		{
			UberEats uberEats = new UberEats();

			McDonalds mcDonalds1 = new McDonalds(uberEats, "Mc Donalds Shopping");
			McDonalds mcDonalds2 = new McDonalds(uberEats, "Mc Donalds Centro");
			BurgerKing burgerKing1 = new BurgerKing(uberEats, "Burger King Shopping");
			BurgerKing burgerKing2 = new BurgerKing(uberEats, "Burger King Centro");

			uberEats.AddRestaurante( mcDonalds1 );
			uberEats.AddRestaurante( mcDonalds2 );
			uberEats.AddRestaurante( burgerKing1 );
			uberEats.AddRestaurante( burgerKing2 );

			uberEats.AcessarRestaurante( mcDonalds1 );
			uberEats.AcessarRestaurante( mcDonalds2 );
			uberEats.AcessarRestaurante( burgerKing1 );
			uberEats.AcessarRestaurante( burgerKing2 );

			Console.ReadKey();
		}
	}
}
