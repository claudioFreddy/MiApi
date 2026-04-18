using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiApi.Models
{
public class Tarea
{ 
    public int Id { get; set; }
    public string? Title { get; set; }
}}