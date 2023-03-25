namespace CatalogoDeLivros.Core.Entities
{
    public class Livro
    {
        public Livro()
        {

        }
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public Specification Specifications { get; }
    }
}