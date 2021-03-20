using Mediator_Exemplo2.Abstract;
using Mediator_Exemplo2.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Exemplo2
{
	public class BurgerKing : FastFood
	{
		public BurgerKing( IRestaurantesMediator restauranteMediator, string nomeRestaurante )
			: base( restauranteMediator, nomeRestaurante )
		{

		}
		public override void FazerPedido()
		{
			Console.WriteLine( _nomeRestaurante + " - Preparando KingBurger" );
		}
	}
}
