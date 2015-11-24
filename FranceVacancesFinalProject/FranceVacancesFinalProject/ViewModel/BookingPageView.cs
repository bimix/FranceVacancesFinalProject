using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FranceVacancesFinalProject.Common;
using FranceVacancesFinalProject.Model;
using FranceVacancesFinalProject.View;

namespace FranceVacancesFinalProject.ViewModel
{
    class BookingPageView
    {
        public RelayCommand GetDays { get; set; }


        public int DoGetDays(DateTimeOffset start, DateTimeOffset end)
        {
            int days;
            TimeSpan howManyDays = end - start;
            days = Int32.Parse(howManyDays.Days.ToString("D"));
            return days;
        }



        public BookingPageView()
        {

         //  GetDays = new RelayCommand(DoGetDays());
        }
    }
}
