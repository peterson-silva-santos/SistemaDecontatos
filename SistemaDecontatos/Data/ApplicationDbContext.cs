using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SistemaDecontatos.Models;

namespace SistemaDecontatos.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

           
        }
        public DbSet<ClienteModel> ClienteBd { get; set; }
        
    }


}
