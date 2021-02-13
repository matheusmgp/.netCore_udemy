using MgpTechTickets.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MgpTechTickets.Data
{
    public class DataContext : DbContext
    {
        //public DataContext(DbContextOptions options) : base(options) { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Agenda> Agendas { get; set; }
        public DbSet<Ambiente> Ambientes { get; set; }
        public DbSet<CanaisComunicacao> Canais { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<ChamadoLog> ChamadoLogs { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filial> Filiais { get; set; }
        public DbSet<FilialDados> FilialDados { get; set; }
        public DbSet<FilialEndereco> FilialEnderecos { get; set; }
        public DbSet<Pendencia> Pendencias { get; set; }
        public DbSet<PendenciaImage> PendenciaImages { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Setores> Setores { get; set; }
        public DbSet<SubCategorias> SubCategorias { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Procedimentos> Procedimentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chamado>()
                .HasMany(c => c.Pendencias)
                .WithOne(e => e.Chamado);

            modelBuilder.Entity<Users>()
               .HasMany(c => c.Pendencias)
               .WithOne(e => e.User);

            modelBuilder.Entity<Users>()
               .HasMany(c => c.Chamados)
               .WithOne(e => e.User);
        }


    }
}
