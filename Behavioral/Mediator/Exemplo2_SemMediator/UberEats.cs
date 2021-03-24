using Exemplo2_SemMediator.Abstract;

using System;

namespace Exemplo2_SemMediator
{
	public class UberEats
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
