using Mediator_Exemplo2.Abstract;
using Mediator_Exemplo2.Interface;

using System;

namespace Mediator_Exemplo2
{
	public class UberEats : IRestaurantesMediator
	{
		public void AcessarRestaurante( FastFood fastFood )
		{
			fastFood.FazerPedido();
		}

		public void ObterFormasDePagamento( FastFood fastFood )
		{
			Console.WriteLine( "Lista de Pagamentos do {0}:", fastFood._nomeRestaurante );

			foreach ( string formaPagamento in fastFood._listaPagamentosAceitos )
			{
				Console.WriteLine( formaPagamento );
			}

			Console.WriteLine( "__________________________________" );
		}
	}
}
