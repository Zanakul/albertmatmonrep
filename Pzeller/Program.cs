using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 18/2/2021 albertmatmon
//comit 2

namespace Pzeller
{
    class Program
    {
        static void Main(string[] args)
        {

            int day = 12, month = 9, year = 2024;

            String stDat = bd(day, month, year);
            Console.WriteLine("International programmer's day: " + stDat + " sep2021");
            Console.ReadKey();
        }

        private static String bd(int day, int month, int year)
        {
            String[] ArrayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int a, y, m, d;
            a = (14 - month) / 12;
            y = year - a;
            m = month + 12 * a - 2;
            d = (day + y + y / 4 / 100 + y / 400 + (31 * m) / 12) % 7;
            return ArrayWeek[d];
        }
    }
}
