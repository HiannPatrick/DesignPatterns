using Builder_Exemplo1.Builders.Base;
using Builder_Exemplo1.Domain;
using Builder_Exemplo1.Domain.Enums;

namespace Builder_Exemplo1.Director
{
	public class CozinhaDirector
	{
		public void PrepararPizzaSemBorda( IPizzaBuilder pizzaBuilder, PizzaSizeType pizzaSize )
		{
			pizzaBuilder.PrepararMassa( pizzaSize );
			pizzaBuilder.ColocarIngredientes();
			pizzaBuilder.TempoForno();
			pizzaBuilder.DefinirPreco();
		}

		public void PrepararPizzaComBorda( IPizzaBuilder pizzaBuilder, PizzaSizeType pizzaSize, Borda borda )
		{
			pizzaBuilder.PrepararMassa( pizzaSize );
			pizzaBuilder.PrepararBorda( borda );
			pizzaBuilder.ColocarIngredientes();
			pizzaBuilder.TempoForno();
			pizzaBuilder.DefinirPreco();
		}
	}
}
