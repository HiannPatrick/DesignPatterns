using Bridge_Exemplo1.Interfaces;

namespace Bridge_Exemplo1.Concrete
{
	public class ConcreteImplementationB : IImplementation
	{
		// Each Concrete Implementation corresponds to a specific platform and implements the Implementation
		// interface using that platform's API.
		public string OperationImplementation()
		{
			return "ConcreteImplementationA: The result in platform B.\n";
		}
	}
}
