# UiHelpAPI 0.0.1

## Docker (Em Construção...)

## Documentação (Em construção...)

Logo após executar o projeto, acesse: [IP]/swagger para ver a documentação gerada pelo swagger.

##  Instalação ⚙

[.NET 8.0 STK](https://dotnet.microsoft.com/en-us/download)

[MySql Server](https://dev.mysql.com/downloads/installer/)

## Configuração para Desenvolvimento 💻


#### Baixando Pacotes

```bash
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.0
```

#### Baixando Dependências (Na raiz do projeto)

```bash
dotnet restore
```

```bash
dotnet build
```

#### Configurando o Banco de Dados (Na raiz do projeto)

> Execute esses comandos caso não há uma pasta com as migrations no projeto

```bash
dotnet ef migrations add NomeDaMigration  # 'NomeDaMigration' descreve a alteração
```

```bash
dotnet ef database update
```

## ConnectionString 🔌

#### `UiHelpAPI/appsettings.json`
```json
  "ConnectionStrings": {
    "MySql": "Server=localhost;Database=UiHelper;Uid=;Pwd="
  }
```

> Configure o Builder do DbContext caso queria usar outro DATABASE

#### `UiHelpAPI/Program.cs`
```csharp
builder.Services.AddDbContext<DatabaseContexto>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySql"), 
        MySqlServerVersion.AutoDetect(builder.Configuration.GetConnectionString("MySql")))); 
var app = builder.Build();
```





