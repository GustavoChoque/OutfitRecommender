using Microsoft.EntityFrameworkCore;

namespace OutfitRecommender.Models
{
    public class OutfitRecommenderContext : DbContext
    {

        public OutfitRecommenderContext(DbContextOptions<OutfitRecommenderContext> options) : base(options) { }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RHQ5FG8\SQLEXPRESS; Database=OutfitRecommenderDb; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=true");
        }
        */

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Usuario>();
        
        }
    }
}
