using CatalogoDeLivros.Application.ViewModels;

namespace CatalogoDeLivros.Application.Services.Interfaces
{
    public interface ICatalogoDeLivros
    {
        List<LivroViewModel> Listar();
        List<LivroViewModel> BuscarPorNome(string nome);
        List<LivroViewModel> BuscarPorPreco(decimal preco);
        List<LivroViewModel> BuscarPorDataDePublicacao(string dataDePublicacao);
        List<LivroViewModel> BuscarPorAutor(string autor);
        List<LivroViewModel> BuscarPorIlustrador(string ilustrador);
        List<LivroViewModel> BuscarPorGenero(string genero);
    }
}
