using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanoDeContas.Models;

namespace PlanoDeContas.Controllers
{
    public class HomeController : Controller
    {
        public static List<Conta> listaConta = new List<Conta>();
        public IActionResult Index()
        {
            ViewBag.Conta = listaConta.ToList();     
            return View();
        }

        public IActionResult Gravar(Conta conta)
        {
            listaConta.Add(conta);
            ViewBag.Conta = listaConta.ToList();
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
