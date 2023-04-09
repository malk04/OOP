using System.Runtime.InteropServices;

namespace laba5
{
    public partial class Form1 : Form
    {
        private List<Library> _libraries;

        public Form1()
        {
            InitializeComponent();
            _libraries = new List<Library>();
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

                IFactory factory;
                if (radioButtonChild.Checked)
                {
                    factory = new ChildrensLibraryFactory();
                } 
                else
                {
                    factory = new ScienceLibraryFactory();
                }

                Library newLibrary = factory.createLibrary(name, booksNumber, readingRoomsCount, withWiFi, rating);
                _libraries.Add(newLibrary);
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
            radioButtonChild.Checked = true;
            radioButtonScince.Checked = false;
        }
    }
}