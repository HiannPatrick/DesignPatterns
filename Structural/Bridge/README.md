# Bridge

Também conhecido como: Ponte

## Fontes 

https://refactoring.guru/pt-br/design-patterns/bridge

## Definição

O Bridge é um padrão de projeto estrutural que permite que você divida uma classe grande ou um conjunto de classes intimamente ligadas em duas hierarquias separadas—abstração e implementação—que podem ser desenvolvidas independentemente umas das outras.

O Bridge é um padrão de projeto estrutural que divide a lógica de negócio ou uma enorme classe em hierarquias de classe separadas que podem ser desenvolvidas independentemente.

Uma dessas hierarquias (geralmente chamada de Abstração) obterá uma referência a um objeto da segunda hierarquia (Implementação). A abstração poderá delegar algumas (às vezes, a maioria) de suas chamadas para o objeto de implementações. Como todas as implementações terão uma interface comum, elas seriam intercambiáveis dentro da abstração.

## Problema

Abstração? Implementação? Soam um pouco assustadoras? Fique calmo que vamos considerar um exemplo simples.

Digamos que você tem uma classe Forma geométrica com um par de subclasses: Círculo e Quadrado. Você quer estender essa hierarquia de classe para incorporar cores, então você planeja criar as subclasses de forma Vermelho e Azul. Contudo, já que você já tem duas subclasses, você precisa criar quatro combinações de classe tais como CírculoAzul e QuadradoVermelho.

Adicionar novos tipos de forma e cores à hierarquia irá fazê-la crescer exponencialmente. Por exemplo, para adicionar uma forma de triângulo você vai precisar introduzir duas subclasses, uma para cada cor. E depois disso, adicionando uma nova cor será necessário três subclasses, uma para cada tipo de forma. Quanto mais longe vamos, pior isso fica.

## Solução
	
Esse problema ocorre porque estamos tentando estender as classes de forma em duas dimensões diferentes: por forma e por cor. Isso é um problema muito comum com herança de classe.

O padrão Bridge tenta resolver esse problema ao trocar de herança para composição do objeto. Isso significa que você extrai uma das dimensões em uma hierarquia de classe separada, para que as classes originais referenciem um objeto da nova hierarquia, ao invés de ter todos os seus estados e comportamentos dentro de uma classe.

Seguindo essa abordagem nós podemos extrair o código relacionado à cor em sua própria classe com duas subclasses: Vermelho e Azul. A classe Forma então ganha um campo de referência apontando para um dos objetos de cor. Agora a forma pode delegar qualquer trabalho referente a cor para o objeto ligado a cor. Aquela referência vai agir como uma ponte entre as classes Forma e Cor. De agora em diante, para adicionar novas cores não será necessário mudar a hierarquia da forma e vice versa.

### Exemplos de uso 
O padrão Bridge é especialmente útil ao lidar com aplicações multi plataforma, oferecer suporte a vários tipos de servidores de banco de dados, ou ao trabalhar com vários provedores de API de um determinado tipo (por exemplo, plataformas em nuvem, redes sociais etc.)

###Identificação
O Bridge pode ser reconhecida por uma distinção clara entre alguma entidade controladora e várias plataformas diferentes nas quais ela se baseia.

### Abstração e implementação

O livro GoF  introduz os termos Abstração e Implementação como parte da definição do Bridge. Na minha opinião, os termos soam muito acadêmicos e fazem o padrão parecer algo mais complicado do que realmente é. Tendo lido o exemplo simples com formas e cores, vamos decifrar o significado por trás das palavras assustadoras do livro GoF.

Abstração (também chamado de interface) é uma camada de controle de alto nível para alguma entidade. Essa camada não deve fazer nenhum tipo de trabalho por conta própria. Ela deve delegar o trabalho para a camada de implementação (também chamada de plataforma).

Observe que não estamos falando sobre interfaces ou classes abstratas da sua linguagem de programação. São coisas diferentes.

Quando falamos sobre aplicações reais, a abstração pode ser representada por uma interface gráfica de usuário (GUI), e a implementação pode ser o código subjacente do sistema operacional (API) a qual a camada GUI chama em resposta às interações do usuário.

Geralmente falando, você pode estender tal aplicação em duas direções independentes:

*Ter diversas GUIs diferentes (por exemplo, feitas para clientes regulares ou administradores).
*Suportar diversas APIs diferente (por exemplo, para ser capaz de lançar a aplicação no Windows, Linux e macOS).

No pior dos cenários, essa aplicação pode se parecer como uma enorme tigela de espaguete onde centenas de condicionais conectam diferentes tipos de GUI com vários APIs por todo o código.

Você pode trazer ordem para esse caos extraindo o código relacionado a específicas combinações interface-plataforma para classes separadas. Contudo, logo você vai descobrir que existirão muitas dessas classes. A hierarquia de classes irá crescer exponencialmente porque adicionando um novo GUI ou suportando um API diferente irá ser necessário criar mais e mais classes.

Vamos tentar resolver esse problema com o padrão Bridge. Ele sugere que as classes sejam divididas em duas hierarquias:

* Abstração: a camada GUI da aplicação.
* Implementação: As APIs do sistema operacional.

