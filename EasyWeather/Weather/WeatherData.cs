using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace EasyWeather
{
    public class WeatherData
    {
        public WebRequest Create(Uri uri)
        {
            WebRequest request = WebRequest.Create(uri);

            return request;
        }


        public string GetData(WebRequest webRequest)
        {
            try
            {
                HttpWebResponse response = (HttpWebResponse)webRequest.GetResponse();
                Stream data = response.GetResponseStream();
                StreamReader reader = new StreamReader(data);
                string finalData = reader.ReadToEnd();

                data.Close();
                response.Close();
                reader.Close();

                return finalData;
            }
            catch
            {
                const string error = "There was an error please try to input the city again";
                return error;
            }

        }
    }
}
