﻿using Mediator_Exemplo3.Componentes;
using Mediator_Exemplo3.Interfaces;

using System;

namespace Mediator_Exemplo3.Mediator
{
	public class ConcreteMediator : IMediator
	{
		private Component1 _component1;

		private Component2 _component2;

		public ConcreteMediator( Component1 component1, Component2 component2 )
		{
			this._component1 = component1;
			this._component1.SetMediator( this );

			this._component2 = component2;
			this._component2.SetMediator( this );
		}

		public void Notify( object sender, string ev )
		{
			if ( ev == "A" )
			{
				Console.WriteLine( "Mediator reacts on A and triggers folowing operations:" );
				this._component2.DoC();
			}

			if ( ev == "D" )
			{
				Console.WriteLine( "Mediator reacts on D and triggers following operations:" );
				this._component1.DoB();
				this._component2.DoC();
			}
		}
	}
}
