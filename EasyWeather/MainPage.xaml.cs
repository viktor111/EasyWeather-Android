using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyWeather.Weather;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace EasyWeather
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            string cityName = City.Text;

            var weatherData = new WeatherData();
            var clientData = new ClientData(cityName);

            Uri apiString = clientData.ApiData();

            var web = weatherData.Create(apiString);
            string response = weatherData.GetData(web);            

            LabelData.Text = response;

        }
    }
}
