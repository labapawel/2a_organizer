using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2a_organizer
{
    delegate void ZdDodania(DateTime czaszadania,  Day dane);
    internal class Day
    {
        public List<string> zadania_na_dzien = new List<string>();
    }
    internal class Organizer
    {
        public Dictionary<DateTime, Day> zadania_dnia = new Dictionary<DateTime, Day>();
        public void dodaj(DateTime data, string dane)
        {
           DateTime czas = new DateTime(data.Year, data.Month, data.Day);
           
           if(!zadania_dnia.ContainsKey(czas))
            {
                Day dane_zadania = new Day();
                dane_zadania.zadania_na_dzien.Add(dane);
                zadania_dnia.Add(czas, dane_zadania);
            } else  zadania_dnia[czas].zadania_na_dzien.Add(dane);

            DodanieZadania?.Invoke(czas, zadania_dnia[czas]);
        }

        public ZdDodania DodanieZadania;

    }
}
