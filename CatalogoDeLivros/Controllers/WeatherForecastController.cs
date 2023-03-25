using CatalogoDeLivros.Application.Services.Interfaces;
using CatalogoDeLivros.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoDeLivros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ICatalogoDeLivros _catalogoDeLivros;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            ICatalogoDeLivros catalogoDeLivros)
        {
            _logger = logger;
            _catalogoDeLivros = catalogoDeLivros;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public List<LivroViewModel> Get()
        {
            return _catalogoDeLivros.Listar();
        }
    }
}