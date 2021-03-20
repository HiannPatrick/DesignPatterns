using Mediator_Exemplo2.Interface;

namespace Mediator_Exemplo2.Abstract
{
	public abstract class FastFood
	{
		protected readonly IRestaurantesMediator _restauranteMediator;

		protected readonly string _nomeRestaurante;

		public FastFood( IRestaurantesMediator restauranteMediator, string @nomeRestaurante )
		{
			_restauranteMediator = restauranteMediator;

			_nomeRestaurante = nomeRestaurante;
		}

		public abstract void FazerPedido();
	}
}
