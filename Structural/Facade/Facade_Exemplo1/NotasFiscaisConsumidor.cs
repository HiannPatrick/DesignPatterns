using Facade_Exemplo1.Interfaces;

using System;

namespace Facade_Exemplo1
{
	public class NotasFiscaisConsumidor : IDocumentosFiscais
	{
		public string Modelo => "65";
		public void Atualizar( string nroDocumentoFiscal )
		{
			Console.WriteLine( "Nota fiscal de Consumidor {0} atualizada com sucesso!", nroDocumentoFiscal );
		}

		public void Autorizar( string nroDocumentoFiscal )
		{
			Console.WriteLine( "Nota fiscal de Consumidor {0} autorizada com sucesso!", nroDocumentoFiscal );
		}

		public void Cancelar( string nroDocumentoFiscal )
		{
			if ( this.VerificaSeJaEstaCancelada( nroDocumentoFiscal ) )
			{
				Console.WriteLine( "Não foi possível cancelar a Nota fiscal de Consumidor {0}!", nroDocumentoFiscal );
			}
			else
			{
				Console.WriteLine( "Nota fiscal de Consumidor {0} cancelada com sucesso!", nroDocumentoFiscal );
			}
		}

		public void Inutilizar( string nroDocumentoFiscal )
		{
			Console.WriteLine( "Nota fiscal de Consumidor {0} inutilizada com sucesso!", nroDocumentoFiscal );
		}

		private bool VerificaSeJaEstaCancelada( string nroDocumentoFiscal )
		{
			Console.WriteLine( "Nota fiscal {0}, já está cancelada!", nroDocumentoFiscal );

			return true;
		}
	}
}
