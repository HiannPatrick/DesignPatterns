using Facade_Exemplo1.Interfaces;

using System;

namespace Facade_Exemplo1
{
	public class NotasFiscais : IDocumentosFiscais
	{
		public string Modelo => "55";

		public void Atualizar( string nroDocumentoFiscal )
		{
			Console.WriteLine( "Nota fiscal {0} atualizada com sucesso!", nroDocumentoFiscal );
		}

		public void Autorizar( string nroDocumentoFiscal )
		{
			if ( this.ValidaClienteDaNotaFiscal( nroDocumentoFiscal ) )
			{
				Console.WriteLine( "Nota fiscal {0} autorizada com sucesso!", nroDocumentoFiscal );
			}
			else
			{
				Console.WriteLine( "Não foi possível autorizar a Nota fiscal {0}!", nroDocumentoFiscal );
			}
		}

		public void Cancelar( string nroDocumentoFiscal )
		{
			Console.WriteLine( "Nota fiscal {0} cancelada com sucesso!", nroDocumentoFiscal );
		}

		public void Inutilizar( string nroDocumentoFiscal )
		{
			Console.WriteLine( "Nota fiscal {0} inutilizada com sucesso!", nroDocumentoFiscal );
		}

		private bool ValidaClienteDaNotaFiscal( string nroDocumentoFiscal )
		{
			Console.WriteLine( "Cliente validado com sucesso!" );

			return true;
		}
	}
}
