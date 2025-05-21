# AgendamentoMedico
Projeto de um sistema de agendamento médico em C#

# Necessário
Possuir a SDK 9.0 instalada
Instalar pacote do Swagger para debug: "Swashbuckle.AspNetCore.SwaggerUI"
Instalar pacote dotnet-ef
Instalar EntityFrameWorkCore
Instalar EntityFrameWorkCore.SQlite
Instalar EntityFrameWorkCore.Design

# Banco de dados

# Criando Migrations
dotnet ef migrations add Initial
dotnet ef migrations add InitialConvenio --context ConvenioContext --output-dir Migrations/Convenio


# Instanciando a Migration
dotnet ef database update
dotnet ef database update --context ConvenioContext


# TODO

- [X] Cadastrar especialidade
- [X] Listar especialidades
- [X] Cadastrar convênio
- [X] Listar convênios
- [] Definir disponibilidade de horário
- [] Listar horários de marcação
- [] Agendar uma consulta
- [] Listar agendamentos
- [] Gerar atendimento
- [] Listar atendimentos