using Mediator_Exemplo3.Interfaces;

namespace Mediator_Exemplo3.Componentes
{
	public class BaseComponent
	{
		protected IMediator _mediator;

		public BaseComponent( IMediator mediator = null )
		{
			this._mediator = mediator;
		}

		public void SetMediator( IMediator mediator )
		{
			this._mediator = mediator;
		}
	}
}
