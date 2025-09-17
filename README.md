# API Catálogo

Uma API REST desenvolvida em .NET 8 para gerenciamento de catálogo de produtos e categorias.

## 🚀 Tecnologias Utilizadas

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- MySQL (Pomelo.EntityFrameworkCore.MySql)
- Swagger/OpenAPI
- Docker

## 📋 Pré-requisitos

- .NET 8 SDK
- MySQL Server
- Docker (opcional)

## ⚙️ Configuração

### 1. Clone o repositório
```bash
git clone https://github.com/salesluis/api-catalogo
cd APICatalogo
```

### 2. Configure a string de conexão

1. Copie o arquivo de exemplo:
```bash
cp appsettings.Example.json appsettings.Development.json
```

2. Edite o arquivo `appsettings.Development.json` e configure sua string de conexão:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;DataBase=ApiCatalogoDB;Uid=seu_usuario;Pwd=sua_senha"
  }
}
```

### 3. Execute as migrações
```bash
dotnet ef database update
```

### 4. Execute a aplicação
```bash
dotnet run
```

A API estará disponível em:
- HTTP: `http://localhost:5066`
- HTTPS: `https://localhost:7278`
- Swagger UI: `https://localhost:7278/swagger`

## 🐳 Docker

Para executar com Docker:

```bash
docker build -t api-catalogo .
docker run -p 8080:8080 api-catalogo
```

## 📚 Endpoints da API

### Categorias
- `GET /api/categorias` - Lista todas as categorias
- `GET /api/categorias/{id}` - Busca categoria por ID
- `POST /api/categorias` - Cria nova categoria
- `PUT /api/categorias/{id}` - Atualiza categoria
- `DELETE /api/categorias/{id}` - Remove categoria

### Produtos
- `GET /api/produtos` - Lista todos os produtos
- `GET /api/produtos/{id}` - Busca produto por ID
- `POST /api/produtos` - Cria novo produto
- `PUT /api/produtos/{id}` - Atualiza produto
- `DELETE /api/produtos/{id}` - Remove produto

## 🔒 Segurança

- **NUNCA** commite arquivos com dados sensíveis
- Use variáveis de ambiente para configurações de produção
- O arquivo `appsettings.Development.json` está no `.gitignore` por segurança
- Sempre use o arquivo `appsettings.Example.json` como base

## 📝 Estrutura do Projeto

```
APICatalogo/
├── Controllers/          # Controladores da API
├── Context/             # Contexto do Entity Framework
├── Extensions/          # Extensões personalizadas
├── Filters/             # Filtros de API
├── Logging/             # Sistema de logging customizado
├── Migrations/          # Migrações do banco de dados
├── Models/              # Modelos de dados
├── Repositories/        # Repositórios
├── Validation/          # Validações customizadas
├── appsettings.json     # Configurações base
├── appsettings.Example.json # Exemplo de configuração
└── Program.cs           # Ponto de entrada da aplicação
```

## 🤝 Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

