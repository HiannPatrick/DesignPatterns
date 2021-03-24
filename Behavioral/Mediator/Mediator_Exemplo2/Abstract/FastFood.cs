using Mediator_Exemplo2.Interface;

namespace Mediator_Exemplo2.Abstract
{
	public abstract class FastFood
	{
		protected readonly IRestaurantesMediator _restauranteMediator;

		public readonly string _nomeRestaurante;

		public readonly string[] _listaPagamentosAceitos;

		public FastFood( IRestaurantesMediator restauranteMediator, string @nomeRestaurante, string[] listaPagamentosAceitos )
		{
			_restauranteMediator = restauranteMediator;

			_nomeRestaurante = nomeRestaurante;

			_listaPagamentosAceitos = listaPagamentosAceitos;
		}

		public abstract void FazerPedido();
	}
}
