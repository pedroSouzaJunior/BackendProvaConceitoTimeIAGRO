using CatalogoDeLivros.Application.ViewModels;

namespace CatalogoDeLivros.Application.Repositories
{
    public interface ILivroRepository
    {
        List<LivroViewModel> Listar();
    }
}
