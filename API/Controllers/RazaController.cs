using API.Models;
using API.Models.Dto;
using API.Repository;
using API.Repository.IRepository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RazaController : ControllerBase
    {
        public class GradeController : ControllerBase
        {
            private readonly ILogger<GradeController> _logger;
            private readonly IRazaRepositiry _razaRepository;
            private readonly IMapper _mapper;

            public GradeController(ILogger<GradeController> logger, IRazaRepositiry razaRepository, IMapper mapper)
            {
                _logger = logger;
                _razaRepository = razaRepository;
                _mapper = mapper;
            }
            [HttpGet]
            [ProducesResponseType(StatusCodes.Status200OK)]

            public async Task<ActionResult<IEnumerable<RazaDto>>> GetRaza()
            {
                _logger.LogInformation("Obtener las razas");
                var RazaList = await _razaRepository.GetAll();

                return Ok(_mapper.Map<IEnumerable<RazaDto>>(RazaList));

            }
            [HttpGet("{id:int}", Name = "GetRazas")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]

            public async Task<ActionResult<RazaDto>> GetRaza(int id)
            {
                if (id == 0)
                {
                    _logger.LogError($"Error al traer a la raza con Id {id}");
                    return BadRequest();
                }
                var raza = await _razaRepository.Get(s => s.Id == id);

                if (raza == null)
                {
                    return NotFound();
                }

                return Ok(_mapper.Map<RazaDto>(raza));

            }
            [HttpPost]
            [ProducesResponseType(StatusCodes.Status201Created)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<ActionResult<ClienteDto>> AddRaza([FromBody] RazaCreateDto razaCreateDto)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (await _razaRepository.Get(s => s.RazaName.ToLower() == razaCreateDto.RazaName.ToLower()) != null)
                {
                    ModelState.AddModelError("NombreExiste", "¡El cliente con ese Nombre ya existe!");
                    return BadRequest(ModelState);
                }

                if (razaCreateDto == null)
                {
                    return BadRequest(razaCreateDto);
                }

                Raza modelo = _mapper.Map<Raza>(razaCreateDto);

                await _razaRepository.Add(modelo);

                return CreatedAtRoute("GetRaza", new { id = modelo.Id }, modelo);
            }

            [HttpDelete("{id:int}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [ProducesResponseType(StatusCodes.Status403Forbidden)]
            public async Task<IActionResult> DeleteClient(int id)
            {
                if (id == 0)
                {
                    return BadRequest();
                }
                var client = await _razaRepository.Get(s => s.Id == id);

                if (client == null)
                {
                    return NotFound();
                }

                _razaRepository.Remove(client);

                return NoContent();
            }

            [HttpPut("{id:int}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<IActionResult> UpdateRaza(int id, [FromBody] RazaUpdateDto razaUpdateDto)
            {
                if (razaUpdateDto == null || id != razaUpdateDto.Id)
                {
                    return BadRequest();
                }

                Raza modelo = _mapper.Map<Raza>(razaUpdateDto);
                _razaRepository.Update(modelo);
                return NoContent();
            }

            [HttpPatch("{id:int}")]
            [ProducesResponseType(StatusCodes.Status204NoContent)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public async Task<IActionResult> UpdatePartialClient(int id, JsonPatchDocument<RazaUpdateDto> patchDto)
            {
                if (patchDto == null || id == 0)
                {
                    return BadRequest();
                }

                var client = await _razaRepository.Get(s => s.Id == id, tracked: false);

                RazaUpdateDto razaUpdateDto = _mapper.Map<RazaUpdateDto>(client);

                if (client == null) return BadRequest();

                patchDto.ApplyTo(razaUpdateDto, (Microsoft.AspNetCore.JsonPatch.Adapters.IObjectAdapter)ModelState);

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Raza modelo = _mapper.Map<Raza>(razaUpdateDto);

                _razaRepository.Update(modelo);

                return NoContent();

            }

        }
    }

}
    

