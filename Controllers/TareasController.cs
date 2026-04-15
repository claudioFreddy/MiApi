using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MiApi.Models;
using MiApi.Data;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    private readonly AppDbContext _context;

    //  CONSTRUCTOR (inyecta el contexto)
    public TareasController(AppDbContext context)
    {
        _context = context;
    }
    private static List<Tarea> tareas = new();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(tareas);
    }

    [HttpPost]
    public IActionResult Post([FromBody] Tarea tarea)
    {
        tareas.Add(tarea);
        return Ok(tarea);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var tarea = _context.Tareas.Find(id);

        if (tarea == null)
    {
        return NotFound();
    }

    _context.Tareas.Remove(tarea);
    _context.SaveChanges();

    return NoContent();
}
}