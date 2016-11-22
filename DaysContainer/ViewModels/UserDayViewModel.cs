using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DaysContainer.Models;

namespace DaysContainer.ViewModels
{
    public class UserDayViewModel
    {
        public ApplicationUser User { get; set; }
        public List<Day> Days { get; set; }

         
    }
}