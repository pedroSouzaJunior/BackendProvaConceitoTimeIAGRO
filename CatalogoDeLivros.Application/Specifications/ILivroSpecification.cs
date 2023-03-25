using CatalogoDeLivros.Application.ViewModels;
using System.Linq.Expressions;

namespace CatalogoDeLivros.Application.Specifications
{
    public interface ILivroSpecification
    {
        Expression<Func<LivroViewModel, bool>> PorNome(string nome);
        Expression<Func<LivroViewModel, bool>> PorAutor(string autor);
        Expression<Func<LivroViewModel, bool>> PorPreco(decimal preco);
        Expression<Func<LivroViewModel, bool>> PorQuantidadeDePaginas(int numeroDaPagina);
        Expression<Func<LivroViewModel, bool>> PorDataDePublicacao(string data);
        Expression<Func<LivroViewModel, bool>> PorIlustrador(string ilustrador);
        Expression<Func<LivroViewModel, bool>> PorGenero(string genero);
        Expression<Func<T, bool>> And<T>(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right);
    }

}
