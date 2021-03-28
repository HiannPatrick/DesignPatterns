using Adapter_Exemplo1.Interface;

namespace Adapter_Exemplo1.Adapter
{
	public class Adapter : ITarget
	{
		private readonly Adaptee _adaptee;

		public Adapter( Adaptee adaptee )
		{
			this._adaptee = adaptee;
		}

		public string GetRequest()
		{
			return $"This is '{this._adaptee.GetSpecificRequest()}'";
		}
	}
}
