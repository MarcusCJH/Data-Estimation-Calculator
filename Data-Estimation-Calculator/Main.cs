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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            grpBxCalculation.Hide();
            
        }

        

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            
            if ((int.TryParse(tbxEstData.Text, out a) && a <= int.MaxValue) && (int.TryParse(tbxPerMin.Text, out b) && b <= int.MaxValue))
            {
                
                    //valid
                    grpBxCalculation.Show();
                    DateTime d1 = DateTime.Now; //Getter DateTime of first submit click
                    int estData = Convert.ToInt32(tbxEstData.Text); // Getter for Estimation data
                    int perMin = Convert.ToInt32(tbxPerMin.Text); //Getter for Per Minute
                    double perHr = estData * 60; // Compute Logic for Per Hr
                    double perDay = perHr * 24; // Compute Logic for Per Day
                    double estDateTime = estData / perMin; // Compute Logic for Estimate of hr completion
                    var timeSpan = TimeSpan.FromMinutes(estDateTime);
                    lblPerHr.Text = perHr.ToString(); // Set Label perHr
                    lblPerDay.Text = perDay.ToString();// Set Label perDay
                    lblTimeNow.Text = d1.ToString("MM/dd/yyyy h:mm tt"); // set Label DateTime
                    lblTimeComplete.Text = d1.AddMinutes(estDateTime).ToString("MM/dd/yyyy h:mm tt") + " (" + timeSpan.Hours.ToString() + " Hours " + timeSpan.Minutes.ToString() + " Mins)"; //Set Label add Hours

                
                
            }
            else
            {
                //invalid
                MessageBox.Show("Please enter a valid number");
                tbxEstData.Clear();
                tbxPerMin.Clear();
                grpBxCalculation.Hide();
                return;
            }
            
        }

        private void TestInt_KeyPress(object sender, KeyPressEventArgs e)
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
