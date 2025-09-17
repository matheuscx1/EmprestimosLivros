📚 Sistema de Empréstimo de Livros
Um sistema completo de gerenciamento de empréstimos de livros desenvolvido em ASP.NET Core MVC com autenticação de usuários e funcionalidades de CRUD.

🚀 Tecnologias e Ferramentas Utilizadas
ASP.NET Core MVC - Framework principal

Entity Framework Core - ORM para acesso a dados

SQL Server - Banco de dados

ClosedXML - Geração de planilhas Excel

Bootstrap - Framework CSS para interface

DataTables - Tabelas interativas

Newtonsoft.Json - Serialização JSON para sessões

HMACSHA512 - Criptografia de senhas

📋 Funcionalidades Implementadas
🔐 Sistema de Autenticação
Registro de novos usuários com validação de dados

Login com verificação de credenciais

Hash de senhas com salt usando algoritmo HMACSHA512

Controle de sessão de usuários

Middleware de autorização para rotas protegidas

📖 Gestão de Empréstimos
CRUD completo de empréstimos de livros

Cadastro com dados do recebedor, fornecedor e livro

Edição e exclusão de registros

Validação de dados no cliente e servidor

Interface responsiva com Bootstrap

📊 Exportação de Dados
Geração de relatórios em Excel usando ClosedXML

Exportação de todos os empréstimos cadastrados

Formatação automática de planilhas

🎨 Interface de Usuário
Layouts diferentes para usuários logados e deslogados

Mensagens de feedback com TempData

Validações visuais com Bootstrap

Tabelas interativas com DataTables

Design responsivo para diferentes dispositivos

🧠 Conceitos Aplicados
Padrões de Projeto
Injeção de Dependência: Todos os serviços são injetados via construtor

Repository Pattern: Separação clara entre camadas de acesso a dados

Service Pattern: Lógica de negócio centralizada em classes de serviço

DTOs (Data Transfer Objects): Para transferência segura de dados entre camadas

Segurança
Hash de senhas com salt único para cada usuário

Sessões para manter autenticação

Validação tanto no cliente quanto no servidor

Proteção contra SQL Injection usando Entity Framework

Arquitetura
Separação de responsabilidades em controllers, services e data access

Modelos de resposta padronizados com ResponseModel<T>

Interfaces para definir contratos de serviços

Migrations para controle de versão do banco de dados
