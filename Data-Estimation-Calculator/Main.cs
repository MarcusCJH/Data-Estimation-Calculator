using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Estimation_Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
            grpBxCalculation.Hide();
        }

        

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            decimal d;
            if (decimal.TryParse(tbxEstData.Text, out d) && decimal.TryParse(tbxPerMin.Text, out d)) 
            {
                if(d <= int.MaxValue)
                {
                    //valid
                    grpBxCalculation.Show();
                    DateTime d1 = DateTime.Now; //Getter DateTime of first submit click
                    int estData = Convert.ToInt32(tbxEstData.Text); // Getter for Estimation data
                    double perMin = Convert.ToDouble(tbxPerMin.Text); //Getter for Per Minute
                    double perHr = (estData / perMin) * 60; // Compute Logic for Per Hr
                    double perDay = perHr * 24; // Compute Logic for Per Day
                    double estDateTime = estData / perHr; // Compute Logic for Estimate of hr completion
                    var timeSpan = TimeSpan.FromHours(estDateTime);
                    lblPerHr.Text = perHr.ToString(); // Set Label perHr
                    lblPerDay.Text = perDay.ToString();// Set Label perDay
                    lblTimeNow.Text = d1.ToString("MM/dd/yyyy h:mm tt"); // set Label DateTime
                    lblTimeComplete.Text = d1.AddHours(estDateTime).ToString("MM/dd/yyyy h:mm tt") + " (" + timeSpan.Hours.ToString() + " Hours " + timeSpan.Minutes.ToString() + " Mins)"; //Set Label add Hours
                }
                else
                {
                    MessageBox.Show("Out of range");
                    grpBxCalculation.Hide();
                    return;
                }
                
            }
            else
            {
                //invalid
                MessageBox.Show("Please enter a valid number");
                grpBxCalculation.Hide();
                return;
            }
            
        }

        private void TbxEstData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
