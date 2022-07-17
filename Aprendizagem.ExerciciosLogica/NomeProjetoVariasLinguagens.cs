using Aprendizagem.ExerciciosLogica.Enums;
using Aprendizagem.ExerciciosLogica.Recursos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Esta classe foi desenvolvida para experimentar o uso de interpolação, enum, switch/case e recursos
//O método retorna um texto em Inglês e outro em Russo usando Unicode.


namespace Aprendizagem.ExerciciosLogica
{
     public class NomeProjetoVariasLinguagens
     {
        public string ProjetoIngles()
        {
            return "ACME";
        }

        public string ProjetoRusso()
        {
            return "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
        }
     
        public string ProjetoUE(Linguagem linguagem)
        {
            switch (linguagem)
            {
                case Linguagem.Frances:
                    return "Voir la sortie en français:";

                case Linguagem.Italiano:
                    return "Guarda l'output in italiano:";

                case Linguagem.Espanhol:
                    return "Ver la salida en español:";

                default:
                    return "View English output:";
            }
        }
        public string ProjetoOutrasLinguas(Linguagem linguagem)
        {
            switch (linguagem)
            {
                case Linguagem.Portugues:
                    return RecursoPtBr.ProjectNameMessage;

                case Linguagem.Zulu:
                    return RecursoZuAf.ProjectNameMessage;

                default:
                    return "View English output:";
            }
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

