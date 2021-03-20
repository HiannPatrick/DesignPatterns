using Mediator_Exemplo1.Interface;

namespace Mediator_Exemplo1.Abstract
{
	public abstract class Colleague
	{
		protected readonly IMediator _Mediator;

		public Colleague( IMediator mediator )
		{
			_Mediator = mediator;
		}

		public abstract void HandleEvent( string @event );
	}
}
