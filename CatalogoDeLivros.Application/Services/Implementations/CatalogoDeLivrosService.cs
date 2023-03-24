using CatalogoDeLivros.Application.Services.Interfaces;
using CatalogoDeLivros.Application.ViewModels;

namespace CatalogoDeLivros.Application.Services.Implementations
{
    public class CatalogoDeLivrosService : ICatalogoDeLivros
    {
        public CatalogoDeLivrosService()
        {
        }

        public List<LivroViewModel> Listar()
        {
            //obter os livros do json
            //retornar para o usuário
            return new List<LivroViewModel>();
        }
    }
}
