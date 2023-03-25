using CatalogoDeLivros.Application.ViewModels;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace CatalogoDeLivros.Application.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public LivroRepository()
        {

        }

        public List<LivroViewModel> Listar()
        {
            string jsonFilePath = Path.Combine(AppContext.BaseDirectory, "wwwroot", "books.json");
            string jsonString = File.ReadAllText(jsonFilePath);
            Trace.WriteLine(jsonString);

            List<LivroViewModel> books = JsonConvert.DeserializeObject<List<LivroViewModel>>(jsonString);

            return books;
        }
    }
}
