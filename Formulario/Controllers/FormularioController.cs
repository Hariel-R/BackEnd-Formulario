using Formulario.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Formulario.Models;

namespace Formulario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormularioController : Controller
    {

        private readonly AppDbContext _context;

        public FormularioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<FormularioEntity>> PostCliente(FormularioEntity formulario)
        {
            if (formulario == null)
            {
                return BadRequest("Dados inválidos.");
            }

            _context.Formulario.Add(formulario);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFormulario), new { id = formulario.Id }, formulario);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FormularioEntity>>> GetFormulario()
        {
            return await _context.Formulario.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FormularioEntity>> GetFormulario(int id)
        {
            var formulario = await _context.Formulario.FindAsync(id);

            if (formulario == null)
            {
                return NotFound();
            }

            return formulario;
        }

        [HttpGet("UltimoId")]
        public async Task<ActionResult<FormularioEntity>> GetUltimoId()
        {
            var ultimoId = await _context.Formulario
                             .OrderByDescending(x => x.Id)
                             .Select(x => x.Id)
                             .FirstOrDefaultAsync();
            var formulario = await _context.Formulario.FindAsync(ultimoId);

            if (formulario == null)
            {
                return NotFound();
            }

            return formulario;
        }

    }
}   

