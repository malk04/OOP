using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    /// <summary>
    /// Класс, реализующий библиотеку
    /// </summary>
    public abstract class Library
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        ///Количество книг
        /// </summary>
        public long BooksNumber { get; set; }

        /// <summary>
        /// Количество читальных залов
        /// </summary>
        public int ReadingRoomsCount { get; set; }

        /// <summary>
        /// Тип
        /// </summary>
        public string Type { get; set; } = "";

        /// <summary>
        /// Наличие WiFi
        /// </summary>
        public bool WithWiFi { get; set; }

        /// <summary>
        /// Рейтинг
        /// </summary>
        public double Rating { get; set; }

        /// <summary>
        /// Переопределенный метод ToString
        /// </summary>
        /// <returns>Данные библиотеки в виде строки</returns>
        public override string ToString()
        {
            return $"Library." + "\r\n" + $"Name: {Name}," + "\r\n" + $"BooksNumber: {BooksNumber}," + "\r\n" +
                $"ReadingRoomsCount: {ReadingRoomsCount}," + "\r\n" + $"Type: {Type}," + "\r\n" +
                $"WithWiFi: {WithWiFi}," + "\r\n" + $"Rating: {Rating}";
        }
    }
}
