using System;
using System.Windows.Forms;

namespace Moonbase
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            InitializeButtonHandlers();
        }

        private void InitializeButtonHandlers()
        {
            button1.Click += (sender, e) => OpenForm<Form2>();
            button2.Click += (sender, e) => OpenForm<Form3>();
            button3.Click += (sender, e) => ShowCurrentLocation();
            button4.Click += (sender, e) => OpenForm<Form5>();
        }

        private void ShowCurrentLocation()
        {
            MessageBox.Show("You are currently here on the East Side of the Moon. Take a few easy breaths and gently heal.", "East", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenForm<T>() where T : Form, new()
        {
            T form = new T();
            form.Show();
        }
    }
}
