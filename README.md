# UiHelpAPI 0.0.1

## Docker (Em Construção...)


##  Instalação ⚙

[.NET 8.0 STK](https://dotnet.microsoft.com/en-us/download)

[MySql Server](https://dev.mysql.com/downloads/installer/)

## ConnectionString 🔌

![image](https://github.com/user-attachments/assets/39540072-92a8-4789-8d1d-a8ea34fada12)

#### Caso queria usar outro database, lembre-se de modificar o builder.services em program.cs

![image](https://github.com/user-attachments/assets/cc9b97c9-4b50-4015-95f6-b96494f139bd)

## Comandos 💻

![image](https://github.com/user-attachments/assets/c48c3528-7ea7-4933-930d-480f873282ef) 

dotnet restore |  Para baixar as dependências 

![image](https://github.com/user-attachments/assets/c41e821d-d8a5-4aea-9ff1-6f4248e1e9ab)

dotnet build | Para compilar o projeto

![image](https://github.com/user-attachments/assets/fcf152de-6d15-4093-8ffa-6afbc38bc58a)

dotnet run | Para executar o projeto



#### Recomendo apagar a pasta migrations e usar os seguintes comandos:

dotnet ef migrations add NomeDaMigration (exemplo: AddBanco) | Para criar as migrations novamente 


dotnet ef update database | Para atualizar o banco 


## Documentação (Em construção...)

Logo após executar o projeto, acesse: [IP]/swagger para ver a documentação gerada pelo swagger.
