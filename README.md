ApiTarefa
API de tarefas CRUD com responsabilidade, contrato e serviços

Este projeto fornece uma API RestFull para gerenciar tarefas. A API é implementada em C# usando Web ASP NET.CORE

Funcionalidades

Criação de tarefas
Listagem de tarefas
Atualização de tarefas
Exclusão de tarefas
Como usar

Para instalar e configurar o projeto, siga estas etapas:

Clone o repositório do GitHub.
Crie um banco de dados SQLSERVER.
Execute o script sql/schema.sql para criar o esquema do banco de dados.
Configure as propriedades do banco de dados no arquivo appsettings.json de acordo com o seu banco de dados, atualize corretamente, exemplo abaixo:
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": { "DataBase": "Server=localhost;Database=DB_SistemaTarefas; Integrated Security=True" },
  "AllowedHosts": "*"
}
NOTE QUE NÃO COLOQUEI COMO OBRIGATORIO USUARIO EM SENHA NA ESPECIFICAÇÃO: INTEGRATED SECURITY=TRUE! 
CASO VOCE QUEIRA COLOCAR NA SUA STRING DE CONEXÃO MUDE ESTE CAMPO MENCIONADO ACIMA PARA "FALSE"!

Para fazer chamadas para a API, você pode usar uma ferramenta como o Swager ou o Postman.

Contribuir

Para contribuir para o projeto, siga estas etapas:

Crie uma issue para descrever a sua contribuição.
Crie um pull request com o seu código.
Requisitos

C# 6.0 u superior
Web AspNet.Core
SQL

Espero que isto te ajude a entender o projeto! 
