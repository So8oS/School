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
       // public DbSet<School.ViewModel.RankViewModel>? RankViewModel { get; set; }
    }
}
