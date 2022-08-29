using Microsoft.EntityFrameworkCore;

namespace EmpresaCadastro.Models
{
    public class BandoDeDados : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=EmpresaCadastro;Integrated Security=True");
        }
    }
}
