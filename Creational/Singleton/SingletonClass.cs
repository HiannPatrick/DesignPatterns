using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
	public class SingletonClass
	{
		// Variável/atributo privado onde ficará armazenado a única instancia da classe SingletonClass.
		private static SingletonClass _singletonObject;

		// variável criada para armazenar os dados da propriedade que foi criada como exemplo. Não faz parte do Singleton
		private string _propriedadeExemplo1;
		// variável criada para armazenar os dados da propriedade que foi criada como exemplo. Não faz parte do Singleton
		private int _propriedadeExemplo2;

		/// <summary>
		/// Propriedade criadas apenas para fins de exemplo e não fazem parte do padrão Singleton
		/// </summary>
		public string PropriedadeExemplo1
		{
			get
			{
				return _propriedadeExemplo1;
			}
			set
			{
				_propriedadeExemplo1 = value;
			}
		}

		/// <summary>
		/// Propriedade criadas apenas para fins de exemplo e não fazem parte do padrão Singleton
		/// </summary>
		public int PropriedadeExemplo2
		{
			get
			{
				return _propriedadeExemplo2;
			}
			set
			{
				_propriedadeExemplo2 = value;
			}
		}

		/// <summary>
		/// Construtor deve ser privado, para garantir que não seja instânciado
		/// </summary>
		private SingletonClass()
		{
		}

		/// <summary>
		/// Método GetInstance possui essa nomenclatura por convenção. Deve ser pública e estática. Retorna a classe a qual pertence (no caso "SingletonClass"), para garantir que a classe seja instanciada uma unica vez durante durante execução da aplicação.
		/// </summary>
		/// <returns></returns>
		public static SingletonClass GetInstance()
		{
			if ( _singletonObject == null ) // Se ainda não houver uma instância da classe
			{
				_singletonObject = new SingletonClass(); // Instancia a própria classe, armazenando em uma variável estática.
			}

			return _singletonObject;
		}
	}
}
