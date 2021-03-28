using AbstractFactory_Exemplo2.ConcreteProducts;
using AbstractFactory_Exemplo2.Interfaces;

namespace AbstractFactory_Exemplo2.ConcreteFactories
{
	public class ConcreteFactory2 : IAbstractFactory
	{
		public IAbstractProductA CreateProductA()
		{
			return new ConcreteProductA2();
		}

		public IAbstractProductB CreateProductB()
		{
			return new ConcreteProductB2();
		}
	}
}
