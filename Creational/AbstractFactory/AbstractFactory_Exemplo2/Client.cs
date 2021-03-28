using AbstractFactory_Exemplo2.ConcreteFactories;
using AbstractFactory_Exemplo2.Interfaces;

using System;

namespace AbstractFactory_Exemplo2
{
	public class Client
	{
		public void Main()
		{
			// The client code can work with any concrete factory class.
			Console.WriteLine( "Client: Testing client code with the first factory type..." );
			ClientMethod( new ConcreteFactory1() );
			Console.WriteLine();

			Console.WriteLine( "Client: Testing the same client code with the second factory type..." );
			ClientMethod( new ConcreteFactory2() );
		}

		public void ClientMethod( IAbstractFactory factory )
		{
			var productA = factory.CreateProductA();
			var productB = factory.CreateProductB();

			Console.WriteLine( productB.UsefulFunctionB() );
			Console.WriteLine( productB.AnotherUsefulFunctionB( productA ) );
		}
	}
}
