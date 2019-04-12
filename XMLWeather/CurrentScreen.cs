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
        string condition; 
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            #region current
            //current
            //sets temps and stuff to labels
            cityLabel.Text = Form1.days[0].location;
            dateLabel.Text = Form1.days[0].date;
            currenttempLabel.Text = Convert.ToDouble(Form1.days[0].currentTemp).ToString("0.") + "°C";
            maxminLabel.Text = "MAX: " + Convert.ToDouble(Form1.days[0].tempHigh).ToString("0.") + "°C " + "MIN: " + Convert.ToDouble(Form1.days[0].tempLow).ToString("0.") + "°C";

            //checks and displays weather condtiion
            if (Convert.ToDouble(Form1.days[0].condition) > 199 && Convert.ToDouble(Form1.days[0].condition) < 233
              || Convert.ToDouble(Form1.days[0].condition) > 299 && Convert.ToDouble(Form1.days[0].condition) < 322
              || Convert.ToDouble(Form1.days[0].condition) > 499 && Convert.ToDouble(Form1.days[0].condition) < 532)
            {
                condition = "ITS GUNNA RAIN!";
                this.BackgroundImage = Properties.Resources.rainGif;
            }
            else if (Convert.ToDouble(Form1.days[0].condition) > 599 && Convert.ToDouble(Form1.days[0].condition) < 623)
            {
                condition = "Snowing";
                this.BackgroundImage = Properties.Resources.snowGif;
            }
            else if (Convert.ToDouble(Form1.days[0].condition) > 800 && Convert.ToDouble(Form1.days[2].condition) < 805)
            {
                condition = "Say Howdy to the Cloudy";
                this.BackgroundImage = Properties.Resources.cloudGif;
            }
            else if (Convert.ToDouble(Form1.days[0].condition) == 800)
            {
                condition = "Sunshine";
                this.BackgroundImage = Properties.Resources.Sunny;
            }

            conditionLabel.Text = condition;
            #endregion
            #region Forcast
            //forcast
            //displays date and high low + condition day 1
            day1Label.Text = Form1.days[1].date;
            onedayLabel.Text = "MAX " + Convert.ToDouble(Form1.days[1].tempHigh).ToString("0.") + "°C " + "\n" + "MIN: " + Convert.ToDouble(Form1.days[1].tempLow).ToString("0.") + "°C";
            if (Convert.ToDouble(Form1.days[1].condition) > 199 && Convert.ToDouble(Form1.days[1].condition) < 233 
                || Convert.ToDouble(Form1.days[1].condition) > 299 && Convert.ToDouble(Form1.days[1].condition) < 322
                || Convert.ToDouble(Form1.days[1].condition) > 499 && Convert.ToDouble(Form1.days[1].condition) < 532)
            {
                d1Pic.BackgroundImage = Properties.Resources.rain;
            }
            else if (Convert.ToDouble(Form1.days[1].condition) > 599 && Convert.ToDouble(Form1.days[1].condition) < 623)
            {
                d1Pic.BackgroundImage = Properties.Resources.snowing;
            }
            else if (Convert.ToDouble(Form1.days[1].condition) > 800 && Convert.ToDouble(Form1.days[1].condition) < 805)
            {
                d1Pic.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Convert.ToDouble(Form1.days[1].condition) == 800)
            {
                d1Pic.BackgroundImage = Properties.Resources.Sunny;
            }

            //displays date and high low + condition day 2
            day2Label.Text = Form1.days[2].date;
            twodayLabel.Text = "MAX " + Convert.ToDouble(Form1.days[2].tempHigh).ToString("0.") + "°C " + "\n" + "MIN: " + Convert.ToDouble(Form1.days[2].tempLow).ToString("0.") + "°C";
            if (Convert.ToDouble(Form1.days[2].condition) > 199 && Convert.ToDouble(Form1.days[2].condition) < 233
                || Convert.ToDouble(Form1.days[2].condition) > 299 && Convert.ToDouble(Form1.days[2].condition) < 322
                || Convert.ToDouble(Form1.days[2].condition) > 499 && Convert.ToDouble(Form1.days[2].condition) < 532)
            {
                d2Pic.BackgroundImage = Properties.Resources.rain;
            }
            else if (Convert.ToDouble(Form1.days[2].condition) > 599 && Convert.ToDouble(Form1.days[2].condition) < 623)
            {
                d2Pic.BackgroundImage = Properties.Resources.snowing;
            }
            else if (Convert.ToDouble(Form1.days[2].condition) > 800 && Convert.ToDouble(Form1.days[2].condition) < 805)
            {
                d2Pic.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Convert.ToDouble(Form1.days[2].condition) == 800)
            {
                d2Pic.BackgroundImage = Properties.Resources.Sunny;
            }

            //displays date and high low + condition day 3
            day3Label.Text = Form1.days[3].date;
            tdayLabel.Text = "MAX " + Convert.ToDouble(Form1.days[3].tempHigh).ToString("0.") + "°C " + "\n" + "MIN: " + Convert.ToDouble(Form1.days[3].tempLow).ToString("0.") + "°C";
            if (Convert.ToDouble(Form1.days[3].condition) > 199 && Convert.ToDouble(Form1.days[3].condition) < 233
               || Convert.ToDouble(Form1.days[3].condition) > 299 && Convert.ToDouble(Form1.days[3].condition) < 322
               || Convert.ToDouble(Form1.days[3].condition) > 499 && Convert.ToDouble(Form1.days[3].condition) < 532)
            {
                d3Pic.BackgroundImage = Properties.Resources.rain;
            }
            else if (Convert.ToDouble(Form1.days[3].condition) > 599 && Convert.ToDouble(Form1.days[3].condition) < 623)
            {
                d3Pic.BackgroundImage = Properties.Resources.snowing;
            }
            else if (Convert.ToDouble(Form1.days[3].condition) > 800 && Convert.ToDouble(Form1.days[3].condition) < 805)
            {
                d3Pic.BackgroundImage = Properties.Resources.Cloudy;
            }
            else if (Convert.ToDouble(Form1.days[3].condition) == 800)
            {
                d3Pic.BackgroundImage = Properties.Resources.Sunny;
            }
            Refresh();
            #endregion
        }
    }
}
