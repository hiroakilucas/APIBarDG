using Microsoft.EntityFrameworkCore;

namespace APIBarDG.Data
{
    public class ComandaContext : DbContext
    {


        public ComandaContext(DbContextOptions<ComandaContext> options) : base(options)
        {
        }

        public ComandaContext()
        {
        }

        public DbSet<Model.Comanda.Comanda> Comanda { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Model.Comanda.Comanda>().HasKey(m => m.ID);
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlite("Data Source=BarDG.db");


    }
}