using FactoryMethod_Exemplo1.Enums;
using FactoryMethod_Exemplo1.Factories;

using System;

namespace FactoryMethod_Exemplo1
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "FactoryMethod - Exemplo 2" );
			Console.WriteLine( "____________________________" );

			var notaFiscal = DocumentosFiscaisProcessor.GetDocumentoFiscal(TipoDocumentosFiscaisType.NotaFiscal);
			var notaFiscalConsumidor =
				DocumentosFiscaisProcessor.GetDocumentoFiscal(TipoDocumentosFiscaisType.NotaFiscalConsumidor);

			notaFiscal.Autorizar();
			notaFiscal.Cancelar();
			notaFiscal.Inutilizar();

			notaFiscalConsumidor.Autorizar();
			notaFiscalConsumidor.Cancelar();
			notaFiscalConsumidor.Inutilizar();

			Console.ReadKey();
		}
	}
}
