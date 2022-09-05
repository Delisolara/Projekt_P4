using ProjektP4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.Exceptions
{
    public class ConfliktRezerwacji : Exception
    {
        private Rezerwacja rezerwacja;

        public Rezerwacja IstniejącaRezerwacja { get; }
        public Rezerwacja NadchodzącaRezerwacja { get; }

        public ConfliktRezerwacji(Rezerwacja istniejącaRezerwacja, Rezerwacja nadchodzącaRezerwacja)
        {
            IstniejącaRezerwacja = istniejącaRezerwacja;
            NadchodzącaRezerwacja = nadchodzącaRezerwacja;
        }

        public ConfliktRezerwacji(string? message, Rezerwacja istniejącaRezerwacja, Rezerwacja nadchodzącaRezerwacja) : base(message)
        {
            IstniejącaRezerwacja = istniejącaRezerwacja;
            NadchodzącaRezerwacja = nadchodzącaRezerwacja;
        }

        public ConfliktRezerwacji(string? message, Exception? innerException, Rezerwacja istniejącaRezerwacja, Rezerwacja nadchodzącaRezerwacja) : base(message, innerException)
        {
            IstniejącaRezerwacja = istniejącaRezerwacja;
            NadchodzącaRezerwacja = nadchodzącaRezerwacja;
        }
    }
}
