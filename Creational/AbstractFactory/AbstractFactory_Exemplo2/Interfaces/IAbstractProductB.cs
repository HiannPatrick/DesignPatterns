namespace AbstractFactory_Exemplo2.Interfaces
{
	public interface IAbstractProductB
	{
		// Product B is able to do its own thing...
		string UsefulFunctionB();

		// ...but it also can collaborate with the ProductA.
		//
		// The Abstract Factory makes sure that all products it creates are of
		// the same variant and thus, compatible.
		string AnotherUsefulFunctionB( IAbstractProductA collaborator );
	}
}
