﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherSystemLogic
{
    public class DailyForecast
    {
        private DateTime date;
        private Weather weather;

        public DailyForecast(DateTime date, Weather weather)
        {
            this.date = date;
            this.weather = weather;
        }

        public override string ToString()
        {
            return $"{date.ToString("dd/MM/yyyy HH:mm:ss", null)}: {weather}";
        }

        public Weather Weather { get { return weather; } set { weather = value; } }
        public double Temperature { get { return weather.GetTemperature(); } }
        public DateTime Date {  get { return date; } }

        public static bool operator >(DailyForecast left, DailyForecast right)
        {
            return left.Temperature > right.Temperature;
        }

        public static bool operator <(DailyForecast left, DailyForecast right)
        {
            return left.Temperature < right.Temperature;
        }

    }
}
