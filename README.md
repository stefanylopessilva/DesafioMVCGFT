# APLICAÇÃO MVC 💻
Aplicação desenvolvida para controle dos Starters GFT. Onde é possível realizar os cadastros dos Starters e de suas variadas Tecnologias, das quais irão estudar e realizar os módulos também cadastrados. Isso para diferentes turmas do Programa Start ao decorrer dos anos, além de fazer a disposição de diversos grupos com seus respectivos Scrum Masters, onde os mesmos poderão inserir os dados das Dailys que serão realizadas. Por fim, também é possível realizar a avaliação dos projetos desenvolvidos.
A aplicação possui diferentes tipos de acesso, ao se registrar, você possui o perfil de Scrum Master que toda vez que realizar login, envia um email ao administrador, com acesso apenas a Daily, para acesso como administrador e a todos os recursos da aplicação, usar os seguintes dados:
### Email: admin@admin.com
### Senha: Admin2021
#
## Tecnologias 💻

- .NET 5.0
- ASP .NET CORE IDENTITY 5.0.12
- ENTITY FRAMEWORK CORE 5.0.12
- MySql
- HTML5
- CSS3
- JQuery
#
## Rodando o projeto 💻

Para explorar o projeto na sua máquina primeiro certifique-se que você tem o Git, .NET 5.0 e o ASP .NET CORE instalado.

1º- Com o git pré-instalado clone o projeto:

~~~shell
git clone 
~~~

2º - Navegue até o a pasta que você clonou no passo anterior e instale as dependencias do projeto, digitando:

~~~shell
dotnet restore
~~~

4º - Abra a pasta que você clonou no seu editor de preferência

5º - Com o MySql instalado, crie um banco de dados e renomeie a string de conexao JSON na raiz do projeto com o nome do banco e suas credenciais.

6º - Certifique se de que você tem o gerenciador de pacotes NuGet na sua máquina e instale o EF Core e Pomelo MySql 5.0.3

7º Após isto rode as migrations para criar as tabelas no banco

~~~shell
dotnet ef database update
~~~

8º - Agora é só digitar o comando abaixo e depois digitar a url que irá aparecer no seu terminal na barra de pesquisa do navegador:
~~~shell
dotnet watch run
~~~

# Screenshots 📷

## Diagrama Entidade Relacionamento
![image](https://user-images.githubusercontent.com/29932387/152361107-49a33c61-d41b-42c7-b765-98ffcf4a5023.png)

#
## Home Page 🏠
![image](https://user-images.githubusercontent.com/29932387/144613604-81775a2d-b74a-4308-8077-b1b9913f4d2e.png)

#
## Login 📱
![image](https://user-images.githubusercontent.com/29932387/144615589-6eb82b2f-9640-4bd5-8164-324dc6248291.png)

#
## Registrar 💻
![image](https://user-images.githubusercontent.com/29932387/144614716-7527e906-fef5-4519-a4df-fcc979779ba9.png)

#
## Starters 👩‍🎓👨‍🎓
![image](https://user-images.githubusercontent.com/29932387/144615940-90c51168-fb32-4782-b776-73cfc4c09a67.png)

#
## Daily 📅
![image](https://user-images.githubusercontent.com/29932387/144616119-633bf8f3-4bbc-4a56-b6e3-1017b05b5cc4.png)

#
## Grupos 👪
![image](https://user-images.githubusercontent.com/29932387/144616243-954e0862-fa6e-407a-b896-37b4f61f56ef.png)

#
## Módulos 📚
![image](https://user-images.githubusercontent.com/29932387/144616458-e58a6d97-3ef6-4184-9b49-7ee45fd42343.png)

#
## Turmas 👨👩
![image](https://user-images.githubusercontent.com/29932387/144616583-ba57e1b4-2d6f-406c-88da-2059484b98c2.png)

#
## Avaliação dos Projetos 📑✒️
![image](https://user-images.githubusercontent.com/29932387/144617015-856d00fe-44ba-403d-a183-90885363e5f8.png)

#
## Tecnologias 💻📱
![image](https://user-images.githubusercontent.com/29932387/144617229-b1979a7c-c92d-4080-af3f-194aa5dc0fb5.png)

#
## Relatórios 📋
![image](https://user-images.githubusercontent.com/29932387/144617373-c4f83f6d-a890-4490-a285-41dc2b83e041.png)

#
## Não foi possível Apagar 📵
![image](https://user-images.githubusercontent.com/29932387/144617610-aa9aaec8-d44d-4da1-aca6-7d733d0e50d5.png)

#
## Acesso Negado 🚫
![image](https://user-images.githubusercontent.com/29932387/144617960-2ae5a0d5-bf7f-4adb-b7b9-881c90332733.png)

#
## Sair da Aplicação 🚪
![image](https://user-images.githubusercontent.com/29932387/144617774-42c31c9e-7886-41f8-9e34-cd835e7a6cb6.png)

#
## Email informando Login na Aplicação 📧
(Para utilizar essa funcionalidade, inserir os dados de e-mail no arquivo Login.cshtml.cs)
![image](https://user-images.githubusercontent.com/29932387/144638541-7febcc6e-8891-411f-be19-8d1b2332811a.png)