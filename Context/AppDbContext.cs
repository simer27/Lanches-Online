﻿using Lanches_Online.Models;
using Microsoft.EntityFrameworkCore;

namespace Lanches_Online.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Lanche>? Lanches { get; set; }
    }
}
