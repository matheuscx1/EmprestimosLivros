# 📚 Sistema de Empréstimo de Livros  

<div align="center">  
<img src="https://img.shields.io/badge/ASP.NET_Core-6.0-purple?style=for-the-badge&logo=dotnet"/>  
<img src="https://img.shields.io/badge/SQL_Server-2019-blue?style=for-the-badge&logo=microsoft-sql-server"/>  
<img src="https://img.shields.io/badge/Bootstrap-5.0-blueviolet?style=for-the-badge&logo=bootstrap"/>  
</div>  

Um sistema completo de gerenciamento de empréstimos de livros desenvolvido em **ASP.NET Core MVC** com autenticação de usuários, controle de sessões e funcionalidades de CRUD.  

---

## ✨ Funcionalidades  

### 🔐 Autenticação e Autorização  
- Registro de usuários com validação de dados  
- Login seguro com **hash de senhas (HMACSHA512)**  
- Middleware personalizado para controle de sessões  
- Proteção de rotas para usuários autenticados  

### 📖 Gestão de Empréstimos  
- CRUD completo de empréstimos de livros  
- Validações no cliente e servidor  
- Interface responsiva com **Bootstrap 5**  
- Listagem interativa com **DataTables**  

### 📊 Exportação de Dados  
- Relatórios em Excel com **ClosedXML**  
- Exportação de dados formatados  
- Geração automática de planilhas  

---

## 🛠️ Tecnologias Utilizadas  

| Tecnologia          | Finalidade                        |  
|---------------------|----------------------------------|  
| **ASP.NET Core 6.0** | Framework principal MVC           |  
| **Entity Framework Core** | ORM e acesso a dados        |  
| **SQL Server**      | Banco de dados relacional         |  
| **Bootstrap 5**     | Framework CSS responsivo          |  
| **ClosedXML**       | Geração de planilhas Excel        |  
| **DataTables**      | Tabelas interativas               |  
| **Newtonsoft.Json** | Serialização para sessões         |  
| **HMACSHA512**      | Criptografia de senhas            |  

---

## 🏗️ Arquitetura e Padrões  

### 🔧 Padrões de Projeto  
- **Injeção de Dependência (DI)**  
- **Repository Pattern**  
- **Service Pattern**  
- **Data Transfer Objects (DTOs)**  
