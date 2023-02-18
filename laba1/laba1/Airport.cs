using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    internal class Airport
    {
        private string name; // название аэропорта
        private string codeIATA; // код ИАТА
        private int countOfFlights; // количество рейсов
        private int countOfAirplanes; // количество самолётов
        private int countOfEmployees; // количество сотрудников
        private float countOfPassengers; // количество пассажиров в год в млн
        private double revenue; // доход за последний год в млрд.руб

        // конструктор без параметров
        public Airport()
        {
            name = "";
            codeIATA = "";
            countOfFlights = 0;
            countOfAirplanes = 0;
            countOfEmployees = 0;
            countOfPassengers = 0F;
            revenue = 0D;
        }

        /*public Airport()
        {
            name = "Домодедово";
            codeIATA = "DME";
            countOfFlights = 2950;
            countOfAirplane = 282;
            countOfEmployees = 2657;
            countOfPassengers = 25.065F;
            revenue = 3.2D;
        }*/

        // конструктор с двумя параметрами
        public Airport(string n, string code)
        {
            name = n;
            codeIATA = code;
            countOfFlights = 0;
            countOfAirplanes = 0;
            countOfEmployees = 0;
            countOfPassengers = 0F;
            revenue = 0D;
        }

        // конструктор со всеми полями
        public Airport(string n, string code, int flights, int airplanes, int employees, float passengers, double r)
        {
            name = n;
            codeIATA = code;
            countOfFlights = flights;
            countOfAirplanes = airplanes;
            countOfEmployees = employees;
            countOfPassengers = passengers;
            revenue = r;
        }

        public override string ToString()
        {
            return $"Название: {name}\nКод ИАТА: {codeIATA}\nКоличество рейсов: {countOfFlights}\n" +
                $"Количество самолётов: {countOfAirplanes}\nКоличество сотрудников: {countOfEmployees}\n" +
                $"Количество пассажиров в год в млн: {countOfPassengers}\nГодовой доход в млрд.руб: {revenue}";
        }

        /*public void PrintField(string field)
        {
            switch (field)
            {
                case "name":
                    Console.WriteLine($"Название: {name}");
                    break;
                case "codeIATA":
                    Console.WriteLine($"Код ИАТА: {codeIATA}");
                    break;
                case "countOfFlights":
                    Console.WriteLine($"Количество рейсов: {countOfFlights}");
                    break;
                case "countOfAirplanes":
                    Console.WriteLine($"Количество самолётов: {countOfAirplanes}");
                    break;
                case "countOfEmployees":
                    Console.WriteLine($"Количество сотрудников: {countOfEmployees}");
                    break;
                case "countOfPassengers":
                    Console.WriteLine($"Количество пассажиров в год в млн: {countOfPassengers}");
                    break;
                case "revenue":
                    Console.WriteLine($"Годовой доход в млрд.руб: {revenue}");
                    break;
            }
        }*/

        public string GetName()
        {
            return name;
        }

        public string GetCodeIATA()
        {
            return codeIATA;
        }

        public int GetCountOfFlights()
        {
            return countOfFlights;
        }

        public int GetCountOfAirplanes()
        {
            return countOfAirplanes;
        }

        public int GetCountOfEmployees()
        {
            return countOfEmployees;
        }

        public float GetCountOfPassengers()
        {
            return countOfPassengers;
        }

        public double GetRevenue()
        {
            return revenue;
        }

        public void SetName(string s)
        {
            name = s;
        }

        public void SetCodeIATA(string s)
        {
            codeIATA = s;
        }

        public void SetCountOfFlights(int x)
        {
            countOfFlights = x;
        }

        public void SetCountOfAirplanes(int x)
        {
            countOfAirplanes = x;
        }

        public void SetCountOfEmployees(int x)
        {
            countOfEmployees = x;
        }

        public void SetCountOfPassengers(float x)
        {
            countOfPassengers = x;
        }

        public void SetRevenue(double x)
        {
            revenue = x;
        }

        public void PrintName()
        {
            Console.WriteLine($"Название: {name}");
        }

        public void PrintCodeIATA()
        {
            Console.WriteLine($"Код ИАТА: {codeIATA}");
        }

        public void PrintCountOfFlights()
        {
            Console.WriteLine($"Количество рейсов: {countOfFlights}");
        }

        public void PrintCountOfAirplanes()
        {
            Console.WriteLine($"Количество самолётов: {countOfAirplanes}");
        }

        public void PrintCountOfEmployees()
        {
            Console.WriteLine($"Количество сотрудников: {countOfEmployees}");
        }

        public void PrintCountOfPassengers()
        {
            Console.WriteLine($"Количество пассажиров в год в млн: {countOfPassengers}");
        }

        public void PrintRevenue()
        {
            Console.WriteLine($"Годовой доход в млрд.руб: {revenue}");
        }

        public string CountOfAirplanesHex()
        {
            return Convert.ToString(countOfAirplanes, 16);
        }
    }
}
