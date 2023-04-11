using System.Runtime.InteropServices;
using System.Reflection;

namespace laba5
{
    public partial class Form1 : Form
    {
        private List<Library> _libraries;
        private List<Memory> _memories;

        public Form1()
        {
            InitializeComponent();
            _libraries = new List<Library>();
            _memories = new List<Memory>();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text,
                    String caption, uint type);

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printAll_Click(object sender, EventArgs e)
        {
            foreach (Library item in _libraries)
            {
                string s = item.ToString();
                output.Text += s + "\r\n\r\n";
            }
        }

        private void clearWindow_Click(object sender, EventArgs e)
        {
            output.Clear();
        }

        private void create_Click(object sender, EventArgs e)
        {
            foreach (Control item in create.Parent.Controls)
            {
                if (item.GetType().Name == "TextBox" && item.Text == "")
                {
                    MessageBox(0, "Заполните все поля", "Найдено пустое поле", 0);
                    return;
                }
            }

            try
            {
                string name = textBoxName.Text;
                long booksNumber = Int64.Parse(textBoxBooksNumber.Text);
                int readingRoomsCount = Int32.Parse(textBoxReadingRoomsCount.Text);
                bool withWiFi = checkBoxWithWiFi.Checked;
                double rating = Double.Parse(textBoxRating.Text);

                Library newLibrary = new Library(name, booksNumber, readingRoomsCount, withWiFi, rating);
                _libraries.Add(newLibrary);

                Memory newMemory = new Memory(newLibrary);
                newMemory.Backup();
                _memories.Add(newMemory);
            }
            catch (FormatException ex)
            {
                InvalidConvertingException ex1 = new InvalidConvertingException("Невозможно преобразовать " +
                    "введенные данные к типу ", ex.TargetSite.Name);
                MessageBox(0, ex1.Message + ex1.GetRtype(), "Неверное преобразование", 0);
                return;
            }
            foreach (Control item in create.Parent.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    item.Text = "";
                }
            }
            checkBoxWithWiFi.Checked = false;
        }

        private void fieldsButton_Click(object sender, EventArgs e)
        {
            Type type = typeof(Library);
            string s = "Поля:" + "\r\n";

            foreach (FieldInfo field in type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic
                | BindingFlags.Public | BindingFlags.Static))
            {
                string modificator = "";
                if (field.IsPublic)
                    modificator += "public  ";
                else if (field.IsPrivate)
                    modificator += "private  ";
                if (field.IsStatic) modificator += "static  ";

                s += $"{modificator}{field.FieldType.Name}   {field.Name}" + "\r\n"; ;
            }

            output.Text += s + "\r\n" + "\r\n";
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            foreach (Control item in changeButton.Parent.Controls)
            {
                if (item.Text == "")
                {
                    MessageBox(0, "Заполните все поля", "Найдено пустое поле", 0);
                    return;
                }
            }
            int id = (int)numericUpDownID.Value;
            string field = textBoxField.Text;
            string value = textBoxValue.Text;

            Type type = typeof(Library);

            try
            {
                bool find = false;
                foreach (Library library in _libraries)
                {
                    if (library.GetID() == id) { find = true; break; }
                }
                if (!find)
                {
                    MessageBox(0, $"Объект с ID {id} не найден", "Неверный ID объекта", 0);
                    return;
                }
                if (type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static) == null)
                {
                    throw new UnidentifiedFieldException($"Поля {field} не существует в контескте класса Library");
                }
            }
            catch (UnidentifiedFieldException ex)
            {
                MessageBox(0, ex.Message, "Неизвестное поле класса", 0);
                return;
            }

            if (field == "ID")
            {
                MessageBox(0, "Невозможно изменить значение поля ID", "Изменение невозможно", 0);
                return;
            }

            if (type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static).IsStatic)
            {
                MessageBox(0, "Невозможно изменить значение статического поля класса", "Изменение невозможно", 0);
                return;
            }

            foreach (Library item in _libraries)
            {
                try
                {
                    if (item.GetID() == id)
                    {
                        var f = type.GetField(field, BindingFlags.Instance | BindingFlags.NonPublic);
                        string n = f.FieldType.Name;
                        if (n == "Int32")
                        {
                            f?.SetValue(item, Int32.Parse(value));
                        }
                        else if (n == "Int64")
                        {
                            f?.SetValue(item, Int64.Parse(value));
                        }
                        else if (n == "String")
                        {
                            f?.SetValue(item, value);
                        }
                        else if (n == "Single")
                        {
                            f?.SetValue(item, float.Parse(value));
                        }
                        else if (n == "Double")
                        {
                            f?.SetValue(item, Double.Parse(value));
                        }

                        output.Text += $"Поле {field} объекта с ID {id} успешно изменено" + "\r\n" + "\r\n";

                        foreach (Memory mem in _memories)
                        {
                            if (mem.GetID() == id)
                            {
                                mem.Backup();
                                break;
                            }
                        }
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    InvalidConvertingException ex1 = new InvalidConvertingException($"Невозможно преобразовать " +
                        $"{value} к типу ", ex.TargetSite.Name);
                    MessageBox(0, ex1.Message + ex1.GetRtype(), "Неверное преобразование", 0);
                    return;
                }
            }
            foreach (Control item in changeButton.Parent.Controls)
            {
                if (item.GetType().Name == "TextBox")
                {
                    item.Text = "";
                }
            }
            numericUpDownID.Value = 0;
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            bool find = false;
            int id = (int)numericUpDownIDRestore.Value;
            Memory mem = null;

            foreach (Memory memory in _memories)
            {
                if (memory.GetID() == id) { 
                    find = true;
                    mem = memory;
                    break; 
                }
            }
            if (!find)
            {
                MessageBox(0, $"Объект с ID {id} не найден", "Неверный ID объекта", 0);
                return;
            }

            if (!mem.Undo())
            {
                MessageBox(0, "Актуальна последняя версия объекта", "Восстановление невозможно", 0);
                return;
            } else if (!mem.Undo())
            {
                MessageBox(0, "Актуальна последняя версия объекта", "Восстановление невозможно", 0);
                return;
            } else
            {
                mem.Backup();
                output.Text += $"Предыдущая версия бъекта с ID {id} успешно восстановлена" + "\r\n" + "\r\n";
            }
        }
    }
}