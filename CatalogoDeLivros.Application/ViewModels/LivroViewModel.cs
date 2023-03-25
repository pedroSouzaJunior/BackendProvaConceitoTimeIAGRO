using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace CatalogoDeLivros.Application.ViewModels
{
    public class LivroViewModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public decimal? Price { get; set; }

        [JsonProperty("specifications")]
        public SpecificationsViewModel Specifications { get; set; }
    }
}
