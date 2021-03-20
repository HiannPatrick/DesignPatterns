using Mediator_Exemplo2.Abstract;
using Mediator_Exemplo2.Interface;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator_Exemplo2
{
	public class UberEats : IRestaurantesMediator
	{
		private readonly List<FastFood>_ListRestaurantes = new List<FastFood>();

		public void AddRestaurante( FastFood fastFood )
		{
			_ListRestaurantes.Add( fastFood );
		}

		public void AcessarRestaurante( FastFood fastFood )
		{
			foreach ( var col in _ListRestaurantes )
			{
				if ( col != fastFood )
					continue;

				col.FazerPedido();
			}
		}
	}
}