O objeto da abstração controla a aparência da aplicação, delegando o verdadeiro trabalho para o objeto de implementação ligado. Implementações diferentes são intercambiáveis desde que sigam uma interface comum, permitindo que a mesma GUI trabalhe no Windows e Linux.

Como resultado você pode mudar as classes GUI sem tocar nas classes ligadas a API. Além disso, adicionar suporte para outro sistema operacional só requer a criação de uma subclasse na hierarquia de implementação.

## Analogia com o mundo real


## Aplicabilidade
	
Utilize o padrão Bridge quando você quer dividir e organizar uma classe monolítica que tem diversas variantes da mesma funcionalidade (por exemplo, se a classe pode trabalhar com diversos servidores de base de dados).

 Quanto maior a classe se torna, mais difícil é de entender como ela funciona, e mais tempo se leva para fazer mudanças. As mudanças feitas para uma das variações de funcionalidade podem precisar de mudanças feitas em toda a classe, o que quase sempre resulta em erros ou falha em lidar com efeitos colaterais.

O padrão Bridge permite que você divida uma classe monolítica em diversas hierarquias de classe. Após isso, você pode modificar as classes em cada hierarquia independentemente das classes nas outras. Essa abordagem simplifica a manutenção do código e minimiza o risco de quebrar o código existente.

 Utilize o padrão quando você precisa estender uma classe em diversas dimensões ortogonais (independentes).

 O Bridge sugere que você extraia uma hierarquia de classe separada para cada uma das dimensões. A classe original delega o trabalho relacionado para os objetos pertencentes àquelas hierarquias ao invés de fazer tudo por conta própria.

 Utilize o Bridge se você precisar ser capaz de trocar implementações durante o momento de execução.

 Embora seja opcional, o padrão Bridge permite que você substitua o objeto de implementação dentro da abstração. É tão fácil quanto designar um novo valor para um campo.

A propósito, este último item é o maior motivo pelo qual muitas pessoas confundem o Bridge com o padrão Strategy. Lembre-se que um padrão é mais que apenas uma maneira de estruturar suas classes. Ele também pode comunicar intenções e resolver um problema.

## Como implementar
	
1. Identifique as dimensões ortogonais em suas classes. Esses conceitos independentes podem ser: abstração/plataforma, domínio/infraestrutura, front-end/back-end, ou interface/implementação.
2. Veja quais operações o cliente precisa e defina-as na classe abstração base.
3. Determine as operações disponíveis em todas as plataformas. Declare aquelas que a abstração precisa na interface geral de implementação.
4. Crie classes concretas de implementação para todas as plataformas de seu domínio, mas certifique-se que todas elas sigam a interface de implementação.
5. Dentro da classe de abstração, adicione um campo de referência para o tipo de implementação. A abstração delega a maior parte do trabalho para o objeto de implementação que foi referenciado neste campo.
6. Se você tem diversas variantes de lógica de alto nível, crie abstrações refinadas para cada variante estendendo a classe de abstração básica.
7. O código cliente deve passar um objeto de implementação para o construtor da abstração para associar um com ou outro. Após isso, o cliente pode esquecer sobre a implementação e trabalhar apenas com o objeto de abstração.

## Prós

- Você pode criar classes e aplicações independentes de plataforma;
- O código cliente trabalha com abstrações em alto nível. Ele não fica exposto a detalhes de plataforma.
- Princípio aberto/fechado. Você pode introduzir novas abstrações e implementações independentemente uma das outras.
- Princípio de responsabilidade única. Você pode focar na lógica de alto nível na abstração e em detalhes de plataforma na implementação.

	
## Contras

- Você pode tornar o código mais complicado ao aplicar o padrão em uma classe altamente coesa.

## Relações com outros padrões

- O Bridge é geralmente definido com antecedência, permitindo que você desenvolva partes de uma aplicação independentemente umas das outras. Por outro lado, o Adapter é comumente usado em aplicações existentes para fazer com que classes incompatíveis trabalhem bem juntas.

- O Bridge, State, Strategy (e de certa forma o Adapter) têm estruturas muito parecidas. De fato, todos esses padrões estão baseados em composição, o que é delegar o trabalho para outros objetos. Contudo, eles todos resolvem problemas diferentes. Um padrão não é apenas uma receita para estruturar seu código de uma maneira específica. Ele também pode comunicar a outros desenvolvedores o problema que o padrão resolve.

- Você pode usar o Abstract Factory junto com o Bridge. Esse pareamento é útil quando algumas abstrações definidas pelo Bridge só podem trabalhar com implementações específicas. Neste caso, o Abstract Factory pode encapsular essas relações e esconder a complexidade do código cliente.

- O Facade e o Mediator têm trabalhos parecidos: eles tentam organizar uma colaboração entre classes firmemente acopladas.
	* O Facade define uma interface simplificada para um subsistema de objetos, mas ele não introduz qualquer nova funcionalidade. O próprio subsistema não está ciente da Facade. Objetos dentro do subsistema podem se comunicar diretamente.
	* O Mediator centraliza a comunicação entre componentes do sistema. Os componentes só sabem do objeto mediador e não se comunicam diretamente.

- Você pode combinar o Builder com o Bridge: a classe diretor tem um papel de abstração, enquanto que diferentes construtores agem como implementações.