using AbstractFactory_Exemplo2.ConcreteProducts;
using AbstractFactory_Exemplo2.Interfaces;

namespace AbstractFactory_Exemplo2.ConcreteFactories
{
	public class ConcreteFactory1 : IAbstractFactory
	{
		public IAbstractProductA CreateProductA()
		{
			return new ConcreteProductA1();
		}

		public IAbstractProductB CreateProductB()
		{
			return new ConcreteProductB1();
		}
	}
}
