using Facade.Interfaces;
using Facade.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
	public class DocumentosFiscaisFacade
	{
		private IDocumentosFiscais _NotasFiscais;
		private IDocumentosFiscais _NotasFiscaisConsumidor;
		public DocumentosFiscaisFacade()
		{
			_NotasFiscais = new NotasFiscais();
			_NotasFiscaisConsumidor = new NotasFiscaisConsumidor();
		}

		/// <summary>
		/// A única classe disponivel para acesso. O usuário não precisa saber como a classe irá realizar os comandos selecionados pelo client "Main"
		/// </summary>
		/// <param name="numeroDocumentoFiscal"></param>
		/// <param name="tipo"></param>
		/// <param name="comando"></param>
		public void ExecutarFuncao( string numeroDocumentoFiscal, DocumentosFiscaisTipos tipo, DocumentosFiscaisComandos comando )
		{
			switch ( comando )
			{
				case DocumentosFiscaisComandos.Autorizar:
					this.Autorizar( numeroDocumentoFiscal, tipo );
					break;
				case DocumentosFiscaisComandos.Cancelar:
					this.Cancelar( numeroDocumentoFiscal, tipo );
					break;
				case DocumentosFiscaisComandos.Inutilizar:
					this.Inutilizar( numeroDocumentoFiscal, tipo );
					break;
				case DocumentosFiscaisComandos.Atualizar:
					this.Atualizar( numeroDocumentoFiscal, tipo );
					break;
				default:
					break;
			}
		}

		private void Autorizar( string nroDocumentoFiscal, DocumentosFiscaisTipos tipos )
		{
			switch ( tipos )
			{
				case DocumentosFiscaisTipos.NotaFiscal:
					_NotasFiscais.Autorizar( nroDocumentoFiscal );
					break;
				case DocumentosFiscaisTipos.NotaFiscalConsumidor:
					_NotasFiscaisConsumidor.Autorizar( nroDocumentoFiscal );
					break;
				default:
					break;
			}
		}

		private void Cancelar( string nroDocumentoFiscal, DocumentosFiscaisTipos tipos )
		{
			switch ( tipos )
			{
				case DocumentosFiscaisTipos.NotaFiscal:
					_NotasFiscais.Cancelar( nroDocumentoFiscal );
					break;
				case DocumentosFiscaisTipos.NotaFiscalConsumidor:
					_NotasFiscaisConsumidor.Cancelar( nroDocumentoFiscal );
					break;
				default:
					break;
			}
		}

		private void Inutilizar( string nroDocumentoFiscal, DocumentosFiscaisTipos tipos )
		{
			switch ( tipos )
			{
				case DocumentosFiscaisTipos.NotaFiscal:
					_NotasFiscais.Inutilizar( nroDocumentoFiscal );
					break;
				case DocumentosFiscaisTipos.NotaFiscalConsumidor:
					_NotasFiscaisConsumidor.Inutilizar( nroDocumentoFiscal );
					break;
				default:
					break;
			}
		}

		private void Atualizar( string nroDocumentoFiscal, DocumentosFiscaisTipos tipos )
		{
			switch ( tipos )
			{
				case DocumentosFiscaisTipos.NotaFiscal:
					_NotasFiscais.Atualizar( nroDocumentoFiscal );
					break;
				case DocumentosFiscaisTipos.NotaFiscalConsumidor:
					_NotasFiscaisConsumidor.Atualizar( nroDocumentoFiscal );
					break;
				default:
					break;
			}
		}
	}
}
