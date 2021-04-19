using Bridge_Exemplo1.Interfaces;

namespace Bridge_Exemplo1
{
	public class Abstraction
	{
		protected IImplementation _implementation;

		// The Abstraction defines the interface for the "control" part of the two class hierarchies.
		// It maintains a reference to an object of the implementation hierarchy and delegates all of the real work to this object.
		public Abstraction(IImplementation implementation)
		{
			this._implementation = implementation;
		}

		public virtual string Operation()
		{
			return "Abstract: Base operation with:\n" + _implementation.OperationImplementation();
		}
	}
}
