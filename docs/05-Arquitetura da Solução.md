# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Nesta seção são apresentados os detalhes técnicos da solução criada pela equipe, tratando dos componentes que fazem parte da solução e do ambiente de hospedagem da solução.

## Diagrama de componentes
Os componentes que fazem parte da solução são apresentados na Figura que se segue.
Exemplo: 


![Diagrama de Componentes](img/componentes.png)
<center>Figura 8 - Arquitetura da Solução</center>

A solução implementada conta com os seguintes módulos:
- **Navegador** - Interface básica do sistema  
  - **Páginas Web** - Conjunto de arquivos HTML, CSS, JavaScript e imagens que implementam as funcionalidades do sistema.
   - **Local Storage** - armazenamento mantido no Navegador, onde são implementados bancos de dados baseados em JSON. São eles: 
     - **Canais** - seções de notícias apresentadas 
     - **Comentários** - registro de opiniões dos usuários sobre as notícias
     - **Preferidas** - lista de notícias mantidas para leitura e acesso posterior
 - **Leak API ** -  plataforma que permite o acesso aos resultados exibidos no site.
 - **Hospedagem** - local na Internet onde as páginas são mantidas e acessadas pelo navegador. 


## Hospedagem
O site utiliza a plataforma do GitHub como ambiente de hospedagem do site do projeto. O site é mantido no ambiente da URL: 

> - [Website com GitHub Pages](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2022-2-e1-proj-web-t6-grupo_2)
