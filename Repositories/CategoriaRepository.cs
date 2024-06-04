using Lanches_Online.Context;
using Lanches_Online.Models;
using Lanches_Online.Repositories.Interfaces;

namespace Lanches_Online.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
