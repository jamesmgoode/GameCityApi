using GameCityApi.Models;
using GameCityApi.Models.NineIsles;
using Microsoft.EntityFrameworkCore;

namespace GameCityApi.Data
{
    public partial class TorchbearerContext : DbContext
    {
        public TorchbearerContext() { }

        public TorchbearerContext(DbContextOptions<TorchbearerContext> options) : base(options) { }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<SuggestedHelp> SuggestedHelp { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SuggestedHelp>()
                .HasKey(sh => new { sh.SkillId, sh.SuggestedHelpSkillId });
        }
    }
}
