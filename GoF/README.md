# GoF

## Fontes

https://www.journaldev.com/31902/gangs-of-four-gof-design-patterns

## Design Pattern Gangs of Four

Gangs of Four Design Pattern, é uma coleção de 23 Design Patterns do livro "Design Patterns: Elements of Reusable Object Oriented Software" ("Padrões de Projeto: Elementos de softwares orientado a objetos reutilizáveis", em tradução livre).

Este livro foi publicado em 1994 e é um dos mais populares para se aprender padrões de projeto. O livro foi escrito por Erich Gamma, Richard Helm, Ralph Johnson e John Vlissides. O nome Gang of Four, se dá por causa dos seus quatro autores. Alem do mais, pode ser chamado de GoF.

## O GoF é dividido em três categorias:

- Criacionais (Creational): Os padrões de projeto que lidam com a criação de um objeto;

- Estruturais (Structural): Os padrões de projeto, nesta categoria, lidam com a estrutura de classes, como Herança eComposição;

- Comportamentais (Behavioral): Este tipos de padrões de projeto, fornecem soluções para a melhor interação entre objetos, como fornecer perda de acoplamento e flexibilidade para estender facilmente no futuro;

## 5 Padrões Criacionais (Creational Desing Patterns)
	
- Abstract Factory: Nos permite criar um fábrica de criação de classes;
- Builder: Criando um objeto passo a passo e um método para finalmente obter a instância do objeto;
- Factory: O padrão de fábrica elimina a responsabilidade de instanciar um objeto da classe para uma classe fabricada;
- Prototype: Criar uma nova instância de objeto a partir de outra instância semelhante e, em seguida, modificar de acordo com nossos requisitos;
- Singleton: Restringe a inicialização de uma classe para garantir que apenas uma instância da classe possa ser criada;

## 7 Padrões Estruturais (Structural Design Patterns)

- Adapter: Fornece uma interface entre duas entidades não relacionadas, para que possam trabalhar juntas.
- Bridge: É usado para desacoplar as interfaces da implementação e ocultar os detalhes de implementação do programacliente;
- Composite: Usado quando temos que implementar uma hierarquia parte-todo. Por exemplo, um diagrama feito de outras peças,como círculo, quadrado, triângulo, etc.;
- Decorator: É usado para modificar a funcionalidade de um objeto em tempo de execução;
- Facade:  
	* Criação de um envoltório de interfaces, acima de interfaces existentes, para ajudar aplicações clientes.
	* Criação de uma super classe que irá interagir com o subsistema. Utilizado quando se quer esconder do cliente, acomplexidade do seu subsistema. Para isso, o client acessa a classe Facade e ela acessa o subsistema;
- Flyweight: Armazenamento em cache e reutilização de instâncias de objeto, usadas com objetos imutáveis. Por exemplo, poo de strings;
- Proxy: Fornece um substituto ou espaço reservado para outro objeto para controlar o acesso a ele;

## 11 Padrões Comportamentais ( Behavioral Design Patterns)

- Chain of Responsability: usado para obter acoplamento fraco no design do software, onde uma solicitação do cliente épassada para uma cadeia de objetos para processá-los.
- Command: usado para implementar perda de acoplamento em um modelo de solicitação-resposta.
- Iterator: fornece uma maneira padrão de atravessar um grupo de objetos.
- Interpreter: define uma representação gramatical para um idioma e fornece um intérprete para lidar com essa gramática.
- Mediator: usado para fornecer um meio de comunicação centralizado entre diferentes objetos em um sistema.
- Memento: usado quando queremos salvar o estado de um objeto para que possamos restaurá-lo posteriormente.
- Observer: útil quando você está interessado no estado de um objeto e deseja ser notificado sempre que houver alguma alteração.
- State: usado quando um objeto muda seu comportamento com base em seu estado interno.
- Strategy: usado quando temos vários algoritmos para uma tarefa específica e o cliente decide a implementação real a ser usada no tempo de execução.
- Template Method: usado para criar um esboço de método de modelo e adiar algumas das etapas de implementação para as subclasses.
- Visitor: usado quando temos que realizar uma operação em um grupo de tipos semelhantes de objetos.