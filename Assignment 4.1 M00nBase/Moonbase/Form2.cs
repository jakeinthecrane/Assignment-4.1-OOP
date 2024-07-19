using System;
using System.Windows.Forms;

namespace Moonbase
{
    //partial class Form2 which inherits from the Form class. 
    public partial class Form2 : Form
    {
        //Form2 constructor is called when an instance of Form2 is created. 
        public Form2()
        {
            InitializeComponent(); //Method that sets up the forms controls
            InitializeButtonHandlers(); //custom method which sets up event handlers for buttons. 
        }
        //this method sets up event handlers for 4 buttons.
        private void InitializeButtonHandlers()
        {
            button1.Click += (sender, e) => ShowCurrentLocation(); //4 event handlers using Lambda Expressions to open the different areas available
            button2.Click += (sender, e) => OpenForm<Form3>();     //we would need to define separate methods for each event handler and attatch 
            button3.Click += (sender, e) => OpenForm<Form4>();     //them to events if we didn't use this method.  It's cleaner, concise,...
            button4.Click += (sender, e) => OpenForm<Form5>();
        }

        private void ShowCurrentLocation() //method to show current location.  This will change depending on the form youre on. 
        {
            MessageBox.Show("You are currently here on the North Side of the Moon. Relax, make yourself at home.", "North", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //OpenForm generic method thats called to open a new form. 
        private void OpenForm<T>() where T : Form, new()
        {
            T form = new T(); //this constraint specifies that T can must be a type that inherits from form and be a parameterless constructor.
                              //It can open any form as long as it inherits from T. 
            form.Show(); //this method displays the form on the screen. 
        }
    }
}
