using CatalogoDeLivros.Application.Repositories;
using CatalogoDeLivros.Application.Services.Interfaces;
using CatalogoDeLivros.Application.ViewModels;


namespace CatalogoDeLivros.Application.Services.Implementations
{
    public class CatalogoDeLivrosService : ICatalogoDeLivros
    {
        private readonly ILivroRepository _livroRepository;

        public CatalogoDeLivrosService(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public List<LivroViewModel> Listar()
        {
            return _livroRepository.Listar();
        }
    }
}
