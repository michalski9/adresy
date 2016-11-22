using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaysContainer.Models
{
    public class Pensja
    {
        public int Id { get; set; }
        public int Wynagrodzenie { get; set; }

        public bool Premia { get; set; }
        public bool Nagana { get; set; }

        public string GetPensja()
        {
            int wartosc = 0;
            if (Premia == true)
            {
                wartosc = Wynagrodzenie + (Wynagrodzenie * 20 / 100);
            }
            if(Nagana == true){
                wartosc = Wynagrodzenie - (Wynagrodzenie * 10 / 100);
            }

            return wartosc.ToString();
        }
    }
}