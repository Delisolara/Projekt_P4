using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Projekt.EntityFramework
{
    public class ProjektDbContex :DbContext
    {
       

        public DbSet<Klienci> Klient { get; set; }
        public DbSet<Wypozyczalnia> Wypozyczalnia { get; set; }
        public DbSet<Lista_wypozyczen> Lista { get; set; }
        public DbSet<Sprzet> Sprzet_sportowy { get; set; }
        public DbSet<Pracownicy> Pracownik { get; set; }

        public ProjektDbContex(DbContextOptions options) : base(options) { }
        
       
    }
}
