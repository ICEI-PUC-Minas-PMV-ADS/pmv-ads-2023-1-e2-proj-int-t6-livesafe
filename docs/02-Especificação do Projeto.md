# Especificações do Projeto

A definição exata do problema e os pontos mais relevantes a serem tratados neste projeto foi consolidada com a participação dos usuários em um trabalho de imersão feito pelos membros da equipe a partir da observação dos usuários em seu local natural e por meio de entrevistas relacionadas a segurança de dados na internet. Os detalhes levantados nesse processo foram consolidados na forma de personas e histórias de usuários.

## Personas

As personas levantadas durante o processo de entendimento do problema são apresentadas na Figuras que se seguem.

![Capturar](https://user-images.githubusercontent.com/104511336/228982853-3b1f38d8-3384-4113-99ca-37a03f2f102b.PNG) 

![Capturar 2](https://user-images.githubusercontent.com/104511336/228982885-caba2134-86b7-4e59-bf73-f16d79ead89a.PNG)

![capturar 3](https://user-images.githubusercontent.com/104511336/228982931-8c7c7304-0c5a-4ae5-a2f8-f72a65c3cfe7.PNG)





## Histórias de Usuários

A partir da compreensão do dia a dia das personas identificadas para o projeto, foram registradas as seguintes histórias de usuários.

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Genivaldo Alves | Aplicativos para melhorias de seu negócios, compras de matéria prima e organização financeira e logística        | Para que o negócio possa prosperar com o objetivo de ter  dinheiro no final do mês para pagar funcionários.          |
|Marta Helena | Saber se foi hackeada, acompanhar segurança de suas redes socias.       | Se sentir mais segura na internet             |
|Francisco Moraes | Checar periodicamente se meus dados bancários estão seguros e quais bancos vazaram.          | Garantir que o fluxo financeiro da minha hamburgueria esteja a salvo.               |
|Antonella Soares | Saber se a senha do canal do youtube foi usada por outra pessoa e caso aconteça ter conhecimento para tomar as devidas providências.           | Para ter segurança com os conteúdos gerados, evitando ser prejudicada por pessoas mal intencionadas.           |

## Requisitos

O escopo funcional do projeto é definido por meio dos requisitos funcionais que descrevem as possibilidades interação dos usuários, bem como os requisitos não funcionais descrevem os aspectos que o sistema deverá apresentar de maneira geral. Estes requisitos são apresentados a seguir.

### Requisitos Funcionais

A tabela a seguir apresenta os requisitos do projeto, identificando a prioridade em que os mesmos devem ser entregues.

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A tela inicial deve apresentar  caixa para pesquisa de dados, links sobre segurança de dados dinâmicos, um vídeo explicativo sobre o tema obtido pela internet(API). | ALTA | 
|RF-002| O site deve permitir o uso da consulta, digitar o login desejado para pesquisa. Caso o dado tenha sido vazado o sistema deverá apresentar a mensagem padrão “Cuidado!Encontramos um vazamento de informação!””.    | ALTA |
|RF-003| O site deve permitir clicar no comando de consulta, digitar o login desejado para pesquisa. Caso o dado NÃO tenha sido vazado apresentar a mensagem padrão do sistema “Boas notícias! Seus Dados não foram vazados!.  | ALTA |
|RF-004| O site deve permitir ao usuário visualizar todos dados vazados e perspectivas de databases (bancos, sites e apps) de onde saíram. | ALTA |
|RF-005| O site deve apresentar dicas de segurança, logo após a pesquisa, para ajudar a manter dados do usuário preservados. | MÉDIA |

### Requisitos não Funcionais

A tabela a seguir apresenta os requisitos não funcionais que o projeto deverá atender.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deve ser publicado em um ambiente acessível publicamente na Internet (Repl.it, GitHub Pages, Heroku);  | ALTA | 
|RNF-002| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge) |  ALTA | 
|RNF-003| O site deverá ser responsivo permitindo a visualização em um celular de forma adequada. |  MÉDIA | 
|RNF-004| O site deve ter bom nível de contraste entre os elementos da tela em conformidade. |  BAIXA | 

## Restrições

As questões que limitam a execução desse projeto e que se configuram como obrigações claras para o desenvolvimento do projeto em questão são apresentadas na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue no final do semestre letivo, não podendo advir a data de 01/12/2023. |
|02| O aplicativo não deve se restringir às tecnologias básicas da Web no BackEnd        |
|03| A equipe não pode subcontratar o desenvolvimento do trabalho.       |

## Diagrama de Casos de Uso

Esse diagrama contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

![Diagrama de caso de uso](https://user-images.githubusercontent.com/104511336/228986405-d8ffa1af-a802-4843-b07d-f07e03ebc8a2.PNG)
