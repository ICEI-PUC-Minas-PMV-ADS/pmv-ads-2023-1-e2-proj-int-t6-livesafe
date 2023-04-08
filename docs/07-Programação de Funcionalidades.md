# Plano de Teste de Software 

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Os requisitos para realização dos testes de software são:
<li>Site publicado na Internet</li>
<li>Navegador da Internet - Chrome, Firefox ou Edge</li>
<li>Conectividade de Internet para acesso às plataformas (APISs)</li>


Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

|Caso de Teste  | CT 01 - Realizar Cadastro e Login|
|-------|-------------------------|
|Requisito Associado| RF-01-A plataforma deve oferecer ao usuário a opção de realizar o cadastro e login.  | 
|Objetivo do Teste| <ul><li>Verificar se o cadastro é efetivado após preencher as informações corretamente</li><li>Verificar se após o cadastro o sistema irá exibir a tela de login</li></ul> | 
|Passos| <ol><li>Selecionar a opção cadastro de usuário.</li><li>Fornecer os dados para cadastro (nome, cpf, tipo de usuário, data de nascimento).</li><li>Clicar no botão Salvar.</li><li>Fornecer dados para login ( login e senha)</li><li>Clicar no botão continuar</li></ol>|  
|Critério de Êxito|  <ul><li>O sistema informa uma mensagem de confirmação de cadastro.</li><li>O usuário foi cadastrado no banco de dados com sucesso.</li></ul>  | 


|Caso de Teste  | CT 02 - Realizar Pesquisa de Vazamento de Dados|
|-------|-------------------------|
|Requisito Associado| RF02-O site deve  oferecer ao usuário os mecanismos para que seja realizada a pesquisa para verificar se houve vazamento de dados.  | 
|Objetivo do Teste| <ul><li>Verificar a existência do campo de pesquisa, na tela inicial, onde serão informados os dados para consulta de vazamentos de senhas.</li></ul> | 
|Passos| <ol><li>Acessar o Navegador</li><li> Informar o endereço do Site</li><li>Visualizar a página principal</li></ol>|  
|Critério de Êxito| <ul><li>Deve haver uma requisição AJAX no painel NETWORK das ferramentas do Desenvolvedor (recurso do Navegador).</li><li>Deve ser exibida a caixa de pesquisa em formato de campo de forma visível, para ser realizado a pesquisa de vazamento de senhas, o campo é alterável e de preenchimento obrigatório.</li></ul> | 

|Caso de Teste  | CT 03 -  Exibir resultado da pesquisa|
|-------|-------------------------|
|Requisito Associado| O site  deve exibir uma mensagem informando ao usuário o resultado da pesquisa. | 
|Objetivo do Teste| <ul><li>Verificar se o sistema retorna com o resultado da pesquisa</li></ul> | 
|Passos| <ol><li>Digitar o cpf ou e-mail válidos  para verificar vazamento de dados no campo de pesquisa.</li><li>Clicar no botão Verificar.</li></ol>|  
|Critério de Êxito| Devem ser exibidas as mensagens padrão do sistema:<ul><li>Se houver vazamento de dados:”Péssimo, seus dados foram vazados”.</li><li>Se não houver vazamento de dados:”Boa notícias!! Nenhum vazamento de dados foi encontrado”.</li><li>Se não informar dados:”Ops! Informe seus dados”.</li></ul> | 


|Caso de Teste  | CT 04 -  Disponibilizar informações|
|-------|-------------------------|
|Requisito Associado| O site deve disponibilizar informações sobre Segurança Digital.  | 
|Objetivo do Teste| <ul><li>Verificar se as informações estão sendo exibidas na tela inicial.</li><</ul>| 
|Passos| <ol><li>Acessar o Navegador</li><li>Informar o endereço do Site</li><li>Visualizar a página principal</li></ol>|  
|Critério de Êxito| <ul><li>A página deve apresentar o título da informação contendo dicas sobre segurança  “Como proteger senhas nas redes sociais” e um vídeo de como manter seguro na internet.</li></ul> | 

|Caso de Teste  | CT 05 -  Salvar registro do usuário|
|-------|-------------------------|
|Requisito Associado| O site deve permitir ao usuário visualizar todos dados vazados e o registro do usuário é salvo no banco de dados.  | 
|Objetivo do Teste| <ul><li>Verificar o relatório dos dados vazados</li><li>Verificar se o registro do usuário é salvo no banco de dados.</li></ul> | 
|Passos| <ol><li>Clicar no comando Verificar após preencher o campo de pesquisa de vazamento de dados.</li></ol>|  
|Critério de Êxito| <ul><li>O sistema retorna o relatório dos dados vazados.</li><li>O sistema salva o registro do usuário no banco de dados</li></ul> | 
