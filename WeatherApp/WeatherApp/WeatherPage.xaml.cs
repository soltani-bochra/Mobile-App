﻿using System;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.Title = "ACN Weather App";
            getWeatherBtn.Clicked += GetWeatherBtn_Clicked;

            //Set the default binding to a default object for now  
            this.BindingContext = new Weather();
        }

        private async void GetWeatherBtn_Clicked(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(zipCodeEntry.Text))
            {
                Weather weather = await Core.GetWeather(zipCodeEntry.Text);
                this.BindingContext = weather;
                getWeatherBtn.Text = "Search Again";
            }           
        }
    }
}