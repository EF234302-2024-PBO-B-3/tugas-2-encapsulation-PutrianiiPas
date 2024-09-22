using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Calendar
{
    public class Date
    {
        // Properti public tanpa backing private field
        public int Month { get; private set; }
        public int Day { get; private set; }
        public int Year { get; private set; }

        // Konstruktor
        public Date(int month, int day, int year)
        {
            // Validasi
            if (month < 1 || month > 12 || day < 1 || day > 31)
            {
                Month = 1;
                Day = 1;
                Year = 1970;
            }
            else
            {
                Month = month;
                Day = day;
                Year = year;
            }
        }

        public void DisplayDate()
        {
            Console.WriteLine($"{Month}/{Day}/{Year}");
        }
    }
}