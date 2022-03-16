using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade_3.Models;

namespace Atividade_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Agendamento(Agendamento novoAgendamento)
        {
            InfoAgendamentos.Incluir(novoAgendamento);
            return View();
        }
        public IActionResult Agendamento()
        {
            return View();
        }

        public IActionResult Info()
        {
            List<Agendamento> listaAgendamento = InfoAgendamentos.Listar();
            return View(listaAgendamento);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
