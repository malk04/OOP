using System;

namespace laba1
{
    public class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Лабораторная работа № 1. Класс. Создание объекта. Работа с консолью.\n" +
                "21ВП2. Вариант 5. Малькова, Лакеева");
            Console.WriteLine("\n");
            Airport noName = new Airport();
            Console.WriteLine(noName.ToString());
            Console.WriteLine("\n");
            Airport penza = new Airport("Penza", "PNZ");
            Airport domodedovo = new Airport("Domodedovo", "DME", 2950, 282, 2657, 25.065F, 3.2D);
            penza.PrintName();
            Console.WriteLine("Код ИАТА: " + penza.GetCodeIATA());
            Console.WriteLine("\n");
            Console.WriteLine("Название: " + domodedovo.GetName());
            Console.WriteLine("Код ИАТА: " + domodedovo.GetCodeIATA());
            Console.WriteLine("Количество рейсов: " + domodedovo.GetCountOfFlights());
            Console.WriteLine("Количество самолётов: " + domodedovo.GetCountOfAirplanes());
            Console.WriteLine("Количество сотрудников: " + domodedovo.GetCountOfEmployees());
            Console.WriteLine("Количество пассажиров в год в млн: " + domodedovo.GetCountOfPassengers());
            Console.WriteLine("Годовой доход в млрд.руб: " + domodedovo.GetRevenue());
            Console.WriteLine("\n");
            Console.WriteLine("Количество самолётов в шестнадцатиричной системе счисления: " + domodedovo.CountOfAirplanesHex());
            Console.WriteLine("\n");
            Console.WriteLine($"Введите новое название аэропорта {penza.GetName()}:");
            penza.SetName(Console.ReadLine());
            Console.WriteLine($"Введите новое количество сотрудников аэропорта {penza.GetName()}:");
            penza.SetCountOfEmployees(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Введите новое значение дохода в млрд.руб аэропорта {penza.GetName()}:");
            penza.SetRevenue(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("\n");
            Console.WriteLine(penza.ToString());
        }
    }
}