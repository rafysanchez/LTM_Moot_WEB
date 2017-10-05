# 
Sistemas com base em MVC C# com WEB API - Sistema de Login usando token e Angulars JS

Objetivos:
 
1.      Criar um site utilizando SPA com Angular na versão 2 ou superior
1.1.    - Fazer uma tela de login, que irá se autenticar em uma api (que o candidato também irá desenvolver) que retornará o token.
1.2.   - Criar uma tela que irá fazer uma listagem qualquer (por exemplo produto), e esta tela só pode ser acessada se o usuário tiver o token de autenticação antes, essa listagem deverá vir de uma api que deverá receber e validar o token antes de devolver a listagem.
1.3.   Caso o token esteja expirado deverá ser redirecionado para a tela de login.
 
2.      Criar uma Api rest.
2.1.   - Implemente o padrão jwt ou oauth para geração e validação de token de acesso.
2.2.    – O token deve expirar em 1 minuto.
2.3.    - Criar uma rota de listagem de produtos, que só deve retorna a lista de produtos se receber um token válido.
2.4.    - Criar um seed (criação do banco de dados e carga de dados), pode ser um script ou utilizar um framework (Ex: Migrations).
 
3.      Versionamento no Git.
3.1.   Disponibilize os 2 projetos para download através de repositórios que suportem o git (Ex: Github, BitBucket, VisualStudioOnline).
3.2.    - Disponibilize no Readme.md de cada projeto as instruções claras de dependências para montagem e execução do ambiente de teste.
3.3.    - Somente serão aceitos testes utilizando banco de dados MongoDB e SqlServer Express (Não utilizar localdb).
