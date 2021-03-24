using FactoryMethod_Exemplo1.Interfaces;

using System;

namespace FactoryMethod_Exemplo1
{
	public class NotasFiscais : IDocumentosFiscais
	{
		public void Autorizar()
		{
			Console.WriteLine( "Nota Fiscal autorizada com sucesso!" );
		}

		public void Cancelar()
		{
			Console.WriteLine( "Nota Fiscal cancelada com sucesso!" );
		}

		public void Inutilizar()
		{
			Console.WriteLine( "Nota Fiscal inutilizada com sucesso!" );
		}
	}
}
