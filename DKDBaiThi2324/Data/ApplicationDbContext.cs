using Microsoft.EntityFrameworkCore;
using DKDBaiThi2324.Models;
namespace DKDBaiThi2324.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
    public DbSet<Person> Person {get; set;}
        public DbSet<DKDBaiThi2324.Models.Employee> Employee { get; set; } = default!;
    
   


}
}
