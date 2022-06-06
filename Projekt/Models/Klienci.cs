using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Klienci : DomainObject
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public int Nr_telefonu { get; set; }
        public Wypozyczalnia Wypozyczenie { get; set; }
    }
}
