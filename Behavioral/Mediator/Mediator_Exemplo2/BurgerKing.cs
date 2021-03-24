using Mediator_Exemplo2.Abstract;
using Mediator_Exemplo2.Interface;

using System;

namespace Mediator_Exemplo2
{
	public class BurgerKing : FastFood
	{
		public BurgerKing( IRestaurantesMediator restauranteMediator, string nomeRestaurante, string[] listaPagamentosAceitos )
			: base( restauranteMediator, nomeRestaurante, listaPagamentosAceitos )
		{

		}
		public override void FazerPedido()
		{
			Console.WriteLine( _nomeRestaurante + " - Preparando KingBurger" );
		}
	}
}
