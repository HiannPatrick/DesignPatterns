using Exemplo2_SemMediator.Abstract;

using System;

namespace Exemplo2_SemMediator
{
	public class McDonalds : FastFood
	{
		public McDonalds( string nomeRestaurante, string[] listaPagamentosAceitos )
			: base( nomeRestaurante, listaPagamentosAceitos )
		{

		}

		public override void FazerPedido()
		{
			Console.WriteLine( _nomeRestaurante + " - Preparando McBurger" );
		}
	}
}
