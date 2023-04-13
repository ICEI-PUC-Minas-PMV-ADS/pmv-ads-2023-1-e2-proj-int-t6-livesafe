# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

Nesta seção são apresentados os detalhes técnicos da solução criada pela equipe, tratando dos componentes que fazem parte da solução e do ambiente de hospedagem da solução.

### Diagrama de Classes

<p>A arquitetura da solução consiste em uma aplicação web, uma API Rest e um banco de dados SQL Server hospedados em um servidor web na AZURE. O sistema pode ser acessado através de interfaces web instaladas em desktops, notebooks, dispositivos móveis e painéis televisores.</p>

<p>Na figura a seguir são apresentados as classes do sistema. </p>
<img width="631" alt="Screenshot 2023-04-12 at 8 59 23 PM" src="https://user-images.githubusercontent.com/112135152/231611507-c1044542-5e9a-4f49-b132-bd1e352919c4.png">
## Modelo ER (Projeto Conceitual)

Para modelar um sistema de agendamento de horários usando a abordagem de modelagem de dados Entidade-Relacionamento (ER), você precisaria identificar as entidades e seus relacionamentos no sistema. Aqui está uma proposta de modelo ER para um sistema de agendamento de horários:

Entidades:

Cliente: pessoa que agenda o horário.

Funcionário: pessoa que presta o serviço agendado.

Serviço: tipo de serviço a ser prestado.

Horário: horário disponível para agendamento.

Agendamento: reserva de um horário para um serviço com um funcionário.

Relacionamentos:
Um cliente pode fazer muitos agendamentos
Um agendamento é feito por um cliente
Um agendamento é para um único horário
Um agendamento é para um único serviço
Um serviço pode estar em muitos agendamentos
Um agendamento é para um único funcionário
Um funcionário pode ter muitos agendamentos.

<img width="631" alt="Screenshot 2023-04-12 at 9 00 57 PM" src="https://user-images.githubusercontent.com/112135152/231612295-bc6fc3cb-be1b-4150-b377-6be6b5fa4a27.png">



## Projeto da Base de Dados

Definir os requisitos de negócios: O sistema de agendamento de horários deve permitir que clientes agendem serviços com funcionários em horários disponíveis. Os clientes devem ser capazes de visualizar os horários disponíveis para os serviços que desejam agendar, selecionar um horário disponível e confirmar o agendamento. Os funcionários devem ser capazes de visualizar sua agenda diária com os serviços agendados e os horários disponíveis.
Identificar as entidades e seus relacionamentos.

<img width="631" alt="Screenshot 2023-04-12 at 8 58 26 PM" src="https://user-images.githubusercontent.com/112135152/231612372-89128cb4-9da2-4a71-bb47-02973871049b.png">



## Tecnologias Utilizadas
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
