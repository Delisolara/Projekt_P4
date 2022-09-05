using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.Model
{
    public class Sprzęt
    {
        public string Rodzaj { get; }
        public string Nazwa { get; }
        public string Firma { get; }

        public Sprzęt(string rodzaj, string nazwa, string firma)
        {
            Rodzaj = rodzaj;
            Nazwa = nazwa;
            Firma = firma;
        }

        public override string ToString()
        {
            return $"{Rodzaj} {Nazwa} {Firma}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Sprzęt sprzęt &&
                Rodzaj == sprzęt.Rodzaj &&
                Nazwa == sprzęt.Nazwa &&
                Firma == sprzęt.Firma;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Rodzaj, " ", Nazwa, " ", Firma);
        }

        public static bool operator ==(Sprzęt sprzęt1, Sprzęt sprzęt2)
        {
            if (sprzęt1 is null && sprzęt2 is null)
            { return true; }

            return !(sprzęt1 is null) && sprzęt1.Equals(sprzęt2);
        }

        public static bool operator !=(Sprzęt sprzęt1, Sprzęt sprzęt2)
        {
            return !(sprzęt1 == sprzęt2);
        }
    }
}
