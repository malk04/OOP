using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1
{
    /// <summary>
    /// Класс Аэропорт
    /// </summary>
    class Airport
    {
        private string name; /// <summary> название аэропорта </summary>
        private string codeIATA; /// <summary> код ИАТА </summary>
        private int countOfFlights; /// <summary> количество рейсов </summary>
        private int countOfAirplanes; /// <summary> количество самолётов </summary>
        private int countOfEmployees; /// <summary> количество сотрудников </summary>
        private float countOfPassengers; /// <summary> количество пассажиров в год в млн </summary>
        private double revenue; /// <summary> доход за последний год в млрд.руб </summary>

        /// <summary>
        /// конструктор без параметров
        /// </summary>
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

        /// <summary>
        /// конструктор с двумя параметрами
        /// </summary>
        /// <param name="n"> Название аэропорта </param>
        /// <param name="code"> Код ИАТА аэропорта </param>
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

        /// <summary>
        /// конструктор со всеми полями
        /// </summary>
        /// <param name="n"> Название аэропорта </param>
        /// <param name="code"> Код ИАТА аэропорта</param>
        /// <param name="flights"> Количество рейсов </param>
        /// <param name="airplanes"> Количество самолётов </param>
        /// <param name="employees"> Количество сотрудников </param>
        /// <param name="passengers"> Количество пассажиров в год в млн </param>
        /// <param name="r"> Доход за последний год в млрд.руб </param>
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

        /// <summary>
        /// Переопределенный метод ToString
        /// </summary>
        /// <returns> Строка с полными данными аэропорта </returns>
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

        /// <summary>
        /// Геттер названия аэропорта
        /// </summary>
        /// <returns> Название аэропорта </returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Геттер кода ИАТА аэропорта
        /// </summary>
        /// <returns> Код ИАТА </returns>
        public string GetCodeIATA()
        {
            return codeIATA;
        }

        /// <summary>
        /// Геттер количества рейсов
        /// </summary>
        /// <returns> Количество рейсов </returns>
        public int GetCountOfFlights()
        {
            return countOfFlights;
        }

        /// <summary>
        /// Геттер количества самолётов
        /// </summary>
        /// <returns> Количество самолётов </returns>
        public int GetCountOfAirplanes()
        {
            return countOfAirplanes;
        }

        /// <summary>
        /// Геттер количества сотрудников
        /// </summary>
        /// <returns> Количество сотрудников </returns>
        public int GetCountOfEmployees()
        {
            return countOfEmployees;
        }

        /// <summary>
        /// Геттер количества пассажиров в год в млн
        /// </summary>
        /// <returns> Количество пассажиров в год в млн </returns>
        public float GetCountOfPassengers()
        {
            return countOfPassengers;
        }

        /// <summary>
        /// Геттер дохода аэропорта за последний год в млрд.руб
        /// </summary>
        /// <returns> Доход за последний год в млрд.руб </returns>
        public double GetRevenue()
        {
            return revenue;
        }

        /// <summary>
        /// Сеттер названия аэропорта
        /// </summary>
        /// <param name="s"> Название аэропорта </param>
        public void SetName(string s)
        {
            name = s;
        }

        /// <summary>
        /// Сеттер кода ИАТА аэропорта
        /// </summary>
        /// <param name="s"> Код ИАТА аэропорта </param>
        public void SetCodeIATA(string s)
        {
            codeIATA = s;
        }

        /// <summary>
        /// Сеттер количества рейсов
        /// </summary>
        /// <param name="x"> Количество рейсов </param>
        public void SetCountOfFlights(int x)
        {
            countOfFlights = x;
        }

        /// <summary>
        /// Сеттер количества самолётов
        /// </summary>
        /// <param name="x"> Количество самолётов </param>
        public void SetCountOfAirplanes(int x)
        {
            countOfAirplanes = x;
        }

        /// <summary>
        /// Сеттер количества сотрудников
        /// </summary>
        /// <param name="x"> Количество сотрудников </param>
        public void SetCountOfEmployees(int x)
        {
            countOfEmployees = x;
        }

        /// <summary>
        /// Сеттер количества пассажиров в год в млн
        /// </summary>
        /// <param name="x"> Количество пассажиров в год в млн </param>
        public void SetCountOfPassengers(float x)
        {
            countOfPassengers = x;
        }

        /// <summary>
        /// Сеттер дохода аэропорта за последний год в млрд.руб
        /// </summary>
        /// <param name="x"> Доход аэропорта за последний год в млрд.руб</param>
        public void SetRevenue(double x)
        {
            revenue = x;
        }

        /// <summary>
        /// Вывод названия аэропорта в консоль
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine($"Название: {name}");
        }

        /// <summary>
        /// Вывод кода ИАТА аэропорта в консоль
        /// </summary>
        public void PrintCodeIATA()
        {
            Console.WriteLine($"Код ИАТА: {codeIATA}");
        }

        /// <summary>
        /// Вывод количества рейсов в консоль
        /// </summary>
        public void PrintCountOfFlights()
        {
            Console.WriteLine($"Количество рейсов: {countOfFlights}");
        }

        /// <summary>
        /// Вывод количества самолётов в консоль
        /// </summary>
        public void PrintCountOfAirplanes()
        {
            Console.WriteLine($"Количество самолётов: {countOfAirplanes}");
        }

        /// <summary>
        /// Вывод количества сотрудников в консоль
        /// </summary>
        public void PrintCountOfEmployees()
        {
            Console.WriteLine($"Количество сотрудников: {countOfEmployees}");
        }

        /// <summary>
        /// Вывод количества пассажиров в год в млн в консоль
        /// </summary>
        public void PrintCountOfPassengers()
        {
            Console.WriteLine($"Количество пассажиров в год в млн: {countOfPassengers}");
        }

        /// <summary>
        /// Вывод годовой дохода аэропорта в млрд.руб в консоль
        /// </summary>
        public void PrintRevenue()
        {
            Console.WriteLine($"Годовой доход в млрд.руб: {revenue}");
        }

        /// <summary>
        /// Переводит количество самолётов в шестнадцатиричную систему счисления
        /// </summary>
        /// <returns> Количество самолётов в шестнадцатиричной системе счисления </returns>
        public string CountOfAirplanesHex()
        {
            return Convert.ToString(countOfAirplanes, 16);
        }
    }
}
