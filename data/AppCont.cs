using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using toDoDaniel.Models;

namespace toDoDaniel.data;

public class AppCont : DbContext
{
    public AppCont(DbContextOptions<AppCont> options)
        : base(options) { }

    public DbSet<Tarefa> Tarefas { get; set; }
}
