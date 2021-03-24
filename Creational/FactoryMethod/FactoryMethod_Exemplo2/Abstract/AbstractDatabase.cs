using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Exemplo2.Abstract
{
	public abstract class AbstractDatabase
	{
		protected abstract string GetConnectionString();
	}
}
