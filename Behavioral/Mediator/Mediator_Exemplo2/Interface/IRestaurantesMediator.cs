using Mediator_Exemplo2.Abstract;

namespace Mediator_Exemplo2.Interface
{
	public interface IRestaurantesMediator
	{
		void AcessarRestaurante( FastFood fastFood );

		void ObterFormasDePagamento( FastFood fastFood );
	}
}
