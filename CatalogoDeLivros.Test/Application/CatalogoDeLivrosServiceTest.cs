using CatalogoDeLivros.Application.Services.Implementations;
using CatalogoDeLivros.Application.ViewModels;

namespace CatalogoDeLivros.Test.Application
{
    public class CatalogoDeLivrosServiceTest
    {
        private readonly CatalogoDeLivrosService _catalogoDeLivrosService;

        public CatalogoDeLivrosServiceTest()
        {
            _catalogoDeLivrosService = new CatalogoDeLivrosService();
        }

        [Fact]
        public void DeveListarTodosOsLivrosDoCatalogo_ERetornarTodosOsLivros()
        {
            List<LivroViewModel> livrosDoCatologo = ConfigurarRetornoEsperado();

            var catalogo = _catalogoDeLivrosService.Listar();

            Assert.True(livrosDoCatologo.Any());
            Assert.True(livrosDoCatologo.Count() == 5);
        }

        private List<LivroViewModel> ConfigurarRetornoEsperado()
        {
            return new List<LivroViewModel>();
        }
    }
}
