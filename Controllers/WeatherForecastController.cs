using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CryptoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CoinsController : ControllerBase
{
    private readonly ILogger<CoinsController> _logger;
    private Contexto _contexto;

    public CoinsController(ILogger<CoinsController> logger, Contexto contexto)
    {
        _logger = logger;
        _contexto = contexto;
    }

    [HttpGet(Name = "GetCoins")]
    public IEnumerable<Coins> Get()
    {
        return _contexto.Coins.AsNoTracking().ToList();
    }

    [HttpPost]
    public async Task<ActionResult<Coins>> PostCoin(Coins coin)
    {
        _contexto.Coins.Add(coin);

        await _contexto.SaveChangesAsync();

        return CreatedAtAction(nameof(PostCoin), coin);
    }
}
