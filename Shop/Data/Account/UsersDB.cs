using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Account
{
    public class UsersDB : IdentityDbContext
    {
       // public UsersDB(DbContextOptions<UsersDB> options) : base(options)
      //  {

      //  }

       // public DbSet<User> Users { get; set; }

      //  protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
      //      base.OnModelCreating(modelBuilder);
      //      modelBuilder.Seed();
      //  }
    }
}
