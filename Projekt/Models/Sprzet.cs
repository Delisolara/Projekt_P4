using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Sprzet : DomainObject
    {
        public string Rodzaj { get; set; }
        public string Nazwa { get; set; }
        public string Firma { get; set; }
    }
}
