using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.Model
{
    public class Klienci
    {
        //public string Imie { get; }
        //public string Nazwisko { get; }
        public string Login { get; }
        public string Hasło { get; }

        public Klienci(string login, string haslo)
        {
            Login = login;
            Hasło = haslo;
        }




    }
}
