using Microsoft.AspNetCore.Mvc;

namespace MiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TareasController : ControllerBase
    {
        private static List<string> tareas = new List<string>
        {
            "Estudiar",
            "Programar",
            "Hacer ejercicio"
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(tareas);
        }

        [HttpPost]
        public IActionResult Post([FromBody] string nuevaTarea)
        {
        tareas.Add(nuevaTarea);
        return Ok(tareas);
        }
    }
}