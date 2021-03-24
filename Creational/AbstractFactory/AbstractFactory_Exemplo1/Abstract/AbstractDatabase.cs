using AbstractFactory_Exemplo1.Database;

namespace AbstractFactory_Exemplo1.Abstract
{
	public abstract class AbstractDatabase
	{
		public virtual DbConnection Connection { get; }
	}
}
