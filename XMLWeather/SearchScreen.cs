using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();

            todayLabel.Enabled = !true; todayLabel.Text = "";
            forecastLabel.Enabled = !true; forecastLabel.Text = "";
            searchLabel.Enabled = !true; searchLabel.Text = "";
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.searchBox = searchBox.Text;

                Form1.days.Clear();

                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                date1.Text = Form1.days[1].date;
                min1.Text = Form1.days[1].tempLow;
                max1.Text = Form1.days[1].tempHigh;

                date2.Text = Form1.days[2].date;
                min2.Text = Form1.days[2].tempLow;
                max2.Text = Form1.days[2].tempHigh;

                date3.Text = Form1.days[3].date;
                min3.Text = Form1.days[3].tempLow;
                max3.Text = Form1.days[3].tempHigh;

                date4.Text = Form1.days[4].date;
                min4.Text = Form1.days[4].tempLow;
                max4.Text = Form1.days[4].tempHigh;
            }
            catch
            {
                warningLabel.Text = "Invalid";
            }
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen fs = new CurrentScreen();
            f.Controls.Add(fs);
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
            todayLabel.Enabled = true; searchLabel.Text = "Search";
            todayLabel.Text = "Today";
        }
    }
}
