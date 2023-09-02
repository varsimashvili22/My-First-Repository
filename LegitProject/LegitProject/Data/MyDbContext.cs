using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LegitProject.Models;

namespace LegitProject.Data
{
   
        public class MyDbContext : DbContext
        {
            public MyDbContext(DbContextOptions<MyDbContext> options)
                : base(options)
            {
            }
            public User? GetUserByUsername(string username)
            {
              return Users.FirstOrDefault(u => u.Username == username);
            }

        public DbSet<User> Users { get; set; }
            
        }
    
}
