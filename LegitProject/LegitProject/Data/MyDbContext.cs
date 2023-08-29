using LegitProject.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LegitProject.Data
{
   
        public class MyDbContext : DbContext
        {
            public MyDbContext(DbContextOptions<YourDbContext> options)
                : base(options)
            {
            }

            public DbSet<User> Users { get; set; }
            // Add more DbSet properties for other models if needed
        }
    
}
