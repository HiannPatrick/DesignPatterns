namespace AbstractFactory_Exemplo2.Interfaces
{
	public interface IAbstractFactory
	{
		IAbstractProductA CreateProductA();

		IAbstractProductB CreateProductB();
	}
}
