﻿using Lanches_Online.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanches_Online.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheController (ILancheRepository lancheRepository) 
        {
            _lancheRepository = lancheRepository;
        }
        public IActionResult List()
        {
            ViewData["Titulo"] = "Todos os Lanches";
            ViewData["Data"] = DateTime.Now;

            
            var lanches = _lancheRepository.Lanches;
            var totalLanches = lanches.Count();

            ViewBag.Total = "Total de Lanches";
            ViewBag.TotalLanches = totalLanches;
            return View(lanches);
        }
    }
}
