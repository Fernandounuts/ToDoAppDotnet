using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using toDoDaniel.data;

namespace toDoDaniel.Controllers;

[Route("[controller]")]
public class TarefasController : Controller
{
    private readonly AppCont _appCont;

    public TarefasController(AppCont appCont)
    {
        _appCont = appCont;
    }

    public IActionResult Index()
    {
        return View(_appCont.Tarefas.ToList());
    }
}
