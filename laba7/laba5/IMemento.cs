using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    /// <summary>
    /// Интерфейс паттерна Хранитель (Memento)
    /// </summary>
    public interface IMemento
    {
        /// <summary>
        /// Геттер ID
        /// </summary>
        /// <returns>ID</returns>
        int GetID();

        /// <summary>
        /// Геттер названия
        /// </summary>
        /// <returns>Название</returns>
        string GetName();

        /// <summary>
        /// Геттер кол-ва книг
        /// </summary>
        /// <returns>Кол-во книг</returns>
        long GetBooksNumber();

        /// <summary>
        /// Геттер количества читальных залов
        /// </summary>
        /// <returns>Кол-во читальных залов</returns>
        int GetReadingRoomsCount();

        /// <summary>
        /// Геттер наличия WiFi
        /// </summary>
        /// <returns>Наличие WiFi</returns>
        bool GetWithWiFi();

        /// <summary>
        /// Геттер рейтинга
        /// </summary>
        /// <returns>Рейтинг</returns>
        double GetRating();
    }
}
