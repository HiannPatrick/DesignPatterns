using Facade_Exemplo1.Enum;
using Facade_Exemplo1.Interfaces;

namespace Facade_Exemplo1
{
	public class DocumentosFiscaisFacade
	{
		public DocumentosFiscaisFacade()
		{
		}

		/// <summary>
		/// A única classe disponivel para acesso. O usuário não precisa saber como a classe irá realizar os comandos selecionados pelo client "Main"
		/// </summary>
		/// <param name="numeroDocumentoFiscal"></param>
		/// <param name="tipo"></param>
		/// <param name="comando"></param>
		public void ExecutarFuncao( string numeroDocumentoFiscal, DocumentosFiscaisTipos tipo, DocumentosFiscaisComandos comando )
		{
			IDocumentosFiscais documentoFiscal = null;

			switch ( tipo )
			{
				case DocumentosFiscaisTipos.NotaFiscal:
					documentoFiscal = new NotasFiscais();
					break;
				case DocumentosFiscaisTipos.NotaFiscalConsumidor:
					documentoFiscal = new NotasFiscaisConsumidor();
					break;
				default:
					return;
			}

			switch ( comando )
			{
				case DocumentosFiscaisComandos.Autorizar:
					documentoFiscal.Autorizar( numeroDocumentoFiscal );
					break;
				case DocumentosFiscaisComandos.Cancelar:
					documentoFiscal.Cancelar( numeroDocumentoFiscal );
					break;
				case DocumentosFiscaisComandos.Inutilizar:
					documentoFiscal.Inutilizar( numeroDocumentoFiscal );
					break;
				case DocumentosFiscaisComandos.Atualizar:
					documentoFiscal.Atualizar( numeroDocumentoFiscal );
					break;
				default:
					break;
			}
		}
	}
}
