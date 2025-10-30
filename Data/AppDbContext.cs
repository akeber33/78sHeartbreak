using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _78sHeartbreak.Models;
using Microsoft.EntityFrameworkCore;

namespace _78sHeartbreak.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TarotCartas> TarotCartas { get; set; } 
    }
}