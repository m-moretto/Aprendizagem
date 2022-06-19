using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizagem.ExerciciosLogica
{
    public class ConversaoTemperatura
    {
        public decimal FahrenheitParaCelsius(int fahrenheit)
        {
            decimal celsius = (fahrenheit - 32) * (5m / 9);
            
            return celsius;
        }

        public decimal FahrenheitParaKelvin(int fahrenheit)
        {
            return (fahrenheit - 10);
        }
    }
}
