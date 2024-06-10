
using Lanches_Online.Models;
using Lanches_Online.Repositories.Interfaces;
using Lanches_Online.ViewModels;
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
        public IActionResult List(string categoria)
        {

            IEnumerable<Lanche> lanches;
            string categoriaAtual = string.Empty;

            if(string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRepository.Lanches.OrderBy(l => l.LancheId);
                categoriaAtual = "Todos os lanches";
            }
            else
            {

                if (string.Equals("Lanches", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.Nome.Equals("Lanches"))
                        .OrderBy(l => l.Nome);
                }
                else if(string.Equals("Bebidas", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.Nome.Equals("Bebidas"))
                        .OrderBy(l => l.Nome);
                }
                else if (string.Equals("Batatas", categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.Nome.Equals("Batatas"))
                        .OrderBy(l => l.Nome);
                }
                else 
                {
                    lanches = _lancheRepository.Lanches
                        .Where(l => l.Categoria.Nome.Equals("Sobremesas"))
                        .OrderBy(l => l.Nome);
                }
                categoriaAtual = categoria;
            }

            var lanchesListViewModel = new LancheListViewModel
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };

            return View(lanchesListViewModel);
        }
    }
}
