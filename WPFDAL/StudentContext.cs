
using Microsoft.EntityFrameworkCore;
using WPFMODEL;

namespace WPFDAL
{
    public class StudentContext:DbContext
    {
        public DbSet<Students> Students { get; set; }
        public StudentContext() { }
        public StudentContext(DbContextOptions<StudentContext> opt):base(opt)
       {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=ADMIN\\MSSQL;Initial Catalog=StudentMVCDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
    }

}
