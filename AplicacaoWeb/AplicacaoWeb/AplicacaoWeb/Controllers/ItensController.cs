using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AplicacaoWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItensController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ItensController(AppDbContext context)
        {
            _context = context;
        }


        // POST api/<ItensController>
        [HttpPost]
        public async Task<IActionResult> CreateTeste([FromBody] Item item)
        {
            if (item == null) return BadRequest("Invalid data.");

            item.Id = 0; // Ensures EF Core treats it as a new entity

            _context.Itens.Add(item);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Data saved successfully!" });
        }

        // PUT api/<ItensController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ItensController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
