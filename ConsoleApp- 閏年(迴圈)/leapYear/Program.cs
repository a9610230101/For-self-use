using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            
            int year;
            Console.WriteLine("請輸入年份(西元) :");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("西元"+year + "是閏年");
            }
            else
            {
                Console.WriteLine(year + "並非閏年");

            }

          
            }
        }
    }
}
