using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Cirrious.MvvmCross.ViewModels;

namespace Weather.Common.Model
{
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
    }

    public class Temp
    {
        public double day { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public double night { get; set; }
        public double eve { get; set; }
        public double morn { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Temp temp { get; set; }
        public double pressure { get; set; }
        public int humidity { get; set; }
        public List<Weather> weather { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public int clouds { get; set; }
        public double rain { get; set; }
    }

    public class WeatherJsonData
    {
        public City city { get; set; }
        public string cod { get; set; }
        public double message { get; set; }
        public int cnt { get; set; }
        public List<List> list { get; set; }
    }

    public class WeatherData
    {
        public DateTime RecorededDataime { get; set; }
        public List<DailyTemperature> WeeklyTempraure { get; set; }
    }

    public class DailyTemperature : MvxNotifyPropertyChanged
    {
        private string _city;
        private string _country;
        private DateTime _date;
        private string _shortDate;
        private string _Temperature;

        public string ShortDate
        {
            get { return _shortDate; }
            set { _shortDate = value; RaisePropertyChanged(() => ShortDate); }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; RaisePropertyChanged(() => City); }
        }

        public string Country
        {
            get { return _country; }
            set
            {
                _country = value;
                RaisePropertyChanged(() => Country);
            }
        }
                
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                RaisePropertyChanged(() => Date);
            }
        }

        public string Temperature 
        {
            get { return _Temperature; }
            set 
            {
                _Temperature = value; 
                RaisePropertyChanged(() => Temperature); 
            }
        }
    }

}
