using Mediator_Exemplo1.Abstract;
using Mediator_Exemplo1.Interface;

using System;

namespace Mediator_Exemplo1
{
	public class Button : Colleague
	{
		public Button( IMediator mediator ) : base( mediator )
		{

		}

		public override void HandleEvent( string @event )
		{
			Console.WriteLine( "Button Handling Event: " + @event );
		}

		public void TriggerClick( string arg )
		{
			this._Mediator.Send( "Event - " + arg, colleague: this );
		}
	}
}
