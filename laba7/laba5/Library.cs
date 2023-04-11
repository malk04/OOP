using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// laba 7
namespace laba5
{
    /// <summary>
    /// Класс, реализующий библиотеку
    /// </summary>
    public class Library
    {
        /// <summary>
        /// статическое поле для генерации id объектов
        /// </summary>
        private static int static_id = 0;

        /// <summary> id объекта </summary>
        private readonly int ID;

        /// <summary>
        /// Название
        /// </summary>
        private string Name;

        /// <summary>
        ///Количество книг
        /// </summary>
        private long BooksNumber;

        /// <summary>
        /// Количество читальных залов
        /// </summary>
        private int ReadingRoomsCount;

        /// <summary>
        /// Наличие WiFi
        /// </summary>
        private bool WithWiFi;

        /// <summary>
        /// Рейтинг
        /// </summary>
        private double Rating;

        /// <summary>
        /// Конструктор со всеми полями
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="booksNumber">Количество книг</param>
        /// <param name="readingRoomsCount">Количество читальных залов</param>
        /// <param name="withWiFi">Наличие WiFi</param>
        /// <param name="rating">Рейтинг</param>
        public Library(string name, long booksNumber, int readingRoomsCount, bool withWiFi, double rating)
        {
            this.ID = static_id;
            this.Name = name;
            this.BooksNumber = booksNumber;
            this.ReadingRoomsCount = readingRoomsCount;
            this.WithWiFi = withWiFi;
            this.Rating = rating;
            static_id++;
        }

        /// <summary>
        /// Переопределенный метод ToString
        /// </summary>
        /// <returns>Данные библиотеки в виде строки</returns>
        public override string ToString()
        {
            return $"Library." + "\r\n" + $"ID: {ID}," + "\r\n" + $"Name: {Name}," + "\r\n" + $"BooksNumber: {BooksNumber}," + "\r\n" +
                $"ReadingRoomsCount: {ReadingRoomsCount}," + "\r\n" +
                $"WithWiFi: {WithWiFi}," + "\r\n" + $"Rating: {Rating}";
        }

        /// <summary>
        /// Сохраняет состояние объекта
        /// </summary>
        /// <returns>Объект, хранящий состояние объекта библиотеки</returns>
        public LibraryMemento Save() => new LibraryMemento(ID, Name, BooksNumber, ReadingRoomsCount, WithWiFi, Rating);

        /// <summary>
        /// Восстановление объекта
        /// </summary>
        /// <param name="libraryMemento">Объект, хранящий состояние объекта библиотеки</param>
        public void Restore(IMemento libraryMemento)
        {
            Name = libraryMemento.GetName();
            BooksNumber = libraryMemento.GetBooksNumber();
            ReadingRoomsCount = libraryMemento.GetReadingRoomsCount();
            WithWiFi = libraryMemento.GetWithWiFi();
            Rating = libraryMemento.GetRating();
        }

        /// <summary>
        /// Геттер поля ID
        /// </summary>
        /// <returns>ID</returns>
        public int GetID() => ID;
    }
}
