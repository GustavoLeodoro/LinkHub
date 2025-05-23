<h1 align="center">📎 LinkHub</h1>

<p align="center"><strong>LinkHub</strong> é uma aplicação web desenvolvida com <strong>ASP.NET Core MVC</strong>, que oferece um sistema completo de <strong>CRUD</strong> para gerenciamento de contatos vinculados a usuários. Ideal como projeto de aprendizado para quem está se aprofundando em <strong>ASP.NET Core</strong>, <strong>Entity Framework Core</strong> e boas práticas de arquitetura em camadas.</p>

---

<h2 align="center">✨ Funcionalidades</h2>

- 🔐 Autenticação e controle de sessão por usuário  
- 📇 Cadastro, edição, visualização e exclusão de contatos  
- 👥 Relacionamento entre usuários e seus respectivos contatos  
- 🧩 Mapeamento de entidades com **Entity Framework Core** (via Fluent API)  
- ✅ Validações de dados com feedback amigável ao usuário  
- 🔒 Controle de acesso baseado em login ativo  

---

<h2 align="center">🚀 Tecnologias Utilizadas</h2>

| 💻 Camada        | 🛠️ Tecnologias                           |
|------------------|-------------------------------------------|
| 🧠 Back-End       | ASP.NET Core MVC (.NET 6+)                |
| 🗂️ ORM           | Entity Framework Core                     |
| 💬 Linguagem     | C#                                        |
| 🗄️ Banco de Dados | SQL Server (LocalDB)                      |
| 🎨 Front-End      | Razor Pages (.cshtml) + Bootstrap         |
| 🔐 Sessão        | ASP.NET Core Session                      |
| 🧰 Ferramentas   | Visual Studio 2022, .NET CLI, Git         |

---

<h2 align="center">🗃️ Estrutura do Projeto</h2>

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

<h2 align="center">⚙️ Como Executar o Projeto</h2>

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

<h2 align="center">✅ Recursos Implementados</h2>

- 🔐 Login e autenticação de usuários  
- 📇 CRUD completo de contatos  
- ⚠️ Validações personalizadas com mensagens de erro amigáveis  
- 🔒 Controle de sessão e redirecionamento seguro  
- 🏗️ Arquitetura baseada em camadas com separação de responsabilidades  
- ⚙️ Migrações automatizadas com EF Core  


---


<h2 align="center">🎥 Demonstração</h2>

<p align="center">
  <a href="https://www.youtube.com/watch?v=b4BV7KWhDWs" target="_blank">
    <img src="https://github.com/user-attachments/assets/65a7655b-e99c-4871-946f-d526f93b8a42" alt="Clique para ver o vídeo de demonstração" />
  </a>
</p>

---

<h2 align="center">📄 Licença</h2>

Distribuído sob a licença **MIT**.  
Sinta-se à vontade para usar, estudar, adaptar e contribuir com este projeto!

---

<h3 align="center">👨‍💻 Feito por Gustavo Leodoro</h3>

