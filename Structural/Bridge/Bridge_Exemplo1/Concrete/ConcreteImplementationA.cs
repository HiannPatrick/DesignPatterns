using Bridge_Exemplo1.Interfaces;

namespace Bridge_Exemplo1.Concrete
{
	// Each Concrete Implementation corresponds to a specific platform and implements the Implementation
	// interface using that platform's API.
	public class ConcreteImplementationA : IImplementation
	{
		public string OperationImplementation()
		{
			return "ConcreteImplementationA: The result in platform A.\n";
		}
	}
}
