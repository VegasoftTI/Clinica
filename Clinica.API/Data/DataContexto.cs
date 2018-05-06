using Clinica.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Clinica.API.Data
{
   public class DataContexto : DbContext
    {
        public DataContexto(DbContextOptions<DataContexto> options) : base(options)
        {
            
        }        
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Medico>()
                .ToTable("Medicos");

             modelBuilder.Entity<Medico>()
                .HasKey(x => x.ID);

             modelBuilder.Entity<Medico>()
                .Property(x => x.Nome)
                    .HasColumnType("varchar(150)")
                    .IsRequired();

            modelBuilder.Entity<Medico>()
                .Property(x => x.Crm)
                    .HasColumnType("varchar(10)")
                    .IsRequired();

        }

    
    
    }
}