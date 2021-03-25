﻿using System;

namespace Builder_Exemplo1.Domain.Enums
{
	[Flags]
	public enum IngredienteType
	{
		Calabresa = 1,
		Catupiry = 2,
		Cheddar = 4,
		Cebola = 8,
		Azeitona = 16,
		Salame = 32,
		Tomate = 64,
		Pimentao = 128,
		Majericao = 256,
		Alho = 512,
		Mussarela = 1024,
		Provolone = 2048,
		Chocolate = 4096
	}
}
