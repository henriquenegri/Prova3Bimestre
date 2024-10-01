using Microsoft.EntityFrameworkCore;
using Prova3Bimestre.Models;

namespace Prova3Bimestre.Data
{
    public class AppCont: DbContext
    {
        public AppCont(DbContextOptions<AppCont> options) : base(options)
        {
            
        }
        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
