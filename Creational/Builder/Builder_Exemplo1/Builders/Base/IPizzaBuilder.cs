using Builder_Exemplo1.Domain;
using Builder_Exemplo1.Domain.Enums;

namespace Builder_Exemplo1.Builders.Base
{
	public interface IPizzaBuilder
	{
		void PrepararBorda( Borda borda );

		void PrepararMassa( PizzaSizeType pizzaSize );

		void ColocarIngredientes();

		void DefinirPreco();

		void TempoForno();

		Pizza GetPizza();
	}
}
