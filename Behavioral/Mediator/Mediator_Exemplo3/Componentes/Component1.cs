using System;

namespace Mediator_Exemplo3.Componentes
{
	public class Component1 : BaseComponent
	{
		public void DoA()
		{
			Console.WriteLine( "Component 1 does A." );

			this._mediator.Notify( this, "A" );
		}

		public void DoB()
		{
			Console.WriteLine( "Component 1 does B." );

			this._mediator.Notify( this, "B" );
		}
	}
}
