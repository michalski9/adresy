using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DaysContainer.Models {
    public class Day {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required]
        public string Godziny { get; set; }

        [Required]
        [Display(Name="Obecność")] 
        public bool Obecnosc { get; set; }
        
        [Required]       
        public string Temat { get; set; }

        [Range(1,6)]
        public double Ocena { get; set; }
        [Required]
        public Miejsce Miejsce { get; set; }
        [Required]
        public string Prowadzacy { get; set; }

        [Display(Name="Stopień zadowolenia")]
        public double Stopien_zadowolenia { get; set; }

        public string GetDataGodzina(){
            string text = Godziny + Data;

            return text;
        }
    }

    public enum  Miejsce {
        BRZEG = 0,OŁAWA = 1
    }
}