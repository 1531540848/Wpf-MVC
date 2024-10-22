using Microsoft.EntityFrameworkCore;
using WPFMODEL;

namespace WPFDAL
{
    public class ManagerContext:DbContext
    {
        public DbSet<Managers> Managers {  get; set; }

        public ManagerContext(DbContextOptions<ManagerContext> opt):base(opt) { }

        public ManagerContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            builder.UseSqlServer("Data Source=ADMIN\\MSSQL;Initial Catalog=StudentMVCDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        }
    }
}
