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
            grpBxCalculation.Show();           
            DateTime d1 = DateTime.Now; //Getter DateTime of first submit click
            int estData = Convert.ToInt32(tbxEstData.Text); // Getter for Estimation data
            double perMin = Convert.ToDouble(tbxPerMin.Text); //Getter for Per Minute
            double perHr = (estData / perMin) * 60; // Compute Logic for Per Hr
            double perDay = perHr * 24; // Compute Logic for Per Day
            double estDateTime = estData/perHr; // Compute Logic for Estimate of hr completion
            var timeSpan = TimeSpan.FromHours(estDateTime);
            lblPerHr.Text = perHr.ToString(); // Set Label perHr
            lblPerDay.Text = perDay.ToString();// Set Label perDay
            lblTimeNow.Text = d1.ToString("MM/dd/yyyy h:mm tt"); // set Label DateTime
            lblTimeComplete.Text = d1.AddHours(estDateTime).ToString("MM/dd/yyyy h:mm tt") +" ("+timeSpan.Hours.ToString() +" Hours " +timeSpan.Minutes.ToString() +" Mins)"; //Set Label add Hours
        }
    }
}
