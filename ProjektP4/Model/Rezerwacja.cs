using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektP4.Model
{
    public class Rezerwacja
    {
        //public Klienci KlienciID { get;}
        public Sprzęt Sprzęt { get; }
        public DateTime Data_wypożyczenia { get; }
        public DateTime Data_oddania { get; }

        public TimeSpan Length => Data_oddania.Subtract(Data_wypożyczenia);

        public Rezerwacja(Sprzęt sprzętID, DateTime data_wypożyczenia, DateTime data_oddania)
        {
            Sprzęt = sprzętID;
            Data_wypożyczenia = data_wypożyczenia;
            Data_oddania = data_oddania;
        }

        public bool Conflicts(Rezerwacja rezerwacja)
        {
            if (rezerwacja.Sprzęt != Sprzęt)
            { return false; }

            return rezerwacja.Data_wypożyczenia < Data_oddania && rezerwacja.Data_oddania > Data_wypożyczenia;
        }
    }
}
