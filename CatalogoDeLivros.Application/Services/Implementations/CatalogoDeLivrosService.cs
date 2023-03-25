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

        public List<LivroViewModel> BuscarPorIlustrador(string ilustrador, string ordem)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(ilustrador) || l.Specifications.Illustrator.Contains(ilustrador)));

            return Ordenar(livrosFiltrados.ToList(), ordem);
        }

        public List<LivroViewModel> BuscarPorAutor(string autor, string ordem)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(autor) || l.Specifications.Author.Contains(autor)));

            return Ordenar(livrosFiltrados.ToList(), ordem);
        }

        public List<LivroViewModel> BuscarPorDataDePublicacao(string dataDePublicacao, string ordem)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(dataDePublicacao) || l.Specifications.OriginallyPublished.Contains(dataDePublicacao)));

            return Ordenar(livrosFiltrados.ToList(), ordem);
        }

        public List<LivroViewModel> BuscarPorGenero(string genero, string ordem)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(genero) || l.Specifications.Genres.Contains(genero)));

            return Ordenar(livrosFiltrados.ToList(), ordem);
        }

        public List<LivroViewModel> BuscarPorNome(string nome, string ordem)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (string.IsNullOrEmpty(nome) || l.Name.Contains(nome)));

            return Ordenar(livrosFiltrados.ToList(), ordem);
        }

        public List<LivroViewModel> BuscarPorPreco(decimal preco, string ordem)
        {
            var livros = _livroRepository.Listar();

            var livrosFiltrados = livros.Where(l => (preco == 0 || l.Price == preco));

            return Ordenar(livrosFiltrados.ToList(), ordem);
        }

        public decimal CalcularValorFrete(decimal preco)
        {
            decimal valorFrete = preco * 0.2m;
            return valorFrete;
        }

        public List<LivroViewModel> Listar(string ordem)
        {
            var livros = _livroRepository.Listar();
            return Ordenar(livros, ordem);
        }

        private List<LivroViewModel> Ordenar(List<LivroViewModel> livros, string ordem)
        {
            if (ordem.ToLower().Equals("asc"))
            {
                livros = livros.OrderBy(l => l.Price).ToList();
            }
            else
            {
                livros = livros.OrderByDescending(l => l.Price).ToList();
            }

            return livros;
        }
    }
}
