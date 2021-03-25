using Builder_Exemplo1.Builders.Base;
using Builder_Exemplo1.Domain;
using Builder_Exemplo1.Domain.Enums;
using Builder_Exemplo1.Processors;

using System;

namespace Builder_Exemplo1.Builders
{
	public sealed class PizzaChocolate : PizzaBuilderAbstract, IPizzaBuilder
	{
		public PizzaChocolate( ICalculaValor calculaValor ) : base( calculaValor )
		{
			this.Pizza.Sabor = "Chocolate";
		}

		public void PrepararBorda( Borda borda )
		{
			Console.WriteLine( "Preparando borda de {0}, da pizza de {1}.", borda.BordaType, this.Pizza.Sabor );

			this.Pizza.Borda = borda;
		}

		public void PrepararMassa( PizzaSizeType pizzaSize )
		{
			Console.WriteLine( "Preparando massa {0}, da pizza de {1}", pizzaSize, this.Pizza.Sabor );

			this.Pizza.PizzaSaborType = PizzaType.Doce;
			this.Pizza.PizzaSize = pizzaSize;
		}

		public void ColocarIngredientes()
		{
			Console.WriteLine( "Colocando os ingredientes da pizza de " + this.Pizza.Sabor );

			this.Pizza.IngredientesType = IngredienteType.Mussarela | IngredienteType.Chocolate;
		}

		public void TempoForno()
		{
			Console.WriteLine( "Assando a pizza de " + this.Pizza.Sabor );

			this.Pizza.TempoFornoMin = 10;
		}
	}
}
