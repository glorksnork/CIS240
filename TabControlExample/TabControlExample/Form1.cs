using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void blackradiobutton_CheckedChanged(object sender, EventArgs e)
        {
            displaylabel.ForeColor = Color.Black; // change color to black
        }

       

      

        private void size12radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            displaylabel.Font = new Font(displaylabel.Font.Name, 12);
        }

      

        private void size20radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            displaylabel.Font = new Font(displaylabel.Font.Name, 20);
        }


        
        private void hellobtn_CheckedChanged_1(object sender, EventArgs e)
        {
            displaylabel.Text = "Hello!"; // change text to Hello!
        }

        private void Byebtn_CheckedChanged(object sender, EventArgs e)
        {
            displaylabel.Text = "Good Bye!"; // change text to Hello!
        }

        private void redradiobutton_CheckedChanged_1(object sender, EventArgs e)
        {
            displaylabel.ForeColor = Color.Red; // change color to red
        }

        private void greenradiobutton_CheckedChanged_1(object sender, EventArgs e)
        {
            displaylabel.ForeColor = Color.Green; // change color to Green
        }

        private void size16radiobutton_CheckedChanged_1(object sender, EventArgs e)
        {
            displaylabel.Font = new Font(displaylabel.Font.Name, 16);
        }
    }
    }

