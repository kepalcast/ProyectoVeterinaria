using API.Data;
using API.Models.Dto;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        private readonly ILogger<ClienteController> _logger;
        private readonly IMapper _mapper;

        public ClienteController(ILogger<ClienteController> logger, IClientRepository clientRepository, IMapper mapper)
        {
            _logger = logger;
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetStudents()
        {
            _logger.LogInformation("Obtener los Clientes");
            var clientList = await _clientRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<ClienteDto>>(clientList));
        }

        [HttpGet("{id:int}", Name = "GetClient")]
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
            var cliente = await _clientRepository.Get(s => s.idCliente == id);

            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ClienteDto>(cliente));
        }



    }
}
