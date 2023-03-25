using CatalogoDeLivros.Application.ViewModels;
using System.Linq.Expressions;

namespace CatalogoDeLivros.Application.Specifications
{
    public class LivroSpecification : ILivroSpecification
    {
        public Expression<Func<LivroViewModel, bool>> PorNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return livro => true;
            }

            return livro => livro.Name.Contains(nome);
        }

        public Expression<Func<LivroViewModel, bool>> PorAutor(string autor)
        {
            if (string.IsNullOrEmpty(autor))
            {
                return livro => true;
            }

            return livro => livro.Specifications.Author.Contains(autor);
        }

        public Expression<Func<LivroViewModel, bool>> PorPreco(decimal preco)
        {
            if (preco == 0)
            {
                return livro => true;
            }

            return livro => livro.Price == preco;
        }

        public Expression<Func<LivroViewModel, bool>> PorQuantidadeDePaginas(int numeroDaPagina)
        {
            if (numeroDaPagina == 0)
            {
                return livro => true;
            }

            return livro => livro.Specifications.PageCount == numeroDaPagina;
        }

        public Expression<Func<LivroViewModel, bool>> PorDataDePublicacao(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                return livro => true;
            }

            return livro => livro.Specifications.OriginallyPublished == data;
        }

        public Expression<Func<LivroViewModel, bool>> PorIlustrador(string ilustrador)
        {
            if (string.IsNullOrEmpty(ilustrador))
            {
                return livro => true;
            }

            return livro => livro.Specifications.Illustrator.Contains(ilustrador);
        }

        public Expression<Func<LivroViewModel, bool>> PorGenero(string genero)
        {
            if (string.IsNullOrEmpty(genero))
            {
                return livro => true;
            }

            return livro => livro.Specifications.Genres.Contains(genero);
        }

        public Expression<Func<T, bool>> And<T>(Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            var invokedExpression = Expression.Invoke(right, left.Parameters);
            return Expression.Lambda<Func<T, bool>>(Expression.AndAlso(left.Body, invokedExpression), left.Parameters);
        }
    }
}
