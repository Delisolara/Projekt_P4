using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Pracownicy : DomainObject
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Nr_telefonu { get; set; }
        public int Pensja { get; set; }
    }
}
