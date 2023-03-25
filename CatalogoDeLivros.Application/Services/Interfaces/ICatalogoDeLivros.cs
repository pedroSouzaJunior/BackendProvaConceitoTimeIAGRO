using CatalogoDeLivros.Application.ViewModels;

namespace CatalogoDeLivros.Application.Services.Interfaces
{
    public interface ICatalogoDeLivros
    {
        List<LivroViewModel> Listar(string ordem);
        List<LivroViewModel> BuscarPorNome(string nome, string ordem);
        List<LivroViewModel> BuscarPorPreco(decimal preco, string ordem);
        List<LivroViewModel> BuscarPorDataDePublicacao(string dataDePublicacao, string ordem);
        List<LivroViewModel> BuscarPorAutor(string autor, string ordem);
        List<LivroViewModel> BuscarPorIlustrador(string ilustrador, string ordem);
        List<LivroViewModel> BuscarPorGenero(string genero, string ordem);
        decimal CalcularValorFrete(decimal preco);
    }
}
