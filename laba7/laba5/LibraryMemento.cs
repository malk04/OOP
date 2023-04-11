using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    /// <summary>
    /// Класс объекта, хранящего состояние объекта библиотеки
    /// </summary>
    public class LibraryMemento: IMemento
    {
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
        /// Конструктор объекта, хранящего состояние объекта библиотеки
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="name">Название</param>
        /// <param name="booksNumber">Количество книг</param>
        /// <param name="readingRoomsCount">Количество читальных залов</param>
        /// <param name="withWiFi">Наличие WiFi</param>
        /// <param name="rating">Рейтинг</param>
        public LibraryMemento(int ID, string name, long booksNumber, int readingRoomsCount, bool withWiFi, double rating)
        {
            this.ID = ID;
            this.Name = name;
            this.BooksNumber = booksNumber;
            this.ReadingRoomsCount = readingRoomsCount;
            this.WithWiFi = withWiFi;
            this.Rating = rating;
        }

        /// <summary>
        /// Геттер ID
        /// </summary>
        /// <returns>ID</returns>
        public int GetID() => ID;

        /// <summary>
        /// Геттер названия
        /// </summary>
        /// <returns>Название</returns>
        public string GetName() => Name;

        /// <summary>
        /// Геттер кол-ва книг
        /// </summary>
        /// <returns>Кол-во книг</returns>
        public long GetBooksNumber() => BooksNumber;

        /// <summary>
        /// Геттер количества читальных залов
        /// </summary>
        /// <returns>Кол-во читальных залов</returns>
        public int GetReadingRoomsCount() => ReadingRoomsCount;

        /// <summary>
        /// Геттер наличия WiFi
        /// </summary>
        /// <returns>Наличие WiFi</returns>
        public bool GetWithWiFi() => WithWiFi;

        /// <summary>
        /// Геттер рейтинга
        /// </summary>
        /// <returns>Рейтинг</returns>
        public double GetRating() => Rating;
    }
}
