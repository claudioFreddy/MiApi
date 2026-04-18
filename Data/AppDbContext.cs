using Microsoft.EntityFrameworkCore;
using MiApi.Models;

namespace MiApi.Data
{
 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Tarea> Tareas { get; set; }
           protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tarea>()
            .Property(t => t.Id)
            .ValueGeneratedOnAdd();
        }
    }   
}