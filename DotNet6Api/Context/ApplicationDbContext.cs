using DotNet6Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet6Api.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
        
        }   
        public DbSet<Post> Posts { get; set; }
    }
}
