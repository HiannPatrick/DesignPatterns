namespace Facade_Exemplo1.Interfaces
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
