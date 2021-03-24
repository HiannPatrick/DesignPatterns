using Facade_Exemplo1.Enum;

using System;

namespace Facade_Exemplo1
{
	class Program
	{
		/// <summary>
		/// Método "client" que irá requisitar a superclasse Facade
		/// </summary>
		/// <param name="args"></param>
		static void Main( string[] args )
		{
			Console.WriteLine( "Facade - Exemplo 1" );
			Console.WriteLine( "____________________________" );

			var facadeClass = new DocumentosFiscaisFacade(); // Instancia superclasse Facade

			while ( true )
			{
				#region #Interface do usuário

				Console.Clear();
				Console.Write( "Digite o número da nota fiscal: " );

				var numeroDocumentoFiscal = Console.ReadLine();

				Console.WriteLine( "" );

				if ( string.IsNullOrEmpty( numeroDocumentoFiscal.Trim() ) )
				{
					Console.WriteLine( "Numero do documento fiscal invalido!" );
					Console.WriteLine( "" );
					Console.WriteLine( "Pressione qualquer tecla pra continuar" );
					Console.ReadKey();

					continue; // Retorna ao while
				}

				Console.WriteLine( "______________________________________" );
				Console.WriteLine( "Escolha o tipo de documento fiscal: " );
				Console.WriteLine( "1 - Nota Fiscal" );
				Console.WriteLine( "2 - Nota Fiscal de Consumidor Eletronica" );
				Console.Write( "Escolha: " );

				var tipoDocumento = Console.ReadKey();

				Console.WriteLine( "" );

				DocumentosFiscaisTipos eTipo;

				switch ( tipoDocumento.KeyChar )
				{
					case '1':
						eTipo = DocumentosFiscaisTipos.NotaFiscal;
						break;
					case '2':
						eTipo = DocumentosFiscaisTipos.NotaFiscalConsumidor;
						break;
					default:
						Console.WriteLine( "Tipo de documento fiscal inválido" );
						Console.WriteLine( "Pressione qualquer tecla pra continuar" );
						Console.ReadKey();
						continue; // Retorna ao While
				}

				Console.WriteLine( "______________________________________" );
				Console.WriteLine( "Escolha o comando: " );
				Console.WriteLine( "0 - Sair" );
				Console.WriteLine( "1 - Autorizar" );
				Console.WriteLine( "2 - Cancelar" );
				Console.WriteLine( "3 - Inutilizar" );
				Console.WriteLine( "4 - Atualizar" );
				Console.Write( "Escolha: " );

				var comando = Console.ReadKey();

				Console.WriteLine( "" );

				DocumentosFiscaisComandos eComando;

				switch ( comando.KeyChar )
				{
					case '0':
						Console.WriteLine( "Encerrando aplicacao!" );
						return; // Sai do método "Main"
					case '1':
						eComando = DocumentosFiscaisComandos.Autorizar;
						break;
					case '2':
						eComando = DocumentosFiscaisComandos.Cancelar;
						break;
					case '3':
						eComando = DocumentosFiscaisComandos.Inutilizar;
						break;
					case '4':
						eComando = DocumentosFiscaisComandos.Atualizar;
						break;
					default:
						Console.WriteLine( "Opcao invalida!" );
						Console.WriteLine( "Pressione qualquer tecla pra continuar" );
						Console.ReadKey();
						continue;
				}

				Console.Clear();


				#endregion #Interface do usuario

				facadeClass.ExecutarFuncao( numeroDocumentoFiscal, eTipo, eComando ); // Envia comando para a superclasse Facade.

				Console.ReadKey();
			}
		}
	}
}
