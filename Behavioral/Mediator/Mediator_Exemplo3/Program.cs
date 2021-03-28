using Mediator_Exemplo3.Componentes;
using Mediator_Exemplo3.Mediator;

using System;

namespace Mediator_Exemplo3
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Mediator - Exemplo3" );

			// The client code.
			Component1 component1 = new Component1();
			Component2 component2 = new Component2();

			new ConcreteMediator( component1, component2 );

			Console.WriteLine( "Client triggets operation A." );
			component1.DoA();

			Console.WriteLine();

			Console.WriteLine( "Client triggers operation D." );
			component2.DoD();
		}
	}
}
