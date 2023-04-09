using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    interface IFactory
    {
        /// <summary>
        /// Возвращает объект библиотеки
        /// </summary>
        /// <param name="name">Название библиотеки</param>
        /// <param name="booksNumber">Количество книг в библиотеке</param>
        /// <param name="readingRoomsCount">Количество читальных залов в библиотеке</param>
        /// <param name="withWiFi">Наличие WiFi</param>
        /// <param name="rating">Рейтинг библиотеки</param>
        /// <returns>Объект библиотеки</returns>
        public Library createLibrary(string name, long booksNumber, int readingRoomsCount, bool withWiFi, double rating);
    }
}
