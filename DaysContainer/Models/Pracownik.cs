using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaysContainer.Models
{
    public class Pracownik
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Adres PAdres { get; set; }
        public Pensja PPensja { get; set; }
    }
}