using Grafico.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Grafico.Interface;
using Grafico.Services;
using System;

namespace AcompanhamentoDocente.Controllers
{
    public class HomeController : Controller
    {


        private readonly IHome _acesso;

        public HomeController()
        {

            _acesso = new HomeService();
        }

        
        public async Task<IActionResult> Index()
        {
            var rel = await _acesso.RelatorioGeral();
            
            return View(rel);
            
        }

       

    }
}