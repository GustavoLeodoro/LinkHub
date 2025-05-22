# 📎 LinkHub

**LinkHub** é uma aplicação web desenvolvida com **ASP.NET Core MVC**, que oferece um sistema completo de **CRUD** para gerenciamento de contatos vinculados a usuários. Ideal como projeto de aprendizado para quem está se aprofundando em **ASP.NET Core**, **Entity Framework Core** e boas práticas de arquitetura em camadas.

---

## ✨ Funcionalidades

- 🔐 Autenticação e controle de sessão por usuário  
- 📇 Cadastro, edição, visualização e exclusão de contatos  
- 👥 Relacionamento entre usuários e seus respectivos contatos  
- 🧩 Mapeamento de entidades com **Entity Framework Core** (via Fluent API)  
- ✅ Validações de dados com feedback amigável ao usuário  
- 🔒 Controle de acesso baseado em login ativo  

---

## 🚀 Tecnologias Utilizadas

| 💻 Camada         | 🛠️ Tecnologias                            |
|-------------------|--------------------------------------------|
| 🧠 Back-End        | ASP.NET Core MVC (.NET 6+)                 |
| 🗂️ ORM            | Entity Framework Core                      |
| 💬 Linguagem      | C#                                         |
| 🗄️ Banco de Dados | SQL Server (LocalDB)                       |
| 🎨 Front-End       | Razor Pages (.cshtml) + Bootstrap          |
| 🔐 Sessão         | ASP.NET Core Session                       |
| 🧰 Ferramentas    | Visual Studio 2022, .NET CLI, Git          |


---

## 🗃️ Estrutura do Projeto

```bash
LinkHub/
├── Program.cs                   # Configuração da aplicação
├── Data/
│   ├── BancoContext.cs         # DbContext do EF Core
│   └── Map/
│       └── ContatoMap.cs       # Mapeamento via Fluent API
├── Models/
│   ├── Usuario.cs              # Modelo de usuário
│   └── Contato.cs              # Modelo de contato
├── Repositorio/
│   ├── Interfaces              # Interfaces dos repositórios
│   └── Implementacoes          # Implementação dos repositórios
├── Controllers/                # Controllers MVC
├── Views/                      # Razor Views
├── Migrations/                 # Migrações do EF Core
├── wwwroot/                    # Arquivos estáticos (CSS, JS, imagens)
├── appsettings.json            # Configurações gerais do projeto
└── LinkHub.csproj              # Arquivo de projeto .NET
```

---

## ⚙️ Como Executar o Projeto

1. **Clone o repositório:**

```bash
git clone https://github.com/GustavoLeodoro/LinkHub.git
cd LinkHub
```

2. **Atualize o banco de dados:**

```bash
dotnet ef database update
```

3. **Execute a aplicação:**

```bash
dotnet run
```

4. **Acesse pelo navegador:**

```
http://localhost:5000
```

---

## ✅ Recursos Implementados

- 🔐 Login e autenticação de usuários  
- 📇 CRUD completo de contatos  
- ⚠️ Validações personalizadas com mensagens de erro amigáveis  
- 🔒 Controle de sessão e redirecionamento seguro  
- 🏗️ Arquitetura baseada em camadas com separação de responsabilidades  
- ⚙️ Migrações automatizadas com EF Core  


---

## 📄 Licença

Distribuído sob a licença **MIT**.  
Sinta-se à vontade para usar, estudar, adaptar e contribuir com este projeto!

---

### 👨‍💻 Feito por **Gustavo Leodoro**
