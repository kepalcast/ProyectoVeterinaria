using API.Data;
using API.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteContext _db;
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger, ClienteContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetStudents()
        {
            _logger.LogInformation("Obtener los Estudiantes");
            return Ok(await _db.clientes.ToListAsync());
        }

        [HttpGet("{id:int}", Name = "GetStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClienteDto>> GetStudent(int id)
        {
            if (id == 0)
            {
                _logger.LogError($"Error al traer al cliente con Id {id}");
                return BadRequest();
            }
            var student = await _db.clientes.FirstOrDefaultAsync(s => s.idCliente == id);

            if (student == null)
            {
                return NotFound();
            }

            return Ok(student);
        }



    }
}
