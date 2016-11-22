using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaysContainer.ViewModels
{
    public class Workers
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Dzial { get; set; }
        public string Stanowisko { get; set; }
        public DateTime DataZaturdniena { get; set; }

    }
}