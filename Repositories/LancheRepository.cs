﻿using Lanches_Online.Context;
using Lanches_Online.Models;
using Lanches_Online.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Lanches_Online.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
            .Where(p => p.IsLanchePreferido)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int id)
        {
           return _context.Lanches.FirstOrDefault(l=> l.LancheId == id);
        }
        
    }
}
