using CatalogoDeLivros.Application.Services.Interfaces;
using CatalogoDeLivros.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoDeLivros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogoDeLivrosController : ControllerBase
    {
        private readonly ILogger<CatalogoDeLivrosController> _logger;
        private readonly ICatalogoDeLivros _catalogoDeLivros;

        public CatalogoDeLivrosController(
            ILogger<CatalogoDeLivrosController> logger,
            ICatalogoDeLivros catalogoDeLivros)
        {
            _logger = logger;
            _catalogoDeLivros = catalogoDeLivros;
        }

        [HttpGet("livros")]
        public async Task<ActionResult<List<LivroViewModel>>> GetLivros()
        {
            var livros = _catalogoDeLivros.Listar();
            return Ok(livros);
        }

        [HttpGet("nome")]
        public IActionResult GetLivros(
            [FromQuery] string nome)
        {
            var livrosFiltrados = _catalogoDeLivros.BuscarPorNome(nome);

            return Ok(livrosFiltrados);
        }

        [HttpGet("preco")]
        public IActionResult BuscarLivrosPorPreco([FromQuery] decimal preco)
        {
            var livros = _catalogoDeLivros.BuscarPorPreco(preco);
            return Ok(livros);
        }

        [HttpGet("data-de-publicacao")]
        public IActionResult BuscarLivrosPorDataDePublicacao([FromQuery] string dataDePublicacao)
        {
            var livros = _catalogoDeLivros.BuscarPorDataDePublicacao(dataDePublicacao);
            return Ok(livros);
        }

        [HttpGet("autor")]
        public IActionResult BuscarLivrosPorAutor([FromQuery] string autor)
        {
            var livros = _catalogoDeLivros.BuscarPorAutor(autor);
            return Ok(livros);
        }

        [HttpGet("ilustrador")]
        public IActionResult BuscarLivrosPorIlustrador([FromQuery] string ilustrador)
        {
            var livros = _catalogoDeLivros.BuscarPorIlustrador(ilustrador);
            return Ok(livros);
        }

        [HttpGet("genero")]
        public IActionResult BuscarLivrosPorGenero([FromQuery] string genero)
        {
            var livros = _catalogoDeLivros.BuscarPorGenero(genero);
            return Ok(livros);
        }
    }
}