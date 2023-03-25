using CatalogoDeLivros.Application.Repositories;
using CatalogoDeLivros.Application.Services.Implementations;
using CatalogoDeLivros.Application.Services.Interfaces;
using CatalogoDeLivros.Application.ViewModels;
using Moq;

namespace CatalogoDeLivros.Test.Application
{
    public class CatalogoDeLivrosServiceTests
    {
        private readonly Mock<ILivroRepository> _livroRepositoryMock;
        private readonly ICatalogoDeLivros _catalogoDeLivrosService;

        public CatalogoDeLivrosServiceTests()
        {
            _livroRepositoryMock = new Mock<ILivroRepository>();
            _catalogoDeLivrosService = new CatalogoDeLivrosService(_livroRepositoryMock.Object);
        }

        [Fact]
        public void BuscarPorAutor_Deve_Retornar_Livros_Filtrados_Por_Autor()
        {
            // Arrange
            var autor = "John";
            var ordem = "asc";
            var livros = new List<LivroViewModel>
            {
                new LivroViewModel
                {
                    Name = "Livro 1",
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "John Doe"
                    }
                },
                new LivroViewModel
                {
                    Name = "Livro 2",
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "John Smith"
                    }
                },
                new LivroViewModel
                {
                    Name = "Livro 3",
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "Jane Doe"
                    }
                }
            };
            _livroRepositoryMock.Setup(x => x.Listar()).Returns(livros);

            // Act
            var result = _catalogoDeLivrosService.BuscarPorAutor(autor, ordem);

            // Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("Livro 1", result[0].Name);
            Assert.Equal("Livro 2", result[1].Name);
        }

        [Fact]
        public void BuscarPorIAutor_DeveRetornarListaOrdenadaPorPrecoAscendente()
        {
            // Arrange
            var autor = "John";
            var ordem = "asc";
            var livros = new List<LivroViewModel>
            {
                new LivroViewModel
                {
                    Name = "Livro 1",
                    Price = 50.00m,
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "John Doe"
                    }
                },
                new LivroViewModel
                {
                    Name = "Livro 2",
                    Price = 100.00m,
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "John Smith"
                    }
                },
                new LivroViewModel
                {
                    Name = "Livro 3",
                    Price = 25.00m,
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "Jane Doe"
                    }
                }
            };
            _livroRepositoryMock.Setup(x => x.Listar()).Returns(livros);

            // Act
            var result = _catalogoDeLivrosService.BuscarPorAutor(autor, ordem);

            //Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("Livro 1", result[0].Name);
            Assert.Equal("Livro 2", result[1].Name);
        }

        [Fact]
        public void BuscarPorAutor_DeveRetornarListaOrdenadaPorPrecoDescendente()
        {
            // Arrange
            var autor = "John";
            var ordem = "desc";
            var livros = new List<LivroViewModel>
            {
                new LivroViewModel
                {
                    Name = "Livro 1",
                    Price = 10.00m,
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "John Doe"
                    }
                },
                new LivroViewModel
                {
                    Name = "Livro 2",
                    Price = 100.00m,
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "John Smith"
                    }
                },
                new LivroViewModel
                {
                    Name = "Livro 3",
                    Price = 25.00m,
                    Specifications = new SpecificationsViewModel
                    {
                        Author = "Jane Doe"
                    }
                }
            };
            _livroRepositoryMock.Setup(x => x.Listar()).Returns(livros);

            // Act
            var result = _catalogoDeLivrosService.BuscarPorAutor(autor, ordem);

            //Assert
            Assert.Equal(2, result.Count);
            Assert.Equal("Livro 2", result[0].Name);
            Assert.Equal("Livro 1", result[1].Name);
        }

        [Fact]
        public void CalcularValorFrete_DeveCalcularFreteCorretamente()
        {
            // Arrange
            decimal preco = 100m;
            decimal freteEsperado = 20m;

            // Act
            decimal freteCalculado = _catalogoDeLivrosService.CalcularValorFrete(preco);

            // Assert
            Assert.Equal(freteEsperado, freteCalculado);
        }
    }
}
