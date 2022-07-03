using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*Objetivo: Comparar as instruções "if-elseif-else" e "switch-case"
 * 
 *Método que recebe o SKU (Stock Keeping Unit = Unidade Mantida em Estoque) dos produtos e
 *retorna a descrição completa do produto.
 */


namespace Aprendizagem.ExerciciosLogica
{
    public class ConversaoSkuDescricaoProduto
    {
        public string DescreverProduto(string sku)
        {
            string skuUpper = sku.ToUpper();

            string[] produto = skuUpper.Split('-');

            string tipo = "";
            string cor = "";
            string tamanho = "";

            switch (produto[0])
            {
                case "01":
                    tipo = "Suéter";
                    break;
                case "1":
                    tipo = "Suéter";
                    break;
                case "02":
                    tipo = "Camiseta";
                    break;
                case "2":
                    tipo = "Camiseta";
                    break;
                case "03":
                    tipo = "Calça de moletom";
                    break;
                case "3":
                    tipo = "Calça de moletom";
                    break;
                default:
                    tipo = "outro";
                    break;
            }

            switch (produto[1])
            {
                case "PT":
                    cor = "Preto";
                    break;
                case "MN":
                    cor = "Marron";
                    break;
                case "BC":
                    cor = "Branco";
                    break;
                default:
                    cor = "cor não identificada";
                    break;
            }

            switch (produto[2])
            {
                case "P":
                    tamanho = "Pequeno";
                    break;
                case "M":
                    tamanho = "Médio";
                    break;
                case "G":
                    tamanho = "Grande";
                    break;
                default:
                    tamanho = "tamanho único";
                    break;
            }

            return ($"Produto: {tipo} {cor} {tamanho}");
        }
    }
}

/* Código original em "if-elseif-else"

 // SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
 */


