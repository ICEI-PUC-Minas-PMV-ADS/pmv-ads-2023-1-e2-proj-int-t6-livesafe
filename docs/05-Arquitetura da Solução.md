# Arquitetura da Solução

Nesta seção são apresentados os detalhes técnicos da solução criada pela equipe, tratando dos componentes que fazem parte da solução e do ambiente de hospedagem da solução.

### Diagrama de Classes

<p>A arquitetura da solução consiste em uma aplicação web, uma API Rest e um banco de dados MySQL Server hospedados em um servidor web na WEB-Hostinger. O sistema pode ser acessado através de interfaces web instaladas em desktops, notebooks e dispositivos móveis.</p>

<p>Na figura a seguir são apresentados as classes do sistema: </p>

<img width="631" alt="Screenshot 2023-04-12 at 8 59 23 PM" src="https://user-images.githubusercontent.com/112135152/231611507-c1044542-5e9a-4f49-b132-bd1e352919c4.png">

## Modelo ER (Projeto Conceitual)

Para modelar um sistema de vazamento de senha usando a abordagem de modelagem de dados Entidade-Relacionamento (ER), você precisaria identificar as entidades e seus relacionamentos no sistema. Aqui está uma proposta de modelo ER para um sistema de vazamento de senha :

<h3>Entidades:</h3>

Usuario: Pessoa que realiza a busca em relação ao vazamento de seus dados.

Histórico de pesquisas: Onde vão ficar armazenados os resultados das pequisas realizadas.

Plano: Modalidade a ser escolhida pelo usuário.

<h3>Relacionamentos:</h3>
<p>Um Usuario pode ter nenhum histórico ou muitos</p>
<p>Um histórico pode ser de um ou muitos usuários</p>
<p>Um usuário pode ter somente um plano</p>
<p>Um plano possui um ou muitos usuários</p>

<img width="631" alt="Screenshot 2023-04-12 at 9 00 57 PM" src="https://user-images.githubusercontent.com/112135152/231612295-bc6fc3cb-be1b-4150-b377-6be6b5fa4a27.png">



## Projeto da Base de Dados

<p>Definir os requisitos de negócios: O sistema deve permitir que os usuários realizem pesquisas. Os usuários devem ser capazes de visualizar os resultados da consulta dos vazamentos de dados.</p>

![3938e5fb-b5be-49d1-9c48-152b0c8b4e9b](https://user-images.githubusercontent.com/112135152/231613654-d1ffe176-b422-4f90-ab4f-2634cef94ff5.jpg)




## Tecnologias Utilizadas
A solução implementada conta com os seguintes módulos:
- **Navegador** - Interface básica do sistema  
  - **Páginas Web** - Conjunto de arquivos HTML, CSS, JavaScript, C#, Angula, MySQL e imagens que implementam as funcionalidades do sistema.
   - **Local Storage** - armazenamento mantido no Navegador, onde são implementados bancos de dados baseados em JSON. São eles: 
 - **Hospedagem** - local na Internet onde as páginas são mantidas e acessadas pelo navegador. 


## Hospedagem
O site utiliza a plataforma do [000webhost](https://projetolifesafe.000webhostapp.com/) como ambiente de hospedagem. Atravésda URL: 

> - https://projetolifesafe.000webhostapp.com/

O site utiliza a plataforma do GitHub como ambiente de hospedagem do código fonte do site do projeto. O código é mantido no ambiente da URL: 

> - [Website com GitHub Pages](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t6-livesafe/)
