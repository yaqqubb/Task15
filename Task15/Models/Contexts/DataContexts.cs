using Microsoft.EntityFrameworkCore;
using Task15.Models.Entities;

namespace Task15.Models.Contexts
{
    public class DataContexts :DbContext
    {
        public DataContexts(DbContextOptions options)
        
            :base(options){ }
        
        public DbSet<Countries> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

           
                   
                
        }
    }
}
