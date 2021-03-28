using AbstractFactory_Exemplo2.Interfaces;

namespace AbstractFactory_Exemplo2.ConcreteProducts
{
	public class ConcreteProductA2 : IAbstractProductA
	{
		public string UsefulFunctionA()
		{
			return "The result of the product A2.";
		}
	}
}
