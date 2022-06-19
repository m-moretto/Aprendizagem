// See https://aka.ms/new-console-template for more information
using Aprendizagem.ExerciciosLogica;

Console.WriteLine("Coloque a temperatura em fahrenheit: ");
int fahrenheit = Console.Read();

var conversaoTemparatura = new ConversaoTemperatura();

var celsius = conversaoTemparatura.FahrenheitParaCelsius(fahrenheit);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

var kelvin = conversaoTemparatura.FahrenheitParaKelvin(fahrenheit);
Console.WriteLine("The temperature is " + kelvin + " Kelvin.");