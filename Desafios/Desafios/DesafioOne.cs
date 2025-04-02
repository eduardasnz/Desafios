

using System.Text.RegularExpressions;

namespace Desafios.Desafios;
internal class DesafioOne
{
    public void MessageWelcome()
    {
        Console.Write("Qual seu nome?: ");
        var name = Console.ReadLine();
        Console.WriteLine("olá "+name+", seja muito bem-vinda!");
        
    }
    public void NomeCompleto()
    {
        Console.Write("Qual seu nome?: ");
        var name = Console.ReadLine();
        Console.Write("E seu sobrenome?: ");
        var sobrename = Console.ReadLine();

        var nomeCompleto = name + " " + sobrename;

        Console.WriteLine(nomeCompleto);
        
    }
        
    public void Matematica(double valor1 = 1.9,double valor2 = 2.2)
    {
        Console.WriteLine("Operaçoes com 1.9 e 2.2");

        var soma = valor1 + valor2;
        var sub = valor1 - valor2;
        var multi = valor2 * valor1;
        var div = valor1 / valor2;
        var media = (valor1 + valor2) / 2;

        Console.WriteLine("soma: "+soma);
        Console.WriteLine("sub: "+sub);
        Console.WriteLine("multi: "+multi);
        Console.WriteLine("div: "+div);
        Console.WriteLine("media: "+media);
        
    }

    public void TamanhoDaPalavra()
    {
        Console.Write("Digite uma palavra: ");
        var resposta = Console.ReadLine();

        if(resposta != null)
        {
            int tamanho = resposta.Length;
            Console.WriteLine($"sua palavra tem {tamanho} letras.");
        } else
        {
            Console.WriteLine("voce nao digitou nada");
        }

    }

    public void PlacaDeCarro()
    {
        /*
         * - A placa deve ter 7 caracteres alfanuméricos;
        - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
        - Os quatro últimos caracteres são números;
         */
        Console.WriteLine("Informe a placa do seu carro.");
        var placa = Console.ReadLine();

        if (VerificarPlaca(placa))
        {
            Console.WriteLine("Placa válida");
        } else
        {
            Console.WriteLine("Placa inválida");
        }

    }
    
    static bool VerificarPlaca(string placa)
    {
        // Expressão regular para o padrão brasileiro válido até 2018
        string padrao = @"^[A-Za-z]{3}[0-9]{4}$";

        return Regex.IsMatch(placa, padrao);
    }
}
