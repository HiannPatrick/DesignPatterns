# AbstractFactory

Também conhecido como: Fábrica abstrata

## Fontes 

https://refactoring.guru/pt-br/design-patterns/abstract-factory
https://www.youtube.com/watch?v=5qowLOsyz3A (Usado como base para o AbstractFactory_Exemplo1)
https://refactoring.guru/pt-br/design-patterns/abstract-factory/csharp/example (AbstractFactory_Exemplo1)

## Definição

O Abstract Factory é um padrão de projeto criacional que permite que você produza famílias de objetos relacionados sem ter que especificar suas classes concretas.

O Abstract Factory define uma interface para criar todos os produtos distintos, mas deixa a criação real do produto para classes fábrica concretas. Cada tipo de fábrica corresponde a uma determinada variedade de produtos.

O código cliente chama os métodos de criação de um objeto fábrica em vez de criar produtos diretamente com uma chamada de construtor (usando operador new). Como uma fábrica corresponde a uma única variante de produto, todos os seus produtos serão compatíveis.

O código cliente trabalha com fábricas e produtos somente através de suas interfaces abstratas. Ele permite que o mesmo código cliente funcione com produtos diferentes. Você apenas cria uma nova classe fábrica concreta e a passa para o código cliente.

## Problema

Imagine que você está criando um simulador de loja de mobílias. Seu código consiste de classes que representam:

1. Uma família de produtos relacionados, como: Cadeira + Sofá + MesaDeCentro.
2. Várias variantes dessa família. Por exemplo, produtos Cadeira + Sofá + MesaDeCentro estão disponíveis nessas variantes: Moderno, Vitoriano, ArtDeco.

Você precisa de um jeito de criar objetos de mobília individuais para que eles combinem com outros objetos da mesma família. Os clientes ficam muito bravos quando recebem mobília que não combina.

E ainda, você não quer mudar o código existente quando adiciona novos produtos ou famílias de produtos ao programa. Os vendedores de mobílias atualizam seus catálogos com frequência e você não vai querer mudar o código base cada vez que isso acontece.

## Solução
	
A primeira coisa que o padrão Abstract Factory sugere é declarar explicitamente interfaces para cada produto distinto da família de produtos (ex: cadeira, sofá ou mesa de centro). Então você pode fazer todas as variantes dos produtos seguirem essas interfaces. Por exemplo, todas as variantes de cadeira podem implementar a interface Cadeira; todas as variantes de mesa de centro podem implementar a interface MesaDeCentro, e assim por diante.

O próximo passo é declarar a fábrica abstrata—uma interface com uma lista de métodos de criação para todos os produtos que fazem parte da família de produtos (por exemplo, criarCadeira, criarSofá e criarMesaDeCentro). Esses métodos devem retornar tipos abstratos de produtos representados pelas interfaces que extraímos previamente: Cadeira, Sofá, MesaDeCentro e assim por diante.

Agora, e o que fazer sobre as variantes de produtos? Para cada variante de uma família de produtos nós criamos uma classe fábrica separada baseada na interface FábricaAbstrata. Uma fábrica é uma classe que retorna produtos de um tipo em particular. Por exemplo, a classe FábricaMobíliaModerna só pode criar objetos CadeiraModerna, SofáModerno, e MesaDeCentroModerna.

O código cliente tem que funcionar com ambos as fábricas e produtos via suas respectivas interfaces abstratas. Isso permite que você mude o tipo de uma fábrica que passou para o código cliente, bem como a variante do produto que o código cliente recebeu, sem quebrar o código cliente atual.

Digamos que o cliente quer que uma fábrica produza uma cadeira. O cliente não precisa estar ciente da classe fábrica, e nem se importa que tipo de cadeira ele receberá. Seja ela um modelo Moderno ou no estilo Vitoriano, o cliente precisa tratar todas as cadeiras da mesma maneira, usando a interface abstrata Cadeira. Com essa abordagem, a única coisa que o cliente sabe sobre a cadeira é que ela implementa o método sentar de alguma maneira. E também, seja qual for a variante da cadeira retornada, ela sempre irá combinar com o tipo de sofá ou mesa de centro produzido pelo mesmo objeto fábrica.

