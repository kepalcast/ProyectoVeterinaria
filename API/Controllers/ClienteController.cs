using System.Data;
using API.Data;
using API.Models;
using API.Models.Dto;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
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
        public async Task<ActionResult<IEnumerable<ClienteDto>>> GetClient()
        {
            _logger.LogInformation("Obtener los Clientes");
            var clientList = await _clientRepository.GetAll();
            return Ok(_mapper.Map<IEnumerable<ClienteDto>>(clientList));
        }

        [HttpGet("{id:int}", Name = "GetClient")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClienteDto>> GetClient(int id)
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
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ClienteDto>> AddClient([FromBody] ClienteCreateDto clientCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await _clientRepository.Get(s => s.Name.ToLower() == clientCreateDto.Name.ToLower()) != null)
            {
                ModelState.AddModelError("NombreExiste", "¡El cliente con ese Nombre ya existe!");
                return BadRequest(ModelState);
            }

            if (clientCreateDto == null)
            {
                return BadRequest(clientCreateDto);
            }

            Cliente modelo = _mapper.Map<Cliente>(clientCreateDto);

            await _clientRepository.Add(modelo);

            return CreatedAtRoute("GetCliente", new { id = modelo.idCliente }, modelo);
        }

        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> DeleteStudent(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var client = await _clientRepository.Get(s => s.idCliente == id);

            if (client == null)
            {
                return NotFound();
            }

            _clientRepository.Remove(client);

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdateCllient(int id, [FromBody] ClienteUpdateDto clientUpdateDto)
        {
            if (clientUpdateDto == null || id != clientUpdateDto.idCliente)
            {
                return BadRequest();
            }

            Cliente modelo = _mapper.Map<Cliente>(clientUpdateDto);
            _clientRepository.Update(modelo);
            return NoContent();
        }

        [HttpPatch("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpdatePartialClient(int id, JsonPatchDocument<ClienteUpdateDto> patchDto)
        {
            if (patchDto == null || id == 0)
            {
                return BadRequest();
            }

            var client = await _clientRepository.Get(s => s.idCliente == id, tracked: false);

            ClienteUpdateDto clientUpdateDto =  _mapper.Map<ClienteUpdateDto>(client);

            if (client == null) return BadRequest();

            patchDto.ApplyTo(clientUpdateDto, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

                if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Cliente modelo = _mapper.Map<Cliente>(clientUpdateDto);
           
            _clientRepository.Update(modelo);

            return NoContent();

        }
    }
}
