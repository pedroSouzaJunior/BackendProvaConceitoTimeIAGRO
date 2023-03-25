using CatalogoDeLivros.Application.ViewModels;

namespace CatalogoDeLivros.Infrastructure.Repositories
{
    public interface ILivroRepository
    {
        List<LivroViewModel> Listar();
    }
}