Há mais uma coisa a se clarificar: se o cliente está exposto apenas às interfaces abstratas, o que realmente cria os objetos fábrica então? Geralmente, o programa cria um objeto fábrica concreto no estágio de inicialização. Antes disso, o programa deve selecionar o tipo de fábrica dependendo da configuração ou definições de ambiente.

## Aplicabilidade
	
 Use o Abstract Factory quando seu código precisa trabalhar com diversas famílias de produtos relacionados, mas que você não quer depender de classes concretas daqueles produtos-eles podem ser desconhecidos de antemão ou você simplesmente quer permitir uma futura escalabilidade.

 O Abstract Factory fornece a você uma interface para a criação de objetos de cada classe das famílias de produtos. Desde que seu código crie objetos a partir dessa interface, você não precisará se preocupar em criar uma variante errada de um produto que não coincida com produtos já criados por sua aplicação.

Considere implementar o Abstract Factory quando você tem uma classe com um conjunto de métodos fábrica que desfoquem sua responsabilidade principal.

Em um programa bem desenvolvido cada classe é responsável por apenas uma coisa. Quando uma classe lida com múltiplos tipos de produto, pode valer a pena extrair seus métodos fábrica em uma classe fábrica solitária ou uma implementação plena do Abstract Factory.

## Como implementar
	
1. Mapeie uma matriz de tipos de produtos distintos versus as variantes desses produtos.
2. Declare interfaces de produto abstratas para todos os tipos de produto. Então, faça todas as classes concretas de produtos implementar essas interfaces.
3. Declare a interface da fábrica abstrata com um conjuntos de métodos de criação para todos os produtos abstratos.
4. Implemente um conjunto de classes fábricas concretas, uma para cada variante de produto.
5. Crie um código de inicialização da fábrica em algum lugar da aplicação. Ele deve instanciar uma das classes fábrica concretas, dependendo da configuração da aplicação ou do ambiente atual. Passe esse objeto fábrica para todas as classes que constroem produtos.
6. Escaneie o código e encontre todas as chamadas diretas para construtores de produtos. Substitua-as por chamadas para o método de criação apropriado no objeto fábrica.

## Prós

 - Você pode ter certeza que os produtos que você obtém de uma fábrica são compatíveis entre si.
 - Você evita um vínculo forte entre produtos concretos e o código cliente.
 - Princípio de responsabilidade única. Você pode extrair o código de criação do produto para um lugar, fazendo o código ser de fácil manutenção.
 - Princípio aberto/fechado. Você pode introduzir novas variantes de produtos sem quebrar o código cliente existente.
	
## Contras

- O código pode tornar-se mais complicado do que deveria ser, uma vez que muitas novas interfaces e classes são introduzidas junto com o padrão.

##  Relações com outros padrões

- Muitos projetos começam usando o Factory Method (menos complicado e mais customizável através de subclasses) e evoluem para o Abstract Factory, Prototype, ou Builder (mais flexíveis, mas mais complicados).
- O Builder foca em construir objetos complexos passo a passo. O Abstract Factory se especializa em criar famílias de objetos relacionados. O Abstract Factory retorna o produto imediatamente, enquanto que o Builder permite que você execute algumas etapas de construção antes de buscar o produto.
- Classes Abstract Factory são quase sempre baseadas em um conjunto de métodos fábrica, mas você também pode usar o Prototype para compor métodos dessas classes.
- O Abstract Factory pode servir como uma alternativa para o Facade quando você precisa apenas esconder do código cliente a forma com que são criados os objetos do subsistema.
- Você pode usar o Abstract Factory junto com o Bridge. Esse pareamento é útil quando algumas abstrações definidas pelo Bridge só podem trabalhar com implementações específicas. Neste caso, o Abstract Factory pode encapsular essas relações e esconder a complexidade do código cliente.
- As AbstractFactory, Builders, e Prototype podem todos ser implementados como Singletons.

## Implementação em C#

### Exemplos de uso 

O padrão Abstract Factory é bastante comum no código C#. Muitas frameworks e bibliotecas o utilizam para fornecer uma maneira de estender e personalizar seus componentes padrão.

### Identificação 

O padrão é fácil de reconhecer pelos seus métodos, que retornam um objeto fárica. Em seguida, a fábrica é usado para criar subcomponentes específicos.