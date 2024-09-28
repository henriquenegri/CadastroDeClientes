using Microsoft.EntityFrameworkCore;
using Cadastro_de_Clientes.Models;

namespace Cadastro_de_Clientes.Data
{
    public class AppCont: DbContext
    {
        public AppCont(DbContextOptions<AppCont> options): base(options) 
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
