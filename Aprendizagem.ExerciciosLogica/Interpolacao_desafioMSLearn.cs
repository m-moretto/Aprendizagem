using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta classe foi desenvolvida para experimentar o uso de interpolação.
//O método retorna um texto em Inglês e outro em Russo usando Unicode.

namespace Aprendizagem.ExerciciosLogica
{
    public class Interpolacao_desafioMSLearn
    {
        public string ObterNomeDoProjetoEmIngles()
        {
           return "ACME";
        }

        public string ObterNomeDoProjetoEmRusso()
        {
            return "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        }
    }
}


/* A forma como código foi descrito originalmente:
 * 
 string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
Console.WriteLine($@"View English output:
        c:\Exercise\{projectName}\data.txt
                        ");
Console.WriteLine($@"{russianMessage}
        c:\Exercise\{projectName}\ru-RU\data.txt
                        ");
 */
