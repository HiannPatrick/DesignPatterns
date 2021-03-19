using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Interfaces
{
	public interface IDocumentosFiscais
	{
		public string Modelo { get; }
		public void Autorizar( string nroDocumentoFiscal );
		public void Cancelar( string nroDocumentoFiscal );
		public void Inutilizar( string nroDocumentoFiscal );
		public void Atualizar( string nroDocumentoFiscal );
	}
}
