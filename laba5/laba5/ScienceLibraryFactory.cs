using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    public class ScienceLibraryFactory: IFactory
    {
        /// <summary>
        /// Возвращаемая библиотека
        /// </summary>
        private ScienceLibrary _library = new ScienceLibrary();

        /// <summary>
        /// Возвращает объект библиотеки
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="booksNumber">Кол-во книг</param>
        /// <param name="readingRoomsCount">Кол-во читальных залов</param>
        /// <param name="withWiFi">Наличие WiFi</param>
        /// <param name="rating">Рейтинг</param>
        /// <returns>Объект библиотеки</returns>
        public Library createLibrary(string name, long booksNumber, int readingRoomsCount, bool withWiFi, double rating)
        {
            _library.Name = name;
            _library.BooksNumber = booksNumber;
            _library.ReadingRoomsCount = readingRoomsCount;
            _library.WithWiFi = withWiFi;
            _library.Rating = rating;
            _library.Type = "Научная";

            return _library;
        }
    }
}
