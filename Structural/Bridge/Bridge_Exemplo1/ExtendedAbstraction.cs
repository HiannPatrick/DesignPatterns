using Bridge_Exemplo1.Interfaces;

namespace Bridge_Exemplo1
{
	public class ExtendedAbstraction : Abstraction
	{
		// You can extend the Abstraction without changing the Implementation classes.
		public ExtendedAbstraction(IImplementation implementation) : base(implementation)
		{
		}

		public override string Operation()
		{
			return "ExtendedAbstraction: Extended operation with:\n" + base._implementation.OperationImplementation();
		}
	}
}
