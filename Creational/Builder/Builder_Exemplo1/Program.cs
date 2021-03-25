using Builder_Exemplo1.Builders;
using Builder_Exemplo1.Builders.Base;
using Builder_Exemplo1.Director;
using Builder_Exemplo1.Domain;
using Builder_Exemplo1.Domain.Enums;
using Builder_Exemplo1.Processors;

using System;

namespace Builder_Exemplo1
{
	class Program
	{
		static void Main( string[] args )
		{
			while ( true )
			{
				IPizzaBuilder novaPizzaBuilder = null;
				PizzaSizeType pizzaSize = PizzaSizeType.Empty;
				BordaSizeType bordaSize = BordaSizeType.Null;
				BordaType borda = BordaType.Empty;

				CozinhaDirector cozinhaDirector = new CozinhaDirector();

				CalculaValor calculaValor = new CalculaValor();

				Console.Clear();
				Console.WriteLine( "Builder - Exemplo 1" );
				Console.WriteLine( "_______________________________" );
				Console.WriteLine();

				Console.WriteLine( "_______________________________" );
				Console.WriteLine( "Escolha o sabor da pizza: " );
				/* Console.WriteLine( "1. Calabresa" );
				Console.WriteLine( "2. A Moda da Casa" );
				Console.Write( "Escolha: " );

				var escolha = Console.ReadKey(); */

				var arraySabor = Enum.GetValues( typeof( PizzaSaborType ) );

				int iOpcao = 1;

				foreach ( var sabor in arraySabor )
				{
					Console.WriteLine( iOpcao + ". " + sabor.ToString().Replace( "_", " " ) );

					iOpcao++;
				}

				Console.Write( "Escolha: " );

				var escolha = Console.ReadKey();

				switch ( escolha.KeyChar )
				{
					case '1':
						novaPizzaBuilder = new PizzaCalabresa( calculaValor );
						break;
					case '2':
						novaPizzaBuilder = new PizzaModaCasa( calculaValor );
						break;
					case '3':
						novaPizzaBuilder = new PizzaChocolate( calculaValor );
						break;
					default:
						Console.WriteLine();
						Console.WriteLine( "Sabor inválido!" );
						Console.ReadKey();
						break;
				}

				if ( novaPizzaBuilder == null )
					continue; // Retorna ao laço de repetição "while"

				Console.WriteLine();
				Console.WriteLine( "_______________________________" );
				Console.WriteLine( "Escolha o tamanho da pizza: " );
				Console.WriteLine( "1. Pequena" );
				Console.WriteLine( "2. Media" );
				Console.WriteLine( "3. Grande" );
				Console.WriteLine( "4. Familia" );
				Console.Write( "Escolha: " );

				escolha = Console.ReadKey();

				switch ( escolha.KeyChar )
				{
					case '1':
						pizzaSize = PizzaSizeType.Pequena;
						break;
					case '2':
						pizzaSize = PizzaSizeType.Media;
						break;
					case '3':
						pizzaSize = PizzaSizeType.Grande;
						break;
					case '4':
						pizzaSize = PizzaSizeType.Família;
						break;
					default:
						Console.WriteLine();
						Console.WriteLine( "Tamanho de pizza inválido!" );
						Console.ReadKey();
						break;
				}

				if ( pizzaSize == PizzaSizeType.Empty )
					continue; // Retorna ao laço de repetição "while"

				Console.WriteLine();
				Console.WriteLine( "_______________________________" );
				Console.WriteLine( "Escolha o tamanho da borda pizza: " );
				Console.WriteLine( "1. Fina" );
				Console.WriteLine( "2. Normal" );
				Console.WriteLine( "3. Grossa" );
				Console.WriteLine( "4. Sem borda" );
				Console.Write( "Escolha: " );

				escolha = Console.ReadKey();

				switch ( escolha.KeyChar )
				{
					case '1':
						bordaSize = BordaSizeType.Fina;
						break;
					case '2':
						bordaSize = BordaSizeType.Normal;
						break;
					case '3':
						bordaSize = BordaSizeType.Grossa;
						break;
					case '4':
						bordaSize = BordaSizeType.Empty;
						break;
					default:
						Console.WriteLine();
						Console.WriteLine( "Tamanho da borda da pizza inválido!" );
						Console.ReadKey();
						break;
				}

				if ( bordaSize == BordaSizeType.Null )
					continue; // Retorna ao laço de repetição "while"

				if ( bordaSize != BordaSizeType.Empty )
				{
					Console.WriteLine();
					Console.WriteLine( "_______________________________" );
					Console.WriteLine( "Escolha o recheio da borda pizza: " );
					Console.WriteLine( "1. Catupiry" );
					Console.WriteLine( "2. Cheddar" );
					Console.WriteLine( "3. Chocolate" );
					Console.Write( "Escolha: " );

					escolha = Console.ReadKey();

					switch ( escolha.KeyChar )
					{
						case '1':
							borda = BordaType.Catupiry;
							break;
						case '2':
							borda = BordaType.Cheddar;
							break;
						case '3':
							borda = BordaType.Chocolate;
							break;
						default:
							Console.WriteLine();
							Console.WriteLine( "Recheio da borda da pizza inválido!" );
							Console.ReadKey();
							break;
					}

					if ( borda == BordaType.Empty )
						continue; // Retorna ao laço de repetição "while"
				}


				Console.WriteLine();
				Console.WriteLine( "_______________________________" );

				if ( borda == BordaType.Empty )
				{
					cozinhaDirector.PrepararPizzaSemBorda( novaPizzaBuilder, pizzaSize );
				}
				else
				{
					cozinhaDirector.PrepararPizzaComBorda( novaPizzaBuilder,
														   pizzaSize,
														   ( new Borda { BordaType = borda, BordaSizeType = bordaSize } ) );
				}

				var pizzaPronta = novaPizzaBuilder.GetPizza();

				Console.WriteLine();
				Console.WriteLine( "_______________________________" );
				Console.WriteLine( $"{pizzaPronta.Sabor} / {pizzaPronta.Valor:C} / {pizzaPronta.TempoFornoMin} min / {pizzaPronta.PizzaSize}" );

				Console.ReadKey();
			}
		}
	}
}
