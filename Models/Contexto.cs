using LHPet.Model;
using Microsoft.EntityFrameworkCore;

namespace LHPet.Models
{
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context>options) : base(options)
        {
           
        }
         public DbSet<cliente>  cliente {get; set;}
    }
}