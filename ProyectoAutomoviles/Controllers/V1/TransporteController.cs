using ProyectoAutomoviles.Services.Features.Transportes;
using ProyectoAutomoviles.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAutomoviles.Controllers.V1{
        [ApiController]
    [Route("api/[controller]")]
    public class TransporteController : ControllerBase
    {
        private readonly TransporteService _transporteService;

        public TransporteController(TransporteService transporteService)
        {
            this._transporteService = transporteService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_transporteService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var transporte = _transporteService.GetById(id);
            if (transporte == null)
                return NotFound();

            return Ok(transporte);
        }

        [HttpPost]
        public IActionResult Add(Transporte transporte)
        {
            _transporteService.Add(transporte);
            return CreatedAtAction(nameof(GetById), new { id = transporte.Id }, transporte);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Transporte transporte)
        {
            if (id != transporte.Id)
                return BadRequest();

            _transporteService.Update(transporte);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _transporteService.Delete(id);
            return NoContent();
        }
    }
}