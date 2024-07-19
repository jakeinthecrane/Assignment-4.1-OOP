using System;
using System.Windows.Forms;

namespace Moonbase
{
    //Form 3, 4 and 5 are the same as 2
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            InitializeButtonHandlers();
        }

        private void InitializeButtonHandlers()
        {
            button1.Click += (sender, e) => OpenForm<Form2>();
            button2.Click += (sender, e) => ShowCurrentLocation();
            button3.Click += (sender, e) => OpenForm<Form4>();
            button4.Click += (sender, e) => OpenForm<Form5>();
        }

        private void ShowCurrentLocation()
        {
            MessageBox.Show("You are currently here on the West Side of the Moon. Begin your detoxification session and relax.", "West", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenForm<T>() where T : Form, new()
        {
            T form = new T();
            form.Show();
        }
    }
}
