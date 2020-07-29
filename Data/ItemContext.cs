using APIBarDG.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Data
{
    public class ItemContext : DbContext
    {


        public ItemContext(DbContextOptions<ItemContext> options) : base(options)
        {
        }

        public ItemContext()
        {
        }

        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>().HasKey(m => m.ID);
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite("Data Source=BarDG.db");


    }
}
