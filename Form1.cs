using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIPositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                //set up variables
                int integer;
                integer = Convert.ToInt32(inputTextBox.Text);

                //if the integer is positive, display positive message
                if (integer >= 0)
                {
                    positiveLabel.Text = $"{integer} is a positive number";
                }
                //if the integer is negative, display negative message
                else
                {
                    positiveLabel.Text = $"{integer} is a negative number";
                }

                //if the integer is divisible by 7, display "divisible" message
                if (integer % 7 == 0)
                {
                    divisibleLabel.Text = $"{integer} is divisible by 7";
                }
                //if integer is not divisible by 7, display "not divisible" message
                else
                {
                    divisibleLabel.Text = $"{integer} is not divisible by 7";
                }
            }
            //error message if an invalid integer is typed
            catch
            {
                positiveLabel.Text = "Please input a valid integer!";
                divisibleLabel.Text = "";
            }


        }

 
    }
}
