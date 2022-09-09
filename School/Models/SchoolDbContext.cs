using Microsoft.EntityFrameworkCore;
using School.ViewModel;

namespace School.Models
{
    public class SchoolDbContext:DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options):base(options)
        {

        }


        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubjectRank>()
                .HasKey(sr => new { sr.Id});


            modelBuilder.Entity<SubjectRank>()
                .HasOne(r => r.Rank)
                .WithMany(sr => sr.SubjectRank)
                .HasForeignKey(ri => ri.RankId);

            modelBuilder.Entity<SubjectRank>()
                .HasOne(r => r.Subject)
                .WithMany(sr => sr.SubjectRank)
                .HasForeignKey(ri => ri.SubjectId);


        }
        public DbSet<SubjectRank> SubjectRanks { get; set; }

    }
}
