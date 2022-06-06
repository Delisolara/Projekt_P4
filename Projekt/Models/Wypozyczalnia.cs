using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Wypozyczalnia : DomainObject
    {
        public Pracownicy Pracownik { get; set; }
        public IEnumerable<Lista_wypozyczen> Lista { get; set; }
        public DateTime Data_wypozyczenia { get; set; }
        public DateTime Data_zwrotu { get; set; }
        public int Cena { get; set; }
    }
}
