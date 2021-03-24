using System;

namespace Mediator_Exemplo1
{
	class Program
	{
		static void Main( string[] args )
		{
			Console.WriteLine( "Mediator - Exemplo 1" );
			Console.WriteLine( "____________________________" );

			Form form = new Form();
			Button button = new(form);
			TextBox textBox = new(form);

			form.AddColleague( button );
			form.AddColleague( textBox );

			button.TriggerClick( "Clicked now!" );
			textBox.TriggerTextChange( "Text changed to some invalid value!" );

			Console.ReadLine();
		}
	}
}
