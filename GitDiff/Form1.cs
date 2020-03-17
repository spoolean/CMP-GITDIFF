using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Linq;

namespace Minimalist_UI //template I made for all the window features
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDifferent.Visible = false; //set labels to be invisible on load
            lblSame.Visible = false;
        }
        

        //WindowMove
        private bool mouseDown; // variables to control window movement
        private Point lastLocation;

        private void splitContainer1_MouseDown(object sender, MouseEventArgs e) //mouse down on top bar
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void splitContainer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y); //location movement

                this.Update();
            }
        }
        private void splitContainer1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close(); //on x button press
        }

        private static bool _maximised = false;
        private void maximise_Click(object sender, EventArgs e)
        {
            if (_maximised)
            {
                WindowState = FormWindowState.Normal; //normal if maximized
                _maximised = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized; //maximized if normal
                _maximised = true;
            }
        }

        private void minimise_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; //minimize on button press
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDifferent.Visible = false; // make sure they both return to 0 or off
            lblSame.Visible = false;
            
            string file1 = File1Drop.Text; //retrieve the text from the drop menus
            string file2 = File2Drop.Text;

            string[] file1Array = File.ReadAllLines("../../" + file1); //open both files into seperate arrays
            string[] file2Array = File.ReadAllLines("../../" + file2);

            string file1Concat = string.Concat(file1Array); //use built in linq concat function to append all array item into one string
            string file2Concat = string.Concat(file2Array);

            int hashFile1 = file1Concat.GetHashCode(); // retureve a hash of each string
            int hashFile2 = file2Concat.GetHashCode();

            if (hashFile1 == hashFile2) //compare the two hashes
            {
                lblSame.Visible = true; //if they are the same then show the same lable
            }
            else
            {
                lblDifferent.Visible = true;//if not show the different label
            }
        }

    }
}
