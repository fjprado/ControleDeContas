using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Investimentos.Models;

namespace Investimentos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<Trade> trades = new List<Trade>();
        public static List<Ativo> ativos = new List<Ativo>();
        public static int ativoId = 1;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Trades = trades.ToList();
            ViewBag.Ativos = ativos.ToList();
            ViewBag.AtivoId = ativoId;
            return View();
        }

        public IActionResult CadastrarAtivo(Ativo ativo)
        {
            ativos.Add(ativo);
            ViewBag.Ativos = ativos.ToList();
            ViewBag.Trades = trades.ToList();
            ativoId++;
            ViewBag.AtivoId = ativoId;
            return View("Index");
        }
        public IActionResult ConfirmarOperacao(Trade trade)
        {
            trades.Add(trade);
            ViewBag.Trades = trades.ToList();
            ViewBag.Ativos = ativos.ToList();
            ViewBag.AtivoId = ativoId;
            return View("Index");
        }

    
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
