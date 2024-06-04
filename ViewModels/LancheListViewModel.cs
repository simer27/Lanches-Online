using Lanches_Online.Models;

namespace Lanches_Online.ViewModels
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche>? Lanches { get; set; }
        public string? CategoriaAtual {  get; set; }
    }
}
