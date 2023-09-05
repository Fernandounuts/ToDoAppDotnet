using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using toDoDaniel.Models;

namespace toDoDaniel.data;

public class AppDBInitializer
{
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<AppCont>();
            context.Database.EnsureCreated();

            // Criar tarefas
            if (!context.Tarefas.Any())
            {
                context.Tarefas.AddRange(
                    new List<Tarefa>()
                    {
                        new Tarefa()
                        {
                            Name = "Trabalhar com DotNet",
                            EndTime = DateTime.Now.AddDays(7),
                            Status = false
                        },
                        new Tarefa()
                        {
                            Name = "Criar banco de dados",
                            EndTime = DateTime.Now.AddDays(7),
                            Status = false
                        },
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
