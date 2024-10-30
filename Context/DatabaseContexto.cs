using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UiHelpapi.Models;

namespace UiHelpapi.Context
{
    public class DatabaseContexto : DbContext 
    {
    public DatabaseContexto(DbContextOptions<DatabaseContexto> options) : base(options)
    {
    }


        public DbSet<Adm> Adm { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<PontosDeColeta> PontosDeColeta { get; set; }

        public DbSet<HorarioDeFuncionamento> HorarioDeFuncionamento { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HorarioDeFuncionamento>()
                .HasOne(h => h.PontosDeColeta)
                .WithMany(p => p.HorariosDeFuncionamento)
                .HasForeignKey(h => h.PontosDeColetaId);
        }

    }
}