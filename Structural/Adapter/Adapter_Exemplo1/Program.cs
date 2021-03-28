using Adapter_Exemplo1.Interface;

using System;

namespace Adapter_Exemplo1
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Adapter - Exemplo 1" );
			Console.WriteLine( "________________________" );

			Adaptee adaptee = new Adaptee();
			ITarget target = new Adapter.Adapter(adaptee);

			Console.WriteLine( "Adaptee interface is incompatible with the client." );
			Console.WriteLine( "But with adapter client can call it's method." );

			Console.WriteLine( target.GetRequest() );
		}
	}
}
