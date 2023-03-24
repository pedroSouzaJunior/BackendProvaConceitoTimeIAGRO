using CatalogoDeLivros.Application.ViewModels;

namespace CatalogoDeLivros.Application.Services.Interfaces
{
    public interface ICatalogoDeLivros
    {
        List<LivroViewModel> Listar();
    }
}
