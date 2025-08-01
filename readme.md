# 🧼 Clean API Example (.NET 8 - ASP.NET Core Web API)

Este projeto é uma prova de conceito de uma arquitetura para APIs moderna, modular e testável, baseada em princípios da **Clean Architecture** e do padrão **ADR (Action-Domain-Responder)**.

> ⚠️ Ao contrário do padrão MVC tradicional, essa abordagem separa claramente responsabilidades, facilita testes e promove desacoplamento entre domínios e infraestrutura.

---

## ✅ Objetivos

- Evitar os problemas do padrão MVC em APIs (baixa coesão, difícil testabilidade, controllers inchados)
- Demonstrar como organizar uma API em camadas bem definidas:
  - API (routes/controllers)
  - Application (serviços e DTOs)
  - Domain (entidades e contratos)
  - Infrastructure (repositórios)

---

## 🧱 Estrutura de Pastas

```
CleanApi/
├── Api/                      # Camada HTTP (Controllers)
│   └── Controllers/
│       └── UsersController.cs
│   └── Program.cs
│
├── Application/             # Lógica de negócio (Services, DTOs, Interfaces)
│   ├── Dtos/
│   │   └── UserResponseDto.cs
│   ├── Interfaces/
│   │   └── IUserService.cs
│   └── Services/
│       └── UserService.cs
│
├── Domain/                  # Entidades e interfaces de domínio
│   ├── Entities/
│   │   └── User.cs
│   └── Interfaces/
│       └── IUserRepository.cs
│
├── Infrastructure/          # Acesso a dados (ex: banco, cache, API externa)
│   └── Repositories/
│       └── UserRepository.cs
│
└── CleanApi.sln             # Solução
```

---

## ⚙️ Tecnologias Usadas

- [.NET 8](https://dotnet.microsoft.com/)
- ASP.NET Core Web API
- Injeção de dependência (DI)
- Clean Architecture + ADR
- Repositório fake em memória

---

## ▶️ Como Rodar Localmente

1. Clone o projeto:

```bash
git clone https://github.com/seu-usuario/CleanApi.git
cd CleanApi
```

2. Compile e execute:

```bash
dotnet run --project Api
```

3. A API será iniciada em:

```
http://localhost:5137
```

4. Teste no navegador ou Postman:

```
GET http://localhost:5137/api/users/aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa
```

---

## 🧪 Exemplo de Resposta

```json
{
  "id": "aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa",
  "name": "Maria Bublitz",
  "email": "maria@example.com"
}
```

---

## 💡 Conceitos Aplicados

### Clean Architecture

- Definida por Robert C. Martin ("Uncle Bob")
- Camadas concêntricas com domínio no centro
- Infraestrutura depende do domínio (e não o contrário)
- Alta testabilidade e baixo acoplamento

### ADR (Action-Domain-Responder)

- Action: controller recebe e roteia a requisição
- Domain: lógica de negócio pura (services)
- Responder: retorna resposta HTTP

---

## 📌 Benefícios

| Aspecto               | MVC Tradicional | Clean Architecture |
|------------------------|------------------|---------------------|
| Separação de camadas  | ❌               | ✅                  |
| Testabilidade         | ❌               | ✅                  |
| Acoplamento           | Alto              | Baixo               |
| Flexibilidade         | Baixa             | Alta                |
| Sustentabilidade      | Baixa             | Alta                |

---

## 🛡 Segurança (básica)

- Uso de DTOs evita exposição de dados sensíveis (como senhas)
- Separação de responsabilidades previne leaks de lógica para camadas HTTP

---

## 📦 Melhorias Futuras

- Adicionar camada de persistência real (Ex: EF Core + SQLite/PostgreSQL)
- Adicionar validação de entrada (Ex: FluentValidation)
- Testes unitários e de integração
- Middleware de logging e tratamento global de erros

---

## ✍️ Autor

**Jorge Bublitz**  
Projeto baseado no artigo: *"MVC não é o padrão mais eficiente para APIs"* (PDF)
