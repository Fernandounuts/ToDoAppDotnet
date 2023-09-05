using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace toDoDaniel.Models;

public class Tarefa
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public DateTime EndTime { get; set; }
    public bool Status { get; set; }
}
