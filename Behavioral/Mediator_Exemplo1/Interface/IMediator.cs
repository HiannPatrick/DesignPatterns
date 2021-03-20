using Mediator_Exemplo1.Abstract;

namespace Mediator_Exemplo1.Interface
{
	public interface IMediator
	{
		public void Send( string @event, Colleague colleague );
	}
}
