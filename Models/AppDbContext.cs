using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace App.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserModel> Users {get; set;}
        public DbSet<RecipeModel> Recipes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=D:\Studia\Praca\App\Data\data.db");
    }
}