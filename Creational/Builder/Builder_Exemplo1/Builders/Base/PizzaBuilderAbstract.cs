using Builder_Exemplo1.Domain;
using Builder_Exemplo1.Processors;

namespace Builder_Exemplo1.Builders.Base
{
	public abstract class PizzaBuilderAbstract
	{
		protected Pizza Pizza = null;
		protected readonly ICalculaValor CalculaValor;
		protected PizzaBuilderAbstract( ICalculaValor calculaValor )
		{
			CalculaValor = calculaValor;

			Pizza = new Pizza();
		}

		public virtual void DefinirPreco()
		{
			CalculaValor.DefineValor( Pizza );
		}

		public Pizza GetPizza()
		{
			return Pizza;
		}
	}
}
