using Builder_Exemplo1.Domain.Enums;

namespace Builder_Exemplo1.Domain
{
	public class Pizza
	{
		public string Sabor { get; set; }
		public Borda Borda { get; set; }
		public double Valor { get; set; }
		public PizzaSizeType PizzaSize { get; set; }
		public PizzaType PizzaSaborType { get; set; }
		public IngredienteType IngredientesType { get; set; }
		public int TempoFornoMin { get; set; }
	}
}
