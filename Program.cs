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
                Console.WriteLine("Enter your favoirite day.");

                DaysOfWeek today = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine());

                Console.WriteLine("Your faviorite day is "+ today);
            }
            catch
            {
                Console.WriteLine("That is incorrect.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
