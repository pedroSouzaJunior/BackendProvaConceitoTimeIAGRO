# BackendProvaConceitoTimeIAGRO

Este é um projeto web API criado em .NET 6 utilizando o Visual Studio 2022. Ele é um modelo de prova de conceito para o processo selevito do time IAGRO da Mil Tec.

## Configuração
Para executar este projeto, siga as instruções abaixo:

1. Certifique-se de ter o .NET 6 SDK instalado em sua máquina.
2. Clone este repositório em seu computador.
3. Abra o arquivo CatalogoDeLivros.sln no Visual Studio 2022. Ele se encontra na pasta CatalogoDeLivros
4. Clique no botão "Executar" para executar o projeto.

## Uso

Este projeto é uma _API RESTful_ que permite:

* __Buscar produtos no arquivo JSON disponibilizado [books.json];__
* __Buscar livros por suas especificações(autor, nome do livro ou outro atributo);__
* __Calcular o valor do frete em 20% o valor do livro.__

Para usar a API, você pode enviar requisições HTTP utilizando um software cliente como o Postman ou o Insomnia. As rotas disponíveis são as seguintes:

| Método HTTP | Endpoint                             | Descrição                                 |
| ----------- | ------------------------------------ | ----------------------------------------- |
| GET         | /CatalogoDeLivros/livros             | Retorna todos os livros disponíveis.      |
| GET         | /CatalogoDeLivros/nome               | Retorna um livro com base no parâmetro nome. |
| GET         | /CatalogoDeLivros/preco              | Retorna um livro com base no parâmetro preco. |
| GET         | /CatalogoDeLivros/data-de-publicacao | Retorna uma lista de livros com base no parâmetro data. |
| GET         | /CatalogoDeLivros/autor              | Retorna uma lista de livros com base no parâmetro autor. |
| GET         | /CatalogoDeLivros/ilustrador         | Retorna uma lista de livros com base no parâmetro ilustrador. |
| GET         | /CatalogoDeLivros/genero             | Retorna uma lista de livros com base no parâmetro genero. |
| GET         | /CatalogoDeLivros/frete              | Calcula o valor de frete de um livro com base no parâmetro nome. |



Os dados devem ser enviados no formato JSON. Abaixo está um exemplo de como buscar todos os livros utilizando o cURL:

```
curl -X 'GET' \
  'https://localhost:5001/CatalogoDeLivros/livros?ordem=asc' \
  -H 'accept: text/plain'
```

Você pode utilizar também o swagger da aplicação:

1. Navegue até a pasta raiz do projeto (CatalogoDeLivros) usando o terminal ou o prompt de comando.
Execute o seguinte comando para iniciar a aplicação:

```
dotnet run --project CatalogoDeLivros.API.csproj
```

2. A aplicação será iniciada e estará disponível em: https://localhost:5001.

3. Para acessar a documentação da API, abra o seu navegador e acesse http://localhost:5001/swagger.

Você verá a documentação da API com todos os endpoints disponíveis.

Certifique-se de ter definido a variável de ambiente ASPNETCORE_ENVIRONMENT para __Development__ para que o _Swagger_ seja habilitado e esteja disponível na porta 5001.

 Se você estiver usando o Visual Studio 2022, pode definir a variável de ambiente nas propriedades do projeto em _"Debug" -> "Environment variables"_.