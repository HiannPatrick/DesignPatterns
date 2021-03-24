namespace FactoryMethod_Exemplo2.Interfaces
{
	public interface IDatabase
	{
		string ConnectionString { get; }
		public void OpenConnection();
		public void CloseConnection();
	}
}
