﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaysContainer.Models
{
    public class Adres
    {
        public int Id { get; set; }

        public string Kraj { get; set; }
        public string Miejscowosc { get; set; }

        public string Ulica { get; set; }
        public string NumerDomu { get; set; }
        public string NumerMieszkania { get; set; }

        
    }
}