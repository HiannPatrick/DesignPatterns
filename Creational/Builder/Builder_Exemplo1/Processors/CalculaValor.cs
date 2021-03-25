using Builder_Exemplo1.Domain;
using Builder_Exemplo1.Domain.Enums;

using System;
using System.Linq;

namespace Builder_Exemplo1.Processors
{
	public class CalculaValor : ICalculaValor
	{
		public void DefineValor( Pizza pizza )
		{
			var totalIngredientes = Enum.GetValues(typeof(IngredienteType)).Cast<Enum>().Count(pizza.IngredientesType.HasFlag);

			/*
             *  Expressão pra calcular o valor total da pizza
             *
             *  (Total de ingredientes x R$ 1,70) + ( o tamanho da pizza x R$ 10,00) + (se for doce mais R$ 10,00) +
             *  (Se a borda for de chocolate é o tamanho da borda x R$ 5,00 e se for salgada x R$ 2,00)             
             */
			var valorIngredintes = totalIngredientes * 1.70;
			var valorTamanho = (int)pizza.PizzaSize * 10;
			var valorTipo = pizza.PizzaSaborType == PizzaType.Doce ? 10 : 0;

			var valorBorda = 0;

			if ( pizza.Borda != null )
			{
				valorBorda = pizza.Borda.BordaType == BordaType.Chocolate
					? ( 5 * (int)pizza.Borda.BordaSizeType )
					: ( 2 * (int)pizza.Borda.BordaSizeType );
			}

			pizza.Valor = valorIngredintes + valorTamanho + valorTipo + valorBorda;
		}
	}
}
