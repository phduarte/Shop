# Shop

Um ERP completo para desktop utilizando C# e Windows Forms.

[![BCH compliance](https://bettercodehub.com/edge/badge/phduarte/Shop?branch=master)](https://bettercodehub.com/)

Um problema grande é melhor resolvido se for quebrado em pedaços menores e trabalhado cada pedaço com a atenção que ele requer, pela pessoa que melhor lhe entende.
Por se tratar de um sistema que "abraça" muitas responsabilidades e tende a se tornar grande e complexo, adotaremos a distribuição de camadas como arquitetura.

#### Arquitetura

A distribuição em camada ajuda na redução de acoplamento e aumentar a coesão do sistema e assim evitamos problemas de um software monolítico.
Ao longo do desenvolvimento, nos apoiaremos nos princípios e práticas de DDD para garantir uma boa distribuição de camada e definição de **Bounded Contexts**.
Cada nó operacional ou departamento, representará um **Contexto**. E cada Contexto possui sua própria distribuição em camadas.

Um contexto terá uma **Fachada** de serviços (*Facade Design Pattern* que aqui chamaremos de [Nome do Core] + "Services") que implementará as ações que esse Contexto fornece para os demais.

A maior divisão de camadas que um Contexto sofrerá nessa arquitetura,  terá uma aparência parecida com a abaixo, no entanto alguns contextos por necessidade, poderão ter apenas uma dessas camadas.

+ **Core**
  - DomainModel
  - Infrastructure
  - Application (ou Services)
+ **Interface**
  - Forms

Cada Contexto possui sua própria perspectiva de um *Aggregate* e isso faz com que tenhamos Clientes nos Contexto de Vendas, Caixa e Entregas, porém, cada um deles podem ter uma definição diferente do que é um cliente, sem que isso influencie os demais contextos.

+ **DomainModel** define as entidades e atributos do negócio, assim como seus comportamentos e a ligação entre eles. Modela o Negócio.
+ **Infrastructure** implementa as tecnológias ou serviços externos que o domínio depende. Se o Domínio requer persistência de dados, essa camada é responsável por gerar um mecanismo que viabilize essa persistência.
* **Application / Services** representam uma fachada de todo o Core. Uma classe que resume todas as funcionalidades do departamento de forma que simplifique o uso dela pelos demais departamentos.
+ **Core** o ecossistema que comporta todos os elementos fundamentais para a existencia do Contexto. Modelo de domínio, sua dependência tecnológica e workflows. Nesse projeto ela é representada por uma DLL que empacota o DomainModel, Infrastructure e Services.
+ **Interface** implementa interface que permitam a interação entre Homem e máquina, visual ou não! É uma camada empacotada à parte do Core pois isso aumenta a flexibilidade de IHC. Por ser pouco acoplada, substituí-la futuramente sem influenciar no funcionamento do núcleo do sistema se torna algo mais possível.

#### Commom

Esse Contexto em específico suporta todo o sistema fornecendo padrões de implementação ou recursos de uso comum que podem ser reutilizados.
