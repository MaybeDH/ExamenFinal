using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class pilotosController : ControllerBase
    {
        private readonly ILogger<pilotosController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public pilotosController(
            ILogger<pilotosController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] pilotos piloto)
        {
            _aplicacionContexto.Pilotos.Add(piloto);
            _aplicacionContexto.SaveChanges();
            return Ok(piloto);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<pilotos> Get()
        {
            return _aplicacionContexto.Pilotos.ToList();
        }
        //Update: Modificar estudiantes
        [Route("r/id")]
        [HttpPut]
        public IActionResult Put([FromBody] pilotos piloto)
        {
            _aplicacionContexto.Pilotos.Update(piloto);
            _aplicacionContexto.SaveChanges();
            return Ok(piloto);
        }
        //Delete: Eliminar estudiantes
        [Route("r/id")]
        [HttpDelete]
        public IActionResult Delete(int id_piloto)
        {
            _aplicacionContexto.Pilotos.Remove(
                _aplicacionContexto.Pilotos.ToList()
                .Where(x => x.numero_licencia == id_piloto)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(id_piloto);
        }
    }
}
