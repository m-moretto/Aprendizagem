// See https://aka.ms/new-console-template for more information
using Aprendizagem.ExerciciosLogica;
using System.Globalization;
using System.Text;


//Teste da classe Interpolação_desafioMSLearn  ###OK###
Console.WriteLine("Teste da classe Interpolação_desafioMSLearn.................................");

var interpolacao = new Interpolacao_desafioMSLearn();

Console.WriteLine($@"View English output:
        c:\Exercise\{interpolacao.ObterNomeDoProjetoEmIngles()}\data.txt
        ");

//Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine($@"{interpolacao.ObterNomeDoProjetoEmRusso()}
        c:\Exercise\{interpolacao.ObterNomeDoProjetoEmIngles()}\ru-RU\data.txt");

Console.WriteLine();


/*
//Teste da classe ConversaoTemperatura ###OK###
Console.WriteLine("Teste da classe ConversaoTemperatura........................................");

Console.Write("Coloque a temperatura em fahrenheit: ");
decimal fahrenheit = Console.Read();

var conversaoTemperatura = new ConversaoTemperatura();

decimal celsius = conversaoTemperatura.FahrenheitParaCelsius(fahrenheit);
Console.WriteLine($@"A temperatura é " + string.Format("{0:0.00}",celsius) + " Celsius.");

var kelvin = conversaoTemperatura.FahrenheitParaKelvin(fahrenheit);
Console.WriteLine($@"A temperatura é " + string.Format("{0:0.00}", kelvin) + " Kelvin.");

Console.WriteLine();
*/

/*
//Teste da classe JogoDeDados  ###OK###
Console.WriteLine("Teste da classe JogoDeDados.................................................");

var jogoDeDados = new JogoDeDados();

Console.WriteLine("Qual o número de dados será arremessado? ");
int numeroDeDados = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Foram arremessados {numeroDeDados} dados e a soma dos resultados foi " + jogoDeDados.ArremessarDados(numeroDeDados) + ".");

int[] resultadoDeCadaArremesso = new int[numeroDeDados];
resultadoDeCadaArremesso = jogoDeDados.ResultadoDeCadaArremesso(numeroDeDados);

for (int i = 0; i < numeroDeDados; i++)
{
    Console.WriteLine($"O dado {i+1} retornou o valor {resultadoDeCadaArremesso[i]}");
}
*/

/*
//Teste da classe AvisoRenovacaoAssinatura  ###Pendente###TODO
Console.WriteLine("Teste da classe AvisoRenovacaoAssinatura....................................");
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
var avisoRenovacaoAssinatura = new AvisoRenovacaoAssinatura(daysUntilExpiration);
*/
