using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDAL
{
    internal class DbContextFactory : IDesignTimeDbContextFactory<StudentContext>
    {
        public StudentContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StudentContext>();
            builder.UseSqlServer("Data Source=ADMIN\\MSSQL;Initial Catalog=StudentMVCDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            return new StudentContext(builder.Options);
        }
    }
}
