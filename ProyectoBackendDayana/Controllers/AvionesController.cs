using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllersssss
{
    [ApiController]
    [Route("[controller]")]
    public class AvionesController : ControllerBase
    {
        private readonly ILogger<AvionesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public AvionesController(
            ILogger<AvionesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Aviones avion)
        {
            _aplicacionContexto.Aviones.Add(avion);
            _aplicacionContexto.SaveChanges();
            return Ok(avion);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<aviones> Get()
        {
            return _aplicacionContexto.Aviones.ToList();
        }
        //Update: Modificar estudiantes
        [Route("p/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Aviones avion)
        {
            _aplicacionContexto.Aviones.Update(avion);
            _aplicacionContexto.SaveChanges();
            return Ok(avion);
        }
        //Delete: Eliminar estudiantes
        [Route("p/id")]
        [HttpDelete]
        public IActionResult Delete(int id_avion)
        {
            _aplicacionContexto.Aviones.Remove(
                _aplicacionContexto.Aviones.ToList()
                .Where(x => x.id_avion == id_avion)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(id_avion);
        }
    }
}

