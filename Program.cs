using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAssignment
{
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day.");
                string day1 = Console.ReadLine();

                DaysOfWeek day = (DaysOfWeek)Convert.ToInt32(day1);

                Console.WriteLine(day);

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter an actual day of the week.");

                Console.ReadLine();
            }
        }
    }
}
