#Mediator
Fonte: https://refactoring.guru/pt-br/design-patterns/mediator
Fonte: https://www.youtube.com/watch?v=_io-phpFYVk

Definição
	O Mediator é um padrão de projeto comportamental que permite que você reduza as dependências caóticas entre objetos. O padrão restringe comunicações diretas entre objetos e os força a colaborar apenas através do objeto mediador.

Problema
	Digamos que você tem uma caixa de diálogo para criar e editar perfis de clientes. Ela consiste em vários controles de formulário tais como campos de texto, caixas de seleção, botões, etc.
	Alguns dos elementos do formulário podem interagir com outros. Por exemplo, selecionando a caixa de “Eu tenho um cão” pode revelar uma caixa de texto escondida para inserir o nome do cão. Outro exemplo é o botão enviar que tem que validar todos os campos antes de salvar os dados.
	Ao ter essa lógica implementada diretamente dentro do código dos elementos de formulários você torna as classes dos elementos muito difíceis de se reutilizar em outros formulários da aplicação. Por exemplo, você não será capaz de usar aquela classe de caixa de seleção dentro de outro formulário porque ela está acoplado com o campo de texto do nome do cão. Você pode ter ou todas as classes envolvidas na renderização do formulário de perfil, ou nenhuma.
Solução
	O padrão Mediator sugere que você deveria cessar toda comunicação direta entre componentes que você quer tornar independentes um do outro. Ao invés disso, esses componentes devem colaborar indiretamente, chamando um objeto mediador especial que redireciona as chamadas para os componentes apropriados. Como resultado, os componentes dependem apenas de uma única classe mediadora ao invés de serem acoplados a dúzias de outros colegas.
	No nosso exemplo com o formulário de edição de perfil, a classe diálogo em si pode agir como mediadora. O mais provável é que a classe diálogo já esteja ciente de todos seus sub-elementos, então você não precisa introduzir novas dependências nessa classe.
	A mudança mais significativa acontece com os próprios elementos do formulário. Vamos considerar o botão de enviar. Antes, cada vez que um usuário clicava no botão, ele teria que validar os valores de todos os elementos de formulário. Agora seu único trabalho é notificar a caixa de diálogo sobre o clique. Ao receber essa notificação, a própria caixa de diálogo realiza as validações ou passa a tarefa para os elementos individuais. Portanto, ao invés de estar amarrado a uma dúzia de elementos de formulário, o botão está dependente apenas da classe diálogo.
	Você pode ir além e fazer a dependência ainda mais frouxa extraindo a interface comum de todos os tipos de caixas de diálogo. A interface deve declarar o método de notificação que todos os elementos do formulário podem usar para notificar a caixa de diálogo sobre eventos acontecendo a aqueles elementos. Portanto, nosso botão enviar deve agora ser capaz de trabalhar com qualquer caixa de diálogo que implemente aquela interface.
	Dessa forma, o padrão Mediator permite que você encapsule uma complexa rede de relações entre vários objetos em apenas um objeto mediador. Quanto menos dependências uma classe tenha, mais fácil essa classe se torna para se modificar, estender, ou reutilizar.

Bônus
Analogia com o mundo real
	Os pilotos de aeronaves que se aproximam ou partem da área de controle do aeroporto não se comunicam diretamente entre si. Ao invés disso falam com um controlador de tráfego aéreo, que está sentando em uma torre alta perto da pista de aterrissagem. Sem o controlador do tráfego aéreo os pilotos precisariam estar cientes de cada avião nas redondezas do aeroporto, discutindo as prioridades de aterrissagem com um comitê de dúzias de outros pilotos. Isso provavelmente aumentaria em muito as estatísticas de acidentes aéreos.
	A torre não precisa fazer o controle de todo o voo. Ela existe apenas para garantir o condicionamento da área do terminal devido ao número de pessoas envolvidas ali, o que poderia ser demais para um piloto.

Aplicabilidade
	Utilize o padrão Mediator quando é difícil mudar algumas das classes porque elas estão firmemente acopladas a várias outras classes.
	O padrão lhe permite extrair todas as relações entre classes para uma classe separada, isolando quaisquer mudanças para um componente específico do resto dos componentes.
	Utilize o padrão quando você não pode reutilizar um componente em um programa diferente porque ele é muito dependente de outros componentes.
	Após você aplicar o Mediator, componentes individuais se tornam alheios aos outros componentes. Eles ainda podem se comunicar entre si, mas de forma indireta, através do objeto mediador. Para reutilizar um componente em uma aplicação diferente, você precisa fornecer a ele uma nova classe mediadora.
	Utilize o Mediator quando você se encontrar criando um monte de subclasses para componentes apenas para reutilizar algum comportamento básico em vários contextos.
	Como todas as relações entre componentes estão contidas dentro do mediador, é fácil definir novas maneiras para esses componentes colaborarem introduzindo novas classes mediadoras, sem ter que mudar os próprios componentes.

Como implementar
	1. Identifique um grupo de classes firmemente acopladas que se beneficiariam de estar mais independentes (por exemplo, para uma manutenção ou reutilização mais fácil dessas classes).
	2. Declare a interface do mediador e descreva o protocolo de comunicação desejado entre os mediadores e os diversos componentes. Na maioria dos casos, um único método para receber notificações de componentes é suficiente. Essa interface é crucial quando você quer reutilizar classes componente em diferentes contextos. Desde que o componente trabalhe com seu mediador através da interface genérica, você pode ligar o componente com diferentes implementações do mediador.
	3. Implemente a classe concreta do mediador. Essa classe se beneficia por armazenar referências a todos os componentes que gerencia.
	4. Você pode ainda ir além e fazer que o mediador fique responsável pela criação e destruição de objetos componente. Após isso, o mediador pode montar uma fábrica ou uma fachada.
	5. Componentes devem armazenar uma referência ao objeto do mediador. A conexão é geralmente estabelecida no construtor do componente, onde o objeto mediador é passado como um argumento.
	6. Mude o código dos componentes para que eles chamem o método de notificação do mediador ao invés de métodos de outros componentes. Extraia o código que envolve chamar os outros componentes para a classe do mediador. Execute esse código sempre que o mediador receba notificações daquele componente.

Prós
	- Princípio de responsabilidade única. Você pode extrair as comunicações entre vários componentes para um único lugar, tornando as de mais fácil entendimento e manutenção.
	- Princípio aberto/fechado. Você pode introduzir novos mediadores sem ter que mudar os próprios componentes.
	- Você pode reduzir o acoplamento entre os vários componentes de um programa.
	- Você pode reutilizar componentes individuais mais facilmente.

Contras
	- Com o tempo um mediador pode evoluir para um Objeto Deus.

Fonte: https://refactoring.guru/pt-br/design-patterns/mediator
Fonte: https://www.youtube.com/watch?v=_io-phpFYVk
