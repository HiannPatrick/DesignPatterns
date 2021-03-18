# GoF
Design Pattern Gangs of Four

Gangs of Four Design Pattern, � uma cole��o de 23 Design Patterns do livro "Design Patterns: Elements of Reusable Object Oriented Software" ("Padr�es de Projeto: Elementos de softwares orientado a objetos reutiliz�veis", em tradu��o livre).
Este livro foi publicado em 1994 e � um dos mais populares para se aprender padr�es de projeto. O livro foi escrito por Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides. O nome Gang of Four, se d� por causa dos seus quatro autores. Alem do mais, pode ser chamado de GoF.

O GoF � dividido em tr�s categorias:

	- Criacionais (Creational): Os padr�es de projeto que lidam com a cria��o de um objeto;

	- Estruturais (Structural): Os padr�es de projeto, nesta categoria, lidam com a estrutura de classes, como Heran�a e Composi��o;

	- Comportamentais (Behavioral): Este tipos de padr�es de projeto, fornecem solu��es para a melhor intera��o entre objetos, como fornecer perda de acoplamento e flexibilidade para estender facilmente no futuro;

5 Padr�es Criacionais (Creational Desing Patterns)
	
	- Abstract Factory: Nos permite criar um f�brica de cria��o de classes;
	
	- Builder: Criando um objeto passo a passo e um m�todo para finalmente obter a inst�ncia do objeto;

	- Factory: O padr�o de f�brica elimina a responsabilidade de instanciar um objeto da classe para uma classe fabricada;

	- Prototype: Criar uma nova inst�ncia de objeto a partir de outra inst�ncia semelhante e, em seguida, modificar de acordo com nossos requisitos;

	- Singleton: Restringe a inicializa��o de uma classe para garantir que apenas uma inst�ncia da classe possa ser criada;

7 Padr�es Estruturais (Structural Design Patterns)

	- Adapter: Fornece uma interface entre duas entidades n�o relacionadas, para que possam trabalhar juntas.

	- Bridge: � usado para desacoplar as interfaces da implementa��o e ocultar os detalhes de implementa��o do programa cliente;

	- Composite: Usado quando temos que implementar uma hierarquia parte-todo. Por exemplo, um diagrama feito de outras pe�as, como c�rculo, quadrado, tri�ngulo, etc.;

	- Decorator: � usado para modificar a funcionalidade de um objeto em tempo de execu��o;

	- Facade:  Cria��o de um envolt�rio de interfaces, acima de interfaces existentes, para ajudar aplica��es clientes.
			   Cria��o de uma super classe que ir� interagir com o subsistema. Utilizado quando se quer esconder do cliente, a complexidade do seu subsistema. Para isso, o client acessa a classe Facade e ela acessa o subsistema;

	- Flyweight: Armazenamento em cache e reutiliza��o de inst�ncias de objeto, usadas com objetos imut�veis. Por exemplo, pool de strings;

	- Proxy: Fornece um substituto ou espa�o reservado para outro objeto para controlar o acesso a ele;

11 Padr�es Comportamentais ( Behavioral Design Patterns)

	- Chain of Responsability: usado para obter acoplamento fraco no design do software, onde uma solicita��o do cliente � passada para uma cadeia de objetos para process�-los.

	- Command: usado para implementar perda de acoplamento em um modelo de solicita��o-resposta.

	- Iterator: fornece uma maneira padr�o de atravessar um grupo de objetos.

	- Interpreter: define uma representa��o gramatical para um idioma e fornece um int�rprete para lidar com essa gram�tica.

	- Mediator: usado para fornecer um meio de comunica��o centralizado entre diferentes objetos em um sistema.

	- Memento: usado quando queremos salvar o estado de um objeto para que possamos restaur�-lo posteriormente.

	- Observer: �til quando voc� est� interessado no estado de um objeto e deseja ser notificado sempre que houver alguma altera��o.

	- State: usado quando um objeto muda seu comportamento com base em seu estado interno.

	- Strategy: usado quando temos v�rios algoritmos para uma tarefa espec�fica e o cliente decide a implementa��o real a ser usada no tempo de execu��o.

	- Template Method: usado para criar um esbo�o de m�todo de modelo e adiar algumas das etapas de implementa��o para as subclasses.

	- Visitor: usado quando temos que realizar uma opera��o em um grupo de tipos semelhantes de objetos.


Fonte:https://www.journaldev.com/31902/gangs-of-four-gof-design-patterns
	

	