using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba5
{
    /// <summary>
    /// Класс памяти
    /// </summary>
    public class Memory
    {
        /// <summary>
        /// Стек с историей изменения объекта
        /// </summary>
        private Stack<IMemento> history;

        /// <summary>
        /// Объект библиотеки
        /// </summary>
        private Library library;

        /// <summary>
        /// ID
        /// </summary>
        private int id;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="library">Объект библиотеки</param>
        public Memory(Library library)
        {
            this.library = library;
            id = library.GetID();
            history = new Stack<IMemento>();
        }

        /// <summary>
        /// Добавление в стек объекта, хранящего состояние объекта библиотеки
        /// </summary>
        public void Backup() => history.Push(library.Save());

        /// <summary>
        /// Восстановление версии объекта библиотеки
        /// </summary>
        /// <returns>Восстановлена или нет</returns>
        public bool Undo()
        {
            if (history.Count == 0) return false;
            library.Restore(history.Pop());
            return true;
        }

        /// <summary>
        /// Геттер поля id
        /// </summary>
        /// <returns></returns>
        public int GetID() => id;
    }
}
