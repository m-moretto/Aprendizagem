using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizagem.ExerciciosLogica
{
    /*Este método foi desenvolvido para experimentar expressões boolianas para tomada de decisões
     *Em específico foi utilizado o operador condicional*/
    //O método simula o arremesso de uma moeda e retorna "cara" ou "coroa"

    public class CaraOuCoroa
    {
       public string Resultado()
        {
            Random moeda = new Random();
            int arremessarMoeda = moeda.Next(0, 2);
            string resultado = arremessarMoeda == 0 ? "CARA" : "COROA";
            return resultado;
        }

    }
}
