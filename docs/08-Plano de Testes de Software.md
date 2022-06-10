# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
- Aplicação publicada na Internet
- Navegador da Internet - Chrome, Firefox ou Edge
- Conectividade de Internet para acesso às plataformas (APISs)


Os testes funcionais a serem realizados no software são descritos a seguir.
  
|Caso de Teste | CT-01 - Cadastrar usuário                 |
|--|-------------------------------------------------------|
|Requisitos Associados |RF-01 - A aplicação deve permitir o cadastro de novos usuários por meio de um formulário contendo: nome completo, email, senha e data de nascimento.  <br> |
|Objetivo de Teste| Verificar se os dados do usuário estão sendo registrados corretamente |
|Passos| 1) Acessar o Navegador <br> 2) Informar o endereço do site <br> 3) Visualizar a página de cadastro <br> 4) Fazer o cadastro no site|
|Critérios de Êxito| - Os dados do usuário devem ser guardados no banco de dados|


|Caso de Teste | CT-02 - Se conectar com os dados de acesso cadastrado|
|--|-------------------------------------------------------|
|Requisitos Associados |RF-02 - A aplicação deve permitir que o usuário faça login com as suas credenciais cadastradas e mante-ló no banco de dados. |
|Objetivo de Teste| Verificar se o sistema de "login" está funcionando corretamente |
|Passos| 1) Acessar o Navegador <br> 2) Informar o endereço do site <br> 3) Visualizar a página de "login" <br> 4) Inserir os dados de acesso <br> 5) Logar na aplicação |
|Critérios de Êxito| - Os dados de aceso devem ser comparados com os guardados no banco de dados <br> - O software deve redirecionar para a página de "login" e ter sucesso ao efetuar o mesmo <br> - O software deve redirecionar o usuário para a página de busca|


|Caso de Teste | CT-03 - Fazer upload de livro|
|--|-------------------------------------------------------|
|Requisitos Associados |RF-03 - A aplicação deve conter a opção de upload de livros com campos pré-definidos de publicação e de preenchimento obrigatório, como capa, autor, categoria, sinopse e faixa etária |
|Objetivo de Teste| Verificar se o sistema de upload está enviando o livro para o banco de dados e apresentando na aplicação |
|Passos| 1) Acessar o Navegador <br> 2) Informar o endereço do site <br> 3) Visualizar a tela de busca <br> 4) Clicar no botão de upload <br> 5) Inserir dados do livro <br> 6) Fazer upload do livro |
|Critérios de Êxito| - A aplicação deve salvar todos os dados do livro no banco de dados <br> - O livro upado deve aparecer na biblioteca da aplicação e aparecer disponivel para download com todas as informações do livro


|Caso de Teste | CT-04 - Visualizar as informações do livro escolhido|
|--|-------------------------------------------------------|
|Requisitos Associados | RF-04 - A aplicação deve permitir a visualização de livros disponíveis com os dados obrigatórios do cadastro. |
|Objetivo de Teste| Verificar se as informações do livro buscado estão sendo apresentadas |
|Passos| 1) Acessar o Navegador <br> 2) Informar o endereço do site <br> 3) Visualizar a página de "login" <br> 4) Inserir os dados de acesso ao site <br> 5) Visualizar a tela de busca <br> 6) Clicar em qualquer livro da página |
|Critérios de Êxito| - O numero do objeto do livro clicado deve ser armazenado em "idLivro" no banco de dados <br> - O livro clicado deve redirecionar o usuário para "livro.html" <br> - A tela de visualização do livro deve atualizar com as informações do livro clicado|


|Caso de Teste | CT-05 - Fazer download de livro|
|--|-------------------------------------------------------|
|Requisitos Associados |RF-05 - A aplicação deve permitir o download dos livros. |
|Objetivo de Teste| Verificar se o sistema de download está baixando corretamente o livro desejado |
|Passos| 1) Acessar o Navegador <br> 2) Informar o endereço do site <br> 3) Visualizar a tela de busca <br> 4) Selecionar o livro desejado <br> 5) Clicar na opção de download |
|Critérios de Êxito| - A aplicação deve ser capaz de buscar pelo livro desejado dentro do banco de dados <br> - O livro deve ser baixado no formato de pdf


|Caso de Teste | CT-06 - Pesquisar um livro|
|--|-------------------------------------------------------|
|Requisitos Associados |RF-06 - A aplicação deve conter um campo para busca de livros. |
|Objetivo de Teste| Verificar se o sistema de busca está apresentando o livro buscado |
|Passos| 1) Acessar o Navegador <br> 2) Informar o endereço do site <br> 3) Visualizar a tela de busca <br> 4) Informa no buscador do site o nome de um livro presente no site |
|Critérios de Êxito| - O conteúdo da página deve ser filtrado e apresentar apenas o livro buscado|


|Caso de Teste | CT-07 - Visualizar e editar dados do usuário|
|--|-------------------------------------------------------|
|Requisitos Associados |RF-07 -	A aplicação deve permitir ao usuário editar o perfil (adicionar foto, alterar email, adicionar telefone…) |
|Objetivo de Teste| Verificar se o usuário consegue ver os dados que ele cadastrou e editar |
|Passos| 1) Acessar o Navegador <br> 2) Informar o endereço do site <br> 3) Visualizar a tela de dados do usuário clicando no nome que ele cadastrou aparecendo no menu do site <br> 4) Visualizar se os dados que ele cadastrou no começo aparecem na tela <br> 5) Editar os dados |
|Critérios de Êxito| - Os dados do usuário devem ser atualizados no banco de dados <br> - O formulário deve apresentar os novos dados|


|Caso de Teste | CT-08 - Recuperar senha|
|--|-------------------------------------------------------|
|Requisitos Associados |RF-09 - A aplicação deve permitir que o usuario recupere sua senha. <br> RF-09 A aplicação deve disponibilizar um formlario exigindo informarções exclusivas do usuario para validar a recuperação de senha.|
|Objetivo de Teste| Permitir que o usuario tenha a possibilidade de recuperar sua senha em caso de esquecimento. <br>|
|Passos| 1) Acessar o Navegador <br> 2) Informar o endereço do site <br> 3) Visualizar a tela de login <br> 4) Clicar em esqueci minha senha <br> 5) Preencher formulario de recuperação de senha <br> 6) Inserir nova senha |
|Critérios de Êxito| - O usuario deve conseguir logar na aplicação utilizando a nova senha. <br>|