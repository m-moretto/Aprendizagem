// See https://aka.ms/new-console-template for more information
using Aprendizagem.ExerciciosLogica;

/*
//Teste da classe Interpolação_desafioMSLearn  ###Pendente###
Console.WriteLine("Teste da classe Interpolação_desafioMSLearn.................................");

var interpolacao = new Interpolacao_desafioMSLearn();

Console.WriteLine($@"View English output:
        c:\Exercise\{interpolacao.NomeDoProjetoEmIngles()}\data.txt
        ");

Console.WriteLine($@"{interpolacao.NomeDoProjetoEmRusso()}
        c:\Exercise\{interpolacao.NomeDoProjetoEmIngles()}\ru-RU\data.txt");

Cosole.WriteLine();
*/


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


/*
//Teste da classe JogoDeDados  ###Pendente###
Console.WriteLine("Teste da classe JogoDeDados.................................................");

Console.WriteLine("Qual o número de dados será arremessado? ");
int numeroDeDados = Console.Read();

var jogoDeDados = new JogoDeDados();

Console.WriteLine($"Foram arremessados " + numeroDeDados + " dados e a soma dos resultados foi " + jogoDeDados.ArremessarDados(numeroDeDados) + ".");
*/

/*
//Teste da classe AvisoRenovacaoAssinatura  ###Pendente###
Console.WriteLine("Teste da classe AvisoRenovacaoAssinatura....................................");
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
var avisoRenovacaoAssinatura = new AvisoRenovacaoAssinatura(daysUntilExpiration);
*/
