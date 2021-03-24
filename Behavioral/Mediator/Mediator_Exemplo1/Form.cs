using Mediator_Exemplo1.Abstract;
using Mediator_Exemplo1.Interface;

using System.Collections.Generic;

namespace Mediator_Exemplo1
{
	public class Form : IMediator
	{
		private readonly List<Colleague>colleagues = new List<Colleague>();

		public void AddColleague( Colleague c )
		{
			this.colleagues.Add( c );
		}

		public void Send( string @event, Colleague colleague )
		{
			foreach ( var col in colleagues )
			{
				if ( col != colleague )
				{
					col.HandleEvent( @event );
				}
			}
		}
	}
}
