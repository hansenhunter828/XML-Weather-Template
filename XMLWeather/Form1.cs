﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static string searchBox = "Stratford,CA";
        // TODO: create list to hold day objects
        public static List<Day> days = new List<Day>();

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }
        public static void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/forecast/daily?q=" + searchBox + "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                //TODO: create a day object
                Day day = new Day();
                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                day.date = reader.GetAttribute("day");

                reader.ReadToFollowing("temperature");
                day.tempLow = Convert.ToDouble(reader.GetAttribute("min")).ToString("0");
                day.tempHigh = Convert.ToDouble(reader.GetAttribute("max")).ToString("0");

                //TODO: if day object not null add to the days list
                days.Add(day);
            }
        }

        public static void ExtractCurrent()
        {
            // current info is not included in forecast file so we need to use this file to get it
            XmlReader reader = XmlReader.Create("http://api.openweathermap.org/data/2.5/weather?q=Stratford,CA&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            //TODO: find the city and current temperature and add to appropriate item in days list
            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = Convert.ToDouble(reader.GetAttribute("value")).ToString("0");
            days[0].tempLow = Convert.ToDouble(reader.GetAttribute("min")).ToString("0");
            days[0].tempHigh = Convert.ToDouble(reader.GetAttribute("max")).ToString("0");

            reader.ReadToFollowing("weather");
            days[0].condition = reader.GetAttribute("value");
            days[0].code = Convert.ToInt32(reader.GetAttribute("number"));
        }
    }
}
