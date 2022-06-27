using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizagem.ExerciciosLogica
{
    public class ConversaoTemperatura
    {
        public decimal FahrenheitParaCelsius(decimal fahrenheit)
        {
            decimal celsius = (fahrenheit - 32) * (5m / 9);
            
            return celsius;
        }

        public decimal FahrenheitParaKelvin(decimal fahrenheit)
        {
            decimal kelvin = 273.15m + FahrenheitParaCelsius(fahrenheit);

            return kelvin;
        }
    }
}
