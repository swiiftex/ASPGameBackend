using GameApi.Data;
using GameApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly GameDbContext _context;
        public PlayerController(GameDbContext gameDbContext)
        {
            _context = gameDbContext;
        }

        [HttpPost]

        public async Task<IActionResult> Find(string PlayerID)
        {
            var thisPlayer = await _context.Players.FindAsync(PlayerID);

            if (thisPlayer == null) { return  NotFound(); }

            return Ok(thisPlayer);
        }

    }
}
