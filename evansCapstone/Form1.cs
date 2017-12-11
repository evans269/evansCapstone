using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evansCapstone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hourInSeconds = Convert.ToInt32(hoursT.Text) * 3600;
            int minuteInSeconds = Convert.ToInt32(minutesT.Text) * 60;
            int second = Convert.ToInt32(secondsT.Text);
            double distanceNumber = Convert.ToDouble(number.Text);
            double formDistance = double.Parse(number.Text);


            double totalTimeInSeconds = hourInSeconds + minuteInSeconds + second;
            double distanceInMiles;


            if (fromcombo1.SelectedItem.ToString() == "Kilometers")
            {
                distanceInMiles = formDistance * 0.62;
            }
            else
            {
                distanceInMiles = formDistance;
            }


            double pace = totalTimeInSeconds / distanceInMiles;

            var timeSpan = TimeSpan.FromSeconds(pace);
            int hh = timeSpan.Hours;
            int mm = timeSpan.Minutes;
            int ss = timeSpan.Seconds;


            hoursP.Text = hh.ToString("#.");
            minutesP.Text = mm.ToString("#.");
            secondsP.Text = ss.ToString("#.");


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void hoursP_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void hoursT_TextChanged(object sender, EventArgs e)
        {
            if (hoursT.Text != "")
            {
                if (int.TryParse(hoursT.Text, out int hours) == false)
                {
                    hoursT.Text = "Error";
                }
            }
        }

        private void minutesT_TextChanged(object sender, EventArgs e)
        {
            if (minutesT.Text != "")
            {
                if (int.TryParse(minutesT.Text, out int minutes) == false)
                {
                    minutesT.Text = "Error";
                }
            }
        }

        private void secondsT_TextChanged(object sender, EventArgs e)
        {
            if (secondsT.Text != "")
            {
                if (int.TryParse(secondsT.Text, out int seconds) == false)
                {
                    secondsT.Text = "Error";
                }
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
