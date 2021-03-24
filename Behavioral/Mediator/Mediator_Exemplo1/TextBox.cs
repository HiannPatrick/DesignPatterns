using Mediator_Exemplo1.Abstract;
using Mediator_Exemplo1.Interface;

using System;

namespace Mediator_Exemplo1
{
	public class TextBox : Colleague
	{
		public TextBox( IMediator mediator ) : base( mediator )
		{

		}

		public override void HandleEvent( string @event )
		{
			Console.WriteLine( "TextBox Handling Event: " + @event );
		}

		public void TriggerTextChange( string arg )
		{
			this._Mediator.Send( "Event - " + arg, this );
		}
	}
}
