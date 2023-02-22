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
        /// <summary> название аэропорта </summary>
        private string _name; 

        /// <summary> код ИАТА </summary>
        private string _codeIATA; 

        /// <summary> количество рейсов </summary>
        private int _countOfFlights; 

        /// <summary> количество самолётов </summary>
        private int _countOfAirplanes; 

        /// <summary> количество сотрудников </summary>
        private int _countOfEmployees; 

        /// <summary> количество пассажиров в год в млн </summary>
        private float _countOfPassengers; 

        /// <summary> доход за последний год в млрд.руб </summary>
        private double _revenue; 

        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Airport()
        {
            _name = "";
            _codeIATA = "";
            _countOfFlights = 0;
            _countOfAirplanes = 0;
            _countOfEmployees = 0;
            _countOfPassengers = 0F;
            _revenue = 0D;
        }

        /// <summary>
        /// конструктор с одним параметром
        /// </summary>
        /// <param name="n"> Название аэропорта </param>
        public Airport(string n)
        {
            _name = n;
            _codeIATA = "";
            _countOfFlights = 0;
            _countOfAirplanes = 0;
            _countOfEmployees = 0;
            _countOfPassengers = 0F;
            _revenue = 0D;
        }

        /// <summary>
        /// конструктор с двумя параметрами
        /// </summary>
        /// <param name="n"> Название аэропорта </param>
        /// <param name="code"> Код ИАТА аэропорта </param>
        public Airport(string n, string code)
        {
            _name = n;
            _codeIATA = code;
            _countOfFlights = 0;
            _countOfAirplanes = 0;
            _countOfEmployees = 0;
            _countOfPassengers = 0F;
            _revenue = 0D;
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
            _name = n;
            _codeIATA = code;
            _countOfFlights = flights;
            _countOfAirplanes = airplanes;
            _countOfEmployees = employees;
            _countOfPassengers = passengers;
            _revenue = r;
        }

        /// <summary>
        /// Переопределенный метод ToString
        /// </summary>
        /// <returns> Строка с полными данными аэропорта </returns>
        public override string ToString()
        {
            return $"Название: {_name}\nКод ИАТА: {_codeIATA}\nКоличество рейсов: {_countOfFlights}\n" +
                $"Количество самолётов: {_countOfAirplanes}\nКоличество сотрудников: {_countOfEmployees}\n" +
                $"Количество пассажиров в год в млн: {_countOfPassengers}\nГодовой доход в млрд.руб: {_revenue}";
        }

        /// <summary>
        /// Геттер названия аэропорта
        /// </summary>
        /// <returns> Название аэропорта </returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Геттер кода ИАТА аэропорта
        /// </summary>
        /// <returns> Код ИАТА </returns>
        public string GetCodeIATA()
        {
            return _codeIATA;
        }

        /// <summary>
        /// Геттер количества рейсов
        /// </summary>
        /// <returns> Количество рейсов </returns>
        public int GetCountOfFlights()
        {
            return _countOfFlights;
        }

        /// <summary>
        /// Геттер количества самолётов
        /// </summary>
        /// <returns> Количество самолётов </returns>
        public int GetCountOfAirplanes()
        {
            return _countOfAirplanes;
        }

        /// <summary>
        /// Геттер количества сотрудников
        /// </summary>
        /// <returns> Количество сотрудников </returns>
        public int GetCountOfEmployees()
        {
            return _countOfEmployees;
        }

        /// <summary>
        /// Геттер количества пассажиров в год в млн
        /// </summary>
        /// <returns> Количество пассажиров в год в млн </returns>
        public float GetCountOfPassengers()
        {
            return _countOfPassengers;
        }

        /// <summary>
        /// Геттер дохода аэропорта за последний год в млрд.руб
        /// </summary>
        /// <returns> Доход за последний год в млрд.руб </returns>
        public double GetRevenue()
        {
            return _revenue;
        }

        /// <summary>
        /// Сеттер названия аэропорта
        /// </summary>
        /// <param name="s"> Название аэропорта </param>
        public void SetName(string s)
        {
            _name = s;
        }

        /// <summary>
        /// Сеттер кода ИАТА аэропорта
        /// </summary>
        /// <param name="s"> Код ИАТА аэропорта </param>
        public void SetCodeIATA(string s)
        {
            _codeIATA = s;
        }

        /// <summary>
        /// Сеттер количества рейсов
        /// </summary>
        /// <param name="x"> Количество рейсов </param>
        public void SetCountOfFlights(int x)
        {
            _countOfFlights = x;
        }

        /// <summary>
        /// Сеттер количества самолётов
        /// </summary>
        /// <param name="x"> Количество самолётов </param>
        public void SetCountOfAirplanes(int x)
        {
            _countOfAirplanes = x;
        }

        /// <summary>
        /// Сеттер количества сотрудников
        /// </summary>
        /// <param name="x"> Количество сотрудников </param>
        public void SetCountOfEmployees(int x)
        {
            _countOfEmployees = x;
        }

        /// <summary>
        /// Сеттер количества пассажиров в год в млн
        /// </summary>
        /// <param name="x"> Количество пассажиров в год в млн </param>
        public void SetCountOfPassengers(float x)
        {
            _countOfPassengers = x;
        }

        /// <summary>
        /// Сеттер дохода аэропорта за последний год в млрд.руб
        /// </summary>
        /// <param name="x"> Доход аэропорта за последний год в млрд.руб</param>
        public void SetRevenue(double x)
        {
            _revenue = x;
        }

        /// <summary>
        /// Вывод названия аэропорта в консоль
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine($"Название: {_name}");
        }

        /// <summary>
        /// Вывод кода ИАТА аэропорта в консоль
        /// </summary>
        public void PrintCodeIATA()
        {
            Console.WriteLine($"Код ИАТА: {_codeIATA}");
        }

        /// <summary>
        /// Вывод количества рейсов в консоль
        /// </summary>
        public void PrintCountOfFlights()
        {
            Console.WriteLine($"Количество рейсов: {_countOfFlights}");
        }

        /// <summary>
        /// Вывод количества самолётов в консоль
        /// </summary>
        public void PrintCountOfAirplanes()
        {
            Console.WriteLine($"Количество самолётов: {_countOfAirplanes}");
        }

        /// <summary>
        /// Вывод количества сотрудников в консоль
        /// </summary>
        public void PrintCountOfEmployees()
        {
            Console.WriteLine($"Количество сотрудников: {_countOfEmployees}");
        }

        /// <summary>
        /// Вывод количества пассажиров в год в млн в консоль
        /// </summary>
        public void PrintCountOfPassengers()
        {
            Console.WriteLine($"Количество пассажиров в год в млн: {_countOfPassengers}");
        }

        /// <summary>
        /// Вывод годового дохода аэропорта в млрд.руб в консоль
        /// </summary>
        public void PrintRevenue()
        {
            Console.WriteLine($"Годовой доход в млрд.руб: {_revenue}");
        }

        /// <summary>
        /// Переводит количество самолётов в шестнадцатиричную систему счисления
        /// </summary>
        /// <returns> Количество самолётов в шестнадцатиричной системе счисления </returns>
        public string CountOfAirplanesHex()
        {
            return Convert.ToString(_countOfAirplanes, 16);
        }
    }
}
