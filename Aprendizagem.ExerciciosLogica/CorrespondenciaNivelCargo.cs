using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Objetivo de aprendizagem: Usar a instrução switch.
 * 
 * Aplicativo que mostrava o cargo de um funcionário na empresa ao lado do seu nome.
 * Cargos mudam ocasionalmente, armazenamos apenas o nível do funcionário, que é um equivalente numérico do seu cargo.
 * Quando quisermos exibir seu cargo, será necessário avaliar o nível numérico e retornar o cargo.
 */

namespace Aprendizagem.ExerciciosLogica
{
    public class CorrespondenciaNivelCargo
    {
        public string ObterNivel(int nivelDoFuncionario)
        {
            string titulo = "";

            switch (nivelDoFuncionario)
            {
                case 100:
                    titulo = "Junior Associate";
                    break;
                case 200:
                    titulo = "Senior Associate";
                    break;
                case 300:
                    titulo = "Manager";
                    break;
                case 400:
                    titulo = "Senior Manager";
                    break;
                default:
                    titulo = "Associate";
                    break;
            }

            return titulo;
        }
    }
}
