﻿using CatalogoDeLivros.Application.ViewModels;
using System.Text.Json;

namespace CatalogoDeLivros.Infrastructure.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private string books = @"{
    ""id"": 1,
    ""name"": ""Journey to the Center of the Earth"",
    ""price"": 10.00,
    ""specifications"": {
      ""Originally published"": ""November 25, 1864"",
      ""Author"": ""Jules Verne"",
      ""Page count"": 183,
      ""Illustrator"": ""Édouard Riou"",
      ""Genres"": [
        ""Science Fiction"",
        ""Adventure fiction""
      ]
    }
    },
      {
        ""id"": 2,
        ""name"": ""20,000 Leagues Under the Sea"",
        ""price"": 10.10,
        ""specifications"": {
            ""Originally published"": ""June 20, 1870"",
          ""Author"": ""Jules Verne"",
          ""Page count"": 213,
          ""Illustrator"": [
            ""Édouard Riou"",
            ""Alphonse-Marie-Adolphe de Neuville""
          ],
          ""Genres"": ""Adventure fiction""
        }
    },
      {
        ""id"": 3,
        ""name"": ""Harry Potter and the Goblet of Fire"",
        ""price"": 7.31,
        ""specifications"": {
            ""Originally published"": ""July 8, 2000"",
          ""Author"": ""J. K. Rowling"",
          ""Page count"": 636,
          ""Illustrator"": [
            ""Cliff Wright"",
            ""Mary GrandPré""
          ],
          ""Genres"": [
            ""Fantasy Fiction"",
            ""Drama"",
            ""Young adult fiction"",
            ""Mystery"",
            ""Thriller"",
            ""Bildungsroman""
          ]
        }
    },
      {
        ""id"": 4,
        ""name"": ""Fantastic Beasts and Where to Find Them: The Original Screenplay"",
        ""price"": 11.15,
        ""specifications"": {
            ""Originally published"": ""November 18, 2016"",
          ""Author"": ""J. K. Rowling"",
          ""Page count"": 457,
          ""Illustrator"": ""Cliff Wright"",
          ""Genres"": [
            ""Fantasy Fiction"",
            ""Contemporary fantasy"",
            ""Screenplay""
          ]
        }
    },
      {
        ""id"": 5,
        ""name"": ""The Lord of the Rings"",
        ""price"": 6.15,
        ""specifications"": {
            ""Originally published"": ""July 29, 1954"",
          ""Author"": ""J. R. R. Tolkien"",
          ""Page count"": 715,
          ""Illustrator"": [
            ""Alan Lee"",
            ""Ted Nashmith"",
            ""J. R. R. Tolkien""
          ],
          ""Genres"": [
            ""Fantasy Fiction"",
            ""Adventure Fiction""
          ]
        }
    }";
        public LivroRepository()
        {

        }

        public List<LivroViewModel> Listar()
        {
            return JsonSerializer.Deserialize<List<LivroViewModel>>(books);
        }
    }
}
