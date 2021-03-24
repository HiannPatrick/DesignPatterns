namespace Exemplo2_SemMediator.Abstract
{
	public abstract class FastFood
	{
		public readonly string _nomeRestaurante;

		public readonly string[] _listaPagamentosAceitos;

		public FastFood( string @nomeRestaurante, string[] listaPagamentosAceitos )
		{
			_nomeRestaurante = nomeRestaurante;

			_listaPagamentosAceitos = listaPagamentosAceitos;
		}

		public abstract void FazerPedido();
	}
}
