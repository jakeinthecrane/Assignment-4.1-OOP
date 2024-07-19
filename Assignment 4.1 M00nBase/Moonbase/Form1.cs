using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

//namespace declaration
namespace Moonbase
{
    //MoonbaseAssignment will inherit from Form which is the base class for all Windows forms.  
    public partial class MoonbaseAssignment1 : Form
    {
        //Fields that declare read only trackers along with an array to store different locations on the moon.  
        //You can find the logs in gthe bin\Debug folder under "User_position_log.txt".
        private readonly UserPositionTracker _positionTracker;
        private readonly Location[] locations;

        //A constructor for our MoonbaseAssignment1 class        
        public MoonbaseAssignment1()
        {
            InitializeComponent(); //this method call initializes the forms components.
            _positionTracker = new UserPositionTracker(); // _positionTracker field is initialized 
            this.MouseMove += new MouseEventHandler(Form_MouseMove); //attatches Form_MouseMove to the event handler of the MouseMove event.
            locations = InitializeLocations(); //method is called initializing the locations array.
        }
        //MouseMove event handler. The 'sender' parameter represents the source of the event and 'e' contains the event data.
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            _positionTracker.UserPosition = e.Location; //UserPosition property is updated with the current mouse location. 
        }
         
        //Locations method that initializes and returns an array of 'location' objects. This is called once during the forms construction to set 
        //the available locations.
        private Location[] InitializeLocations()
        {
            return new Location[] //Returns a nes array of 'location' objects.
            {
                new Location("Check in Lounge", "North", "Welcome to the North Side of the Moon"),
                new Location("Sauna Time", "West", "Welcome to the West Side of the Moon"),
                new Location("Salt Time", "East", "Welcome to the East Side of the Moon"),
                new Location("Weightless Zone", "South", "Welcome to the South Side of the Moon")
            };
        }

        //Method that displays information about a location given its index.  
        private void DisplayLocationInfo(int index)
        {
            if (index >= 0 && index < locations.Length) //if statement verifying that the index is within the valid range of the locations array. 
            {
                Location location = locations[index]; //location object is retrieved at the index.
                //interpolation string for a message box displaying the locations information. 
                MessageBox.Show($"Name: {location.LocationName}\nDescription: {location.LocationDescription}\nBackground: {location.ScenicView}");
            }
        }

       //button event handler 
        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use the code MOONDANCE for 20% off treatment");
        }

        //button event handlers encapsulated. These nav buttons take you from area to area.
        private void Button2_Click(object sender, EventArgs e)
        {
            ShowForm(new Form2(), 0);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ShowForm(new Form3(), 1);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ShowForm(new Form4(), 2);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ShowForm(new Form5(), 3);
        }

        //show form method 
        private void ShowForm(Form form, int locationIndex)
        {
            form.Show(); //displays the form
            DisplayLocationInfo(locationIndex); //calls the DisplayLocationInfo about the specific location. 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoonbaseAssignment1_Load(object sender, EventArgs e)
        {

        }
    }
    //Declared this class to track and log the users position.
    public class UserPositionTracker
    {
        private Point _userPosition;//field to store the users position.

        public Point UserPosition //property to get and set the users position. Holds X and Y coordinates when stroring userPosition.
        {
            get { return _userPosition; } //returns the current value of the private field to _userPosition.
            set
            {
                if (_userPosition != value) //this condition checks if the new value is different from the current value of _userPosition.
                {
                    _userPosition = value; //if true, _userPosition is assigned a new value by the setter.  
                    LogPosition(_userPosition);//after updating the setter calls the LogPosition method passing _userPosition as an argument.
                }
            }
        }
        //This method doesn't return a value due to it void. But it records the users current position of x and y coordinates as well as date and time. 
        private void LogPosition(Point position) //method to log the users position to a file
        {
            string logPath = "User_position_log.txt"; //this is where the logs are saved.
            string logEntry = $"X: {position.X}, Y: {position.Y}, Time: {DateTime.Now}"; //Interpolation string log entry of the coordinates of the user, date & time.
                                                                                        
            File.AppendAllText(logPath, logEntry + Environment.NewLine); //writes the log entry to the file 'logPath. AppendAllText makes sure
            //log entries are added to the end of the file. Environment.NewLine adds a new line after each log entry. 
        }
    }
    //Location class to store and manage information about the different locations in the Moonbase application.  
    public class Location
    {
        //here are 3 public properties that allow the app to encapsulate data and provide a means to get and set values.
        public string ScenicView { get; set; }
        public string LocationName { get; set; }
        public string LocationDescription { get; set; }

        //Location class constructor that is called when an instance is created.  It takes the 3 parameters seen below and sets the values. 
        public Location(string scenicView, string locationName, string locationDescription)
        {
            ScenicView = scenicView;
            LocationName = locationName;
            LocationDescription = locationDescription;
        }
    }
}
