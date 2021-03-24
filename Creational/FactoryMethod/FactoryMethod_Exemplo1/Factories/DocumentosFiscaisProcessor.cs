using FactoryMethod_Exemplo1.Enums;
using FactoryMethod_Exemplo1.Interfaces;

using System;

namespace FactoryMethod_Exemplo1.Factories
{
	public static class DocumentosFiscaisProcessor
	{
		public static IDocumentosFiscais GetDocumentoFiscal( TipoDocumentosFiscaisType tipoDocumentoFiscal )
		{
			switch ( tipoDocumentoFiscal )
			{
				case TipoDocumentosFiscaisType.NotaFiscal: return new NotasFiscais();
				case TipoDocumentosFiscaisType.NotaFiscalConsumidor: return new NotasFiscaisConsumidor();
				default: throw new ArgumentOutOfRangeException();
			}
		}
	}
}
