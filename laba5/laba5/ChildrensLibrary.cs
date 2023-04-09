using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    /// <summary>
    /// Класс, реализующий детскую библиотеку
    /// </summary>
    public class ChildrensLibrary: Library
    {
        /// <summary>
        /// Максимальный возраст читателей
        /// </summary>
        private int MaxAge = 17;

        /// <summary>
        /// Переопределенный метод ToString
        /// </summary>
        /// <returns> Строка с полными данными библиотеки </returns>
        public override string ToString()
        {
            return $"ChildrensLibrary." + "\r\n" + $"Name: {Name}," + "\r\n" + $"BooksNumber: {BooksNumber}," + "\r\n" +
                $"ReadingRoomsCount: {ReadingRoomsCount}," + "\r\n" + $"Type: {Type}," + "\r\n" +
                $"WithWiFi: {WithWiFi}," + "\r\n" + $"Rating: {Rating}," + "\r\n" + $"MinAge: {MaxAge}";
        }
    }
}
