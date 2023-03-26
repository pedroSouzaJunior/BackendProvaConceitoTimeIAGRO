using CatalogoDeLivros.Application.Utils;
using Newtonsoft.Json;

namespace CatalogoDeLivros.Application.ViewModels
{
    public class SpecificationsViewModel
    {
        [JsonProperty("Originally published")]
        public string OriginallyPublished { get; set; }

        [JsonProperty("Author")]
        public string Author { get; set; }

        [JsonProperty("Page count")]
        public int? PageCount { get; set; }

        [JsonProperty("Illustrator")]
        [JsonConverter(typeof(ConversorIllustrator))]
        public List<string> Illustrator { get; set; }

        [JsonProperty("Genres")]
        [JsonConverter(typeof(ConversorIllustrator))]
        public List<string> Genres { get; set; }
    }
}
