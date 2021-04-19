using Bridge_Exemplo1.Concrete;

using System;

namespace Bridge_Exemplo1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Bridge - Exemplo 1");
			Console.WriteLine("________________________");

			Client client = new Client();

			Abstraction abstraction;
			// The client code should be able to work with any pre-configured
			// abstraction-implementation combination.
			abstraction = new Abstraction(new ConcreteImplementationA());
			client.ClientCode(abstraction);

			Console.WriteLine();

			abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
			client.ClientCode(abstraction);
		}
	}
}
