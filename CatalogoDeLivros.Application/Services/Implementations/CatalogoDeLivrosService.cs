using CatalogoDeLivros.Application.Repositories;
using CatalogoDeLivros.Application.Services.Interfaces;
using CatalogoDeLivros.Application.ViewModels;


namespace CatalogoDeLivros.Application.Services.Implementations
{
    public class CatalogoDeLivrosService : ICatalogoDeLivros
    {
        private readonly ILivroRepository _livroRepository;

        public CatalogoDeLivrosService(
            ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public List<LivroViewModel> BuscarPorIlustrador(string ilustrador)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(ilustrador) || l.Specifications.Illustrator.Contains(ilustrador)));

            return livrosFiltrados.ToList();
        }

        public List<LivroViewModel> BuscarPorAutor(string autor)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(autor) || l.Specifications.Author.Contains(autor)));

            return livrosFiltrados.ToList();
        }

        public List<LivroViewModel> BuscarPorDataDePublicacao(string dataDePublicacao)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(dataDePublicacao) || l.Specifications.OriginallyPublished.Contains(dataDePublicacao)));

            return livrosFiltrados.ToList();
        }

        public List<LivroViewModel> BuscarPorGenero(string genero)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(genero) || l.Specifications.Genres.Contains(genero)));

            return livrosFiltrados.ToList();
        }

        public List<LivroViewModel> BuscarPorNome(string nome)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(nome) || l.Name.Contains(nome)));

            return livrosFiltrados.ToList();
        }

        public List<LivroViewModel> BuscarPorPreco(decimal preco)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (preco == 0 || l.Price == preco));

            return livrosFiltrados.ToList();
        }

        public List<LivroViewModel> Listar()
        {
            return _livroRepository.Listar();
        }
    }
}
