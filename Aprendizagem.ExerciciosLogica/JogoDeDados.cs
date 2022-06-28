using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizagem.ExerciciosLogica
{
    public class JogoDeDados
    {    
        public int ArremessarDado()
        {
            Random dado = new Random();
            return dado.Next(1, 7);
        }

        public int ArremessarDados(int numeroDeDados)
        {
            var somaDosDados = 0;

            for (int i = 0; i < numeroDeDados; i++)
            {
                somaDosDados =+ ArremessarDado();
            }
            return somaDosDados;
        }

        public int[] ResultadoDeCadaArremesso(int numeroDeDados)
        {
            int[] resultadoDeCadaArremesso = new int[numeroDeDados];

            foreach (int i in resultadoDeCadaArremesso) 
            {
                resultadoDeCadaArremesso[i] = ArremessarDados(numeroDeDados);
            }
            return resultadoDeCadaArremesso;
        }
    }
}
