using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();

            todayLabel.Enabled = !true; todayLabel.Text = "";
            forecastLabel.Enabled = !true; forecastLabel.Text = "";
            searchLabel.Enabled = !true; searchLabel.Text = "";
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.days[0].location;
            currentOutput.Text = Form1.days[0].currentTemp;
            minOutput.Text = Form1.days[0].tempLow;
            maxOutput.Text = Form1.days[0].tempHigh;
            conditionsLabel.Text = Form1.days[0].condition;

            if (Form1.days[0].code == 800)
            {
                this.BackColor = Color.LightBlue;
            }
            if(Form1.days[0].code >= 801 && Form1.days[0].code <= 804)
            {
                this.BackColor = Color.LightGray;
            }
            if (Form1.days[0].code >= 600 && Form1.days[0].code <= 622)
            {
                this.BackColor = Color.White;
            }
            if (Form1.days[0].code >= 500 && Form1.days[0].code <= 531)
            {
                this.BackColor = Color.DarkBlue;
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void menuLabel_Click(object sender, EventArgs e)
        {
            forecastLabel.Enabled = true; forecastLabel.Text = "4 Day";
            searchLabel.Enabled = true; searchLabel.Text = "Search";
            todayLabel.Text = "Today";
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            SearchScreen cs = new SearchScreen();
            f.Controls.Add(cs);
        }
    }
}