using CatalogoDeLivros.Application.Services.Implementations;
using CatalogoDeLivros.Application.ViewModels;

namespace CatalogoDeLivros.Test.Application
{
    public class CatalogoDeLivrosServiceTest
    {
        private readonly CatalogoDeLivrosService _catalogoDeLivrosService;

        public CatalogoDeLivrosServiceTest()
        {
            //_catalogoDeLivrosService = new CatalogoDeLivrosService();
        }

        [Fact]
        public void DeveListarLivros_ERetornarAoMenosUmLivro()
        {
            List<LivroViewModel> livrosDoCatologo = ConfigurarRetornoEsperado();

            var catalogo = _catalogoDeLivrosService.Listar();

            Assert.True(catalogo.Any());
        }

        [Fact]
        public void DeveListarLivros_ERetornarCincoLivros()
        {
            List<LivroViewModel> livrosDoCatologo = ConfigurarRetornoEsperado();

            var catalogo = _catalogoDeLivrosService.Listar();

            Assert.True(catalogo.Count() == 5);

        }

        [Fact]
        public void DeveListarLivros_ERetornarUmLivroEmEspecifico()
        {
            List<LivroViewModel> livrosDoCatologo = ConfigurarRetornoEsperado();

            var catalogo = _catalogoDeLivrosService.Listar();

            //Assert.True(catalogo.Any(l => l.Name.Equals("Journey to the Center of the Earth")));
            //Assert.True(catalogo.Any(l => l.Price == 10.00));
            //Assert.True(catalogo.Any(l => l.Specifications.Genres.Any(g => g.Equals("Science Fictio"))));

        }

        private List<LivroViewModel> ConfigurarRetornoEsperado()
        {
            return new List<LivroViewModel>
            {
                new LivroViewModel()
            };
        }
    }
}
