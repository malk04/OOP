using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    /// <summary>
    /// Класс, реализующий научную библиотеку
    /// </summary>
    public class ScienceLibrary: Library
    {
        /// <summary>
        /// Минимальный возраст читателей
        /// </summary>
        public int MinAge = 18;

        /// <summary>
        /// Переопределенный метод ToString
        /// </summary>
        /// <returns> Строка с полными данными библиотеки </returns>
        public override string ToString()
        {
            return $"ScienceLibrary." + "\r\n" + $"Name: {Name}," + "\r\n" + $"BooksNumber: {BooksNumber}," + "\r\n" +
                $"ReadingRoomsCount: {ReadingRoomsCount}," + "\r\n" + $"Type: {Type}," + "\r\n" +
                $"WithWiFi: {WithWiFi}," + "\r\n" + $"Rating: {Rating}," + "\r\n" + $"MinAge: {MinAge}";
        }
    }
}
