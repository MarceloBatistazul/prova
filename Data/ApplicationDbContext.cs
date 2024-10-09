using Avalicao.Models;
using Microsoft.EntityFrameworkCore;

namespace Avaliçãoc_.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<CadastroCliente> CadastroCliente { get; set; }
    }
}
