# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Nesta seção são apresentados os detalhes técnicos da solução criada pela equipe, tratando dos componentes que fazem parte da solução e do ambiente de hospedagem da solução.

### Diagrama de Classes

A arquitetura da solução consiste em uma aplicação web, uma API Rest e um banco de dados SQL Server hospedados em um servidor web na AZURE. O sistema pode ser acessado através de interfaces web instaladas em desktops, notebooks, dispositivos móveis e painéis televisores.

Na figura a seguir são apresentados as classes do sistema.
<img width="1000" alt="Screenshot 2023-04-12 at 8 49 10 PM" src="https://user-images.githubusercontent.com/112135152/231610879-a53f7434-0e0b-4410-a03b-16eeee90fd3b.png">




A solução implementada conta com os seguintes módulos:
- **Navegador** - Interface básica do sistema  
  - **Páginas Web** - Conjunto de arquivos HTML, CSS, JavaScript e imagens que implementam as funcionalidades do sistema.
   - **Local Storage** - armazenamento mantido no Navegador, onde são implementados bancos de dados baseados em JSON. São eles: 
     - **Canais** - seções de notícias apresentadas 
     - **Comentários** - registro de opiniões dos usuários sobre as notícias
     - **Preferidas** - lista de notícias mantidas para leitura e acesso posterior
 - **Leak API** -  plataforma que permite o acesso aos resultados exibidos no site.
 - **Hospedagem** - local na Internet onde as páginas são mantidas e acessadas pelo navegador. 


## Hospedagem
O site utiliza a plataforma do GitHub como ambiente de hospedagem do site do projeto. O site é mantido no ambiente da URL: 

> - [Website com GitHub Pages](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e1-proj-web-t6-grupo_2)
