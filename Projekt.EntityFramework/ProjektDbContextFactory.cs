using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.EntityFramework
{
    public class ProjektDbContextFactory : IDesignTimeDbContextFactory<ProjektDbContex>
    {
        public ProjektDbContex CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<ProjektDbContex>();
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;DataBase=ProjektWypoz;Trusted_Connection=True;");

            return new ProjektDbContex(options.Options);
        }
    }
}
