﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt) : base(opt)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<ProdutoNaVenda> ProdutosNaVenda { get; set; }

        public DbSet<Venda> Vendas { get; set; }
    }
}
