<h1 align="center">
  TODO List
</h1>

<p align="center">
 <a href="https://www.linkedin.com/in/rodrigofelixf/" target="_blank">
    <img src="https://img.shields.io/static/v1?label=Linkedin&message=@rodrigofelixf&color=8257E5&labelColor=000000" alt="@rodrigofelixf" />
</a>
 <img src="https://img.shields.io/static/v1?label=Tipo&message=Desafio&color=8257E5&labelColor=000000" alt="Desafio" />
</p>

API para gerenciar tarefas (CRUD) que faz parte [desse desafio](https://github.com/simplify-liferay/desafio-junior-backend-simplify) para pessoas desenvolvedoras backend j�nior, que se candidatam para a Simplify.

O projeto foi elaborado [nesse v�deo](https://youtu.be/IjProDV001o).

## Tecnologias
 
- [ASP.NET Core](https://learn.microsoft.com/pt-br/aspnet/core)
- [Entity Framework Core](https://learn.microsoft.com/pt-br/ef/core/)
- [PostgreSql](https://www.postgresql.org/docs/)
- [Swagger](https://swagger.io/docs/)


## Pr�ticas adotadas

- SOLID, DRY, YAGNI, KISS
- API REST
- Consultas com Entity Framework
- Inje��o de Depend�ncias
- Tratamento de respostas de erro
- Gera��o autom�tica do Swagger

## Como Executar

- Clonar reposit�rio git
- Navegar ate o projeto:
```bash
$ cd Todo-List-Api
```
- Executar a aplica��o:
```bash
$ dotnet build
$ dotnet run
```

A API poder� ser acessada em [localhost:porta].
O Swagger poder� ser visualizado em [localhost:porta/swagger-ui.html](http://localhost:porta/swagger-ui.html)

## API Endpoints

Para fazer as requisi��es HTTP abaixo, foi utilizada a ferramenta [httpie](https://httpie.io):

- Criar Tarefa 
```
$ http POST :<Porta>/todo title="Todo 1" description="Desc Todo 1" prioridade=1

[
  {
    "descricao": "Desc Todo 1",
    "id": 1,
    "nome": "Todo 1",
    "prioridade": 1,
    "realizado": false
  }
]
```

- Listar Tarefas
```
$ http GET :8080/todos

[
  {
    "descricao": "Desc Todo 1",
    "id": 1,
    "nome": "Todo 1",
    "prioridade": 1,
    "realizado": false
  }
]
```

- Atualizar Tarefa
```
$ http PUT :8080/todos/1 nome="Todo 1 Up" descricao="Desc Todo 1 Up" prioridade=2

[
  {
    "descricao": "Desc Todo 1 Up",
    "id": 1,
    "nome": "Todo 1 Up",
    "prioridade": 2,
    "realizado": false
  }
]
```

- Remover Tarefa
```
http DELETE :8080/todos/1

[ ]
```