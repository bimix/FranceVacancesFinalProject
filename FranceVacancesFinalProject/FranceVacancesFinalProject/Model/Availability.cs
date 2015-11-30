using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranceVacancesFinalProject.Model
{
    class Availability
    {
        private List<DateTimeOffset> availabilityList = new List<DateTimeOffset>();

        private DateTimeOffset _startTime;
        private DateTimeOffset _endTime;

        public DateTimeOffset StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }
        public DateTimeOffset EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }

        // Method to add days 
        public void AddAvailability(DateTimeOffset startTime, DateTimeOffset endTime)
        {
            DateTimeOffset temp = startTime;
            TimeSpan daysSpan = endTime - startTime;
            int count = int.Parse(daysSpan.Days.ToString("D"));

            for (int i = 0; i <= count; i++)
            {
                if (availabilityList.Contains(temp) == false)
                {
                    availabilityList.Add(temp);
                }
                temp = temp.AddDays(1);
            }
        }

        public bool IsBooked(DateTimeOffset day)
        {
            if (availabilityList.Contains(day))
            {
                return true;
            }
            return false;
        }
    }
}
