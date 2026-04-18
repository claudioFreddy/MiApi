using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiApi.Data;
using MiApi.Models;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class TareasController : ControllerBase
{
    private readonly AppDbContext _context;

    public TareasController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var tareas = await _context.Tareas.ToListAsync();
        return Ok(tareas);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Tarea tarea)
    {
        _context.Tareas.Add(tarea);
        await _context.SaveChangesAsync();
        return Ok(new {
        tarea.Id,
        tarea.Title});
    }

    [HttpGet("debug")]
        public IActionResult Debug()
    {
        return Ok(_context.Database.GetDbConnection().ConnectionString);
    }
}