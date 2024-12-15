using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //date 04.11.2024, days = 1, sum = 60000
            while (true)
            {
                Console.Write("Дата начала: ");
                DateTime start = DateTime.Parse(Console.ReadLine());
                DateTime now = DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy"));
                ulong days = ulong.Parse(((now - start).TotalDays).ToString());
                Console.Write("Сумма начала: ");
                ulong sum = ulong.Parse(Console.ReadLine());
                for (ulong i = 0; i < days; i++)
                {
                    sum += sum / 10;
                }
                Console.WriteLine(sum);
                Console.WriteLine(days);
            }
        }
    }
}