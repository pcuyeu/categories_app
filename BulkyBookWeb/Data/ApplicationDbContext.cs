using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data;

// DbContext is a instance that interacts with the database
public class ApplicationDbContext : DbContext 
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {    
    }
    
    // Creates a table of type Category  
    public DbSet<Category> Categories { get; set; } 

}
