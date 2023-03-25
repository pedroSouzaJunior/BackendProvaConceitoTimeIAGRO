using System.Linq.Expressions;

namespace CatalogoDeLivros.Application.Utils
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> left, Expression<Func<T, bool>> right)
        {
            var parameter = left.Parameters.Single();
            var leftVisitor = new ReplaceExpressionVisitor(parameter, right.Parameters.Single());
            var leftBody = leftVisitor.Visit(left.Body);
            var rightBody = right.Body;
            var body = Expression.AndAlso(leftBody, rightBody);
            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }
    }

    public class ReplaceExpressionVisitor : ExpressionVisitor
    {
        private readonly Expression from, to;

        public ReplaceExpressionVisitor(Expression from, Expression to)
        {
            this.from = from;
            this.to = to;
        }

        public override Expression Visit(Expression node)
        {
            return node == from ? to : base.Visit(node);
        }
    }
}
