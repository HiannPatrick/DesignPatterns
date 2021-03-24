using FactoryMethod_Exemplo1.Interfaces;

using System;

namespace FactoryMethod_Exemplo1
{
	public class NotasFiscaisConsumidor : IDocumentosFiscais
	{
		public void Autorizar()
		{
			Console.WriteLine( "Nota Fiscal de Consumidor autorizada com sucesso!" );
		}

		public void Cancelar()
		{
			Console.WriteLine( "Nota Fiscal de Consumidor cancelada com sucesso!" );
		}

		public void Inutilizar()
		{
			Console.WriteLine( "Nota Fiscal de Consumidor inutilizada com sucesso!" );
		}
	}
}
