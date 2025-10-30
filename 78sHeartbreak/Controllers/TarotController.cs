using Microsoft.AspNetCore.Mvc;
using _78sHeartbreak.Data;
using _78sHeartbreak.Models;
using Microsoft.EntityFrameworkCore;

namespace _78sHeartbreak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarotController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly HttpClient _httpClient;

        public TarotController(AppDbContext context, HttpClient httpClient)
        {
            _context = context;
            _httpClient = httpClient;
        }

 
        [HttpPost("tirar")]
        public async Task<ActionResult<TarotResultados>> TirarCartas([FromQuery] int quantidade = 3, [FromBody] string momento = "")
        {
            var todasCartas = await _context.TarotCartas.ToListAsync();
            if (!todasCartas.Any())
                return BadRequest("Não há cartas no baralho.");

            var random = new Random();
            var cartasTiradas = todasCartas.OrderBy(x => random.Next()).Take(quantidade).ToList();

            var resposta = await _httpClient.GetAsync("https://api.kanye.rest/");
            var fraseJson = await resposta.Content.ReadFromJsonAsync<KanyeRespostas>();

            var resultado = new TarotResultados
            {
                UsuarioSentimento = momento,
                CartaSorteada = cartasTiradas,
                KanyeFrase = fraseJson?.Frase ?? "Kanye está em silêncio hoje..."
            };

            return Ok(resultado);
        }

    }
}
