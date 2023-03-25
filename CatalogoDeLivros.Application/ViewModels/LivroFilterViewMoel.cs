using Microsoft.AspNetCore.Mvc;

namespace CatalogoDeLivros.Application.ViewModels
{
    public class LivroFilterViewModel
    {
        public string Nome { get; set; } = null;
        public string Autor { get; set; } = null;
        public decimal Preco { get; set; } = 0;
        public int NumeroDaPagina { get; set; } = 0;
        public string Data { get; set; } = null;
        public string Ilustrador { get; set; } = null;
        public string Genero { get; set; } = null;
    }
}
