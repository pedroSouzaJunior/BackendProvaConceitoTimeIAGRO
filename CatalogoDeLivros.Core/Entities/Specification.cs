namespace CatalogoDeLivros.Core.Entities
{
    public class Specification
    {
        public Specification()
        {

        }
        public string OriginallyPublished { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; } = 0;
        public string Illustrator { get; set; }
        public List<string> Genres { get; set; }
    }
}
