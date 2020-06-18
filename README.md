# EasyWeather-Android
This is my first android project using xamarin froms.

## Documentation

Class: WeatherData
  -Description: Generates request uses it and returns the data.
Methods: WebRequest, GetData
WebRequest:
  -Description: Recieves a uri type generates the request based on the uri recieved and returns the web request object.
GetData:
  -Descriprion: Recieves a webrequest object. It uses streams to extract the data from the api and retuns it in the from of a string.
  
Class: ClientData
  -Description: Contructed with the city provides a utility to easily acces the api from multiple places.
Methods: ApiData
ApiData:
  -Description: Generates the uri object using the api key.
    
