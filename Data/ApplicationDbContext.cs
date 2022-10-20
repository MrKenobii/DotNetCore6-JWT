using System;
using JwtBasics.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtBasics.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }
    }
}

