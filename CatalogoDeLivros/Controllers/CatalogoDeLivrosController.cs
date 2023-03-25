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
        public async Task<ActionResult<List<LivroViewModel>>> GetLivros([FromQuery] string ordem = "asc")
        {
            var livros = _catalogoDeLivros.Listar(ordem);
            return Ok(livros);
        }

        [HttpGet("nome")]
        public IActionResult GetLivros(
            [FromQuery] string nome,
            [FromQuery] string ordem = "asc")
        {
            var livrosFiltrados = _catalogoDeLivros.BuscarPorNome(nome, ordem);

            return Ok(livrosFiltrados);
        }

        [HttpGet("preco")]
        public IActionResult BuscarLivrosPorPreco(
            [FromQuery] decimal preco,
            [FromQuery] string ordem = "asc")
        {
            var livros = _catalogoDeLivros.BuscarPorPreco(preco, ordem);
            return Ok(livros);
        }

        [HttpGet("data-de-publicacao")]
        public IActionResult BuscarLivrosPorDataDePublicacao([
            FromQuery] string dataDePublicacao,
            [FromQuery] string ordem = "asc")
        {
            var livros = _catalogoDeLivros.BuscarPorDataDePublicacao(dataDePublicacao, ordem);
            return Ok(livros);
        }

        [HttpGet("autor")]
        public IActionResult BuscarLivrosPorAutor(
            [FromQuery] string autor,
            [FromQuery] string ordem = "asc")
        {
            var livros = _catalogoDeLivros.BuscarPorAutor(autor, ordem);
            return Ok(livros);
        }

        [HttpGet("ilustrador")]
        public IActionResult BuscarLivrosPorIlustrador(
            [FromQuery] string ilustrador,
            [FromQuery] string ordem = "asc")
        {
            var livros = _catalogoDeLivros.BuscarPorIlustrador(ilustrador, ordem);
            return Ok(livros);
        }

        [HttpGet("genero")]
        public IActionResult BuscarLivrosPorGenero(
            [FromQuery] string genero,
            [FromQuery] string ordem = "asc")
        {
            var livros = _catalogoDeLivros.BuscarPorGenero(genero, ordem);
            return Ok(livros);
        }

        [HttpGet("frete")]
        public IActionResult GetCalcularFrete(
            [FromQuery] string nomeDoLivro,
            [FromQuery] string ordem = "asc")
        {
            var livrosFiltrados = _catalogoDeLivros.BuscarPorNome(nomeDoLivro, ordem);
            var valorFrete = _catalogoDeLivros.CalcularValorFrete(livrosFiltrados.FirstOrDefault()?.Price ?? 0);

            var result = new
            {
                Livros = livrosFiltrados,
                ValorFrete = valorFrete
            };

            return Ok(result);
        }
    }
}