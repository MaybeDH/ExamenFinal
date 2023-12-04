using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class hangaresController : ControllerBase
    {
        private readonly ILogger<hangaresController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public hangaresController(
            ILogger<hangaresController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Hangares hangar)
        {
            _aplicacionContexto.Hangares.Add(hangar);
            _aplicacionContexto.SaveChanges();
            return Ok(hangar);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<hangares> Get()
        {
            return _aplicacionContexto.Hangares.ToList();
        }
        //Update: Modificar estudiantes
        [Route("y/id")]
        [HttpPut]
        public IActionResult Put([FromBody] hangares hangar)
        {
            _aplicacionContexto.Hangares.Update(hangar);
            _aplicacionContexto.SaveChanges();
            return Ok(hangar);
        }
        //Delete: Eliminar estudiantes
        [Route("y/id")]
        [HttpDelete]
        public IActionResult Delete(int num_hangar)
        {
            _aplicacionContexto.Hangares.Remove(
                _aplicacionContexto.Hangares.ToList()
                .Where(x => x.id_hangar == num_hangar)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(num_hangar);
        }
    }
}
