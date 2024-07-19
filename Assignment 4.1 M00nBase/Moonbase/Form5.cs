using System.Windows.Forms;

namespace Moonbase
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            InitializeButtonHandlers();
        }

        private void InitializeButtonHandlers()
        {
            button4.Click += (sender, e) => ShowCurrentLocation("South");
            button1.Click += (sender, e) => OpenForm<Form2>();
            button2.Click += (sender, e) => OpenForm<Form3>();
            button3.Click += (sender, e) => OpenForm<Form4>();
        }

        private void ShowCurrentLocation(string location)
        {
            MessageBox.Show($"You are currently here on the {location} Side of the Moon. Be weightless, feel free.", location, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenForm<T>() where T : Form, new()
        {
            T form = new T();
            form.Show();
        }
    }
}
