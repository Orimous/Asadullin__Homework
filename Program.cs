using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите день");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер месяца");
            int month = Convert.ToInt32(Console.ReadLine());
            int year = 2022;
            DateTime date = new DateTime(year, month, day);
            string newDate = Convert.ToString(date);

            switch (newDate)
            {
                case "01.01.2022 0:00:00":
                    Console.WriteLine("Новый год!");
                        break;
                case "25.01.2022 0:00:00":
                    Console.WriteLine("День студента");
                    break;
                case "23.02.2022 0:00:00":
                    Console.WriteLine("День защитника Отечества");
                    break;
                case "08.03.2022 0:00:00":
                    Console.WriteLine("Международный женский день");
                    break;
                case "01.05.2022 0:00:00":
                    Console.WriteLine("День труда");
                    break;
                case "09.05.2022 0:00:00":
                    Console.WriteLine("День Победы");
                    break;
                case "12.06.2022 0:00:00":
                    Console.WriteLine("День России");
                    break;
                case "01.09.2022 0:00:00":
                    Console.WriteLine("День знаний");
                    break;
                case "13.09.2022 0:00:00":
                    Console.WriteLine("День программиста");
                    break;
                case "04.11.2022 0:00:00":
                    Console.WriteLine("День народного единства");
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
