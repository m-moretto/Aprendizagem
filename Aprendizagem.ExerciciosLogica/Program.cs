// See https://aka.ms/new-console-template for more information
using Aprendizagem.ExerciciosLogica;
using System.Globalization;
using System.Text;
using Aprendizagem.ExerciciosLogica.Enums;

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


/*
//Teste da classe CaraOuCoroa  ###OK###
Console.WriteLine("Aperte ENTER para arremessar a moeda:");

while (Console.ReadKey().Key != ConsoleKey.Enter)
{
    Console.WriteLine("->tecla errada:  Tem que apertar ENTER!!");
    continue;
}
if (Console.ReadKey().Key == ConsoleKey.Enter)
{
    CaraOuCoroa caraOuCoroa = new CaraOuCoroa();
    Console.WriteLine(caraOuCoroa.Resultado());
}
*/


/*
//Teste da classe VerificacaoDeAcesso  ###TODO###
int nivelDeAcesso = 0;
int codigoDeAcesso = 0;
while (nivelDeAcesso !=1 || nivelDeAcesso!=2 || nivelDeAcesso !=3 || nivelDeAcesso !=4 || nivelDeAcesso !=5)
{
    Console.WriteLine(@"Selecione seu nível de acesso:
                    1-Usuário
                    2-Coordenador
                    3-Gerente
                    4-Administrador do sistema
                    5-Super usuário");
}
nivelDeAcesso = Console.Read();
//metodo de verificação de nivel na classe VerificacaoDeAcesso

Console.WriteLine(@"Entre com seu código de acesso:
[Obs: seu código de acesso deve conter 3 números, exemplo: 001, 123 ou 100");
codigoDeAcesso = Console.Read();
//metodo de verificação de código de acesso na classe VerificacaoDeAcesso

//retorno com menssagem de liberação ou não de acesso
*/


/*
//Teste da classe ConversaoSkuDescricaoProduto  ###OK###
Console.WriteLine("Teste da classe ConversaoSkuDescricaoProduto................................");

string sku = "3-MN-g";

var conversaoSkuDescricaoProduto = new ConversaoSkuDescricaoProduto();

string descriçãoDoProduto = conversaoSkuDescricaoProduto.DescreverProduto(sku);

Console.WriteLine(descriçãoDoProduto);
*/

/*
//Teste da classe ConversaoSkuDescricaoProduto  ###OK###
Console.WriteLine("Teste da classe CorrespondeciaNivelCargo.................................");

int nivelDoFuncionario = 200;
string nomeDoFuncionario = "John Smith";

var correspondeciaNivelCargo = new CorrespondenciaNivelCargo();

var descricaoDeCargo = correspondeciaNivelCargo.ObterNivel(nivelDoFuncionario);

Console.WriteLine($"Descrição de cargo: {nomeDoFuncionario}, {descricaoDeCargo}");
*/


//Teste da classe NomeProjetoVariasLinguagens  ###OK###
Console.WriteLine("Teste da classe NomeProjetoVariasLinguagens.................................");
Console.WriteLine();

var nomeProjeto = new NomeProjetoVariasLinguagens();

Console.WriteLine($@"View English output:
        c:\Exercise\{nomeProjeto.ProjetoIngles()}\data.txt
        ");

//Thread.CurrentThread.CurrentCulture = new CultureInfo("ru-RU");
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine($@"{nomeProjeto.ProjetoRusso()}
        c:\Exercise\{nomeProjeto.ProjetoIngles()}\ru-RU\data.txt
        ");

Console.WriteLine($@"{nomeProjeto.ProjetoUE(Aprendizagem.ExerciciosLogica.Enums.Linguagem.Frances)}
        c:\Exercise\{nomeProjeto.ProjetoIngles()}\fr-FR\data.txt
        ");

Console.WriteLine($@"{nomeProjeto.ProjetoUE(Linguagem.Italiano)}
        c:\Exercise\{nomeProjeto.ProjetoIngles()}\it-IT\data.txt
        ");

Console.WriteLine($@"{nomeProjeto.ProjetoUE(Linguagem.Espanhol)}
        c:\Exercise\{nomeProjeto.ProjetoIngles()}\es-ES\data.txt
        ");

