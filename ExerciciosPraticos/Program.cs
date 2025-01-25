
using System.Globalization;

internal class Program
{
    public static void Main(string[] args)
    {
         Console.Write("Olá. Por favor digite o seu nome: ");
         string? nome = Console.ReadLine();
         
         Console.WriteLine($"Olá, {nome}. Seja muito bem-vindo(a).");
         Console.Write("Por favor, agora digite o seu sobrenome: ");
         string? sobrenome = Console.ReadLine();
         
         Console.Clear();
         Console.WriteLine($"Seu nome completo é {nome} {sobrenome}. Vamos começar?");
         
         Console.ReadKey();
         Console.Clear();
         
         Console.Write("Insira um número qualquer: ");
         double num1 = double.Parse(Console.ReadLine() ?? string.Empty);
         Console.Write("Agora insira outro número: ");
         double num2 = double.Parse(Console.ReadLine() ?? string.Empty);
         
         Console.WriteLine("\nVou te mostrar algumas operações com os números que inseriu.");
         Console.ReadKey();
         Console.Clear();
         Console.WriteLine($"{num1} + {num2} = {Soma(num1, num2)}");
         Console.WriteLine($"{num1} - {num2} = {Subtracao(num1, num2)}");
         Console.WriteLine($"{num1} * {num2} = {Multiplicacao(num1, num2)}");
         if(num2 != 0)
            Console.WriteLine($"{num1} / {num2} = {Divisao(num1, num2)}");
         else
             Console.WriteLine("O denominador da divisão não pode ser 0.");
         Console.WriteLine($"A média entre {num1} e {num2} é igual a {Media(num1, num2)}");
         
         Console.ReadKey();
         Console.WriteLine($"Agora vamos brincar com frases.");
         
         Console.ReadKey();
         Console.Clear();
         
         Console.Write("Digite uma frase qualquer: ");
         string? frase = Console.ReadLine();
         Console.WriteLine($"O número de caracteres na frase \"{frase}\" é {ContarCaracteres(frase)}.");
         
         Console.ReadKey();
         Console.WriteLine($"Agora vamos validar uma placa.");
         
         Console.ReadKey();
         Console.Clear();

         Console.Write("Digite uma placa de carro: ");
         string? placa = Console.ReadLine();
         
         if (VerificarPlaca(placa))
             Console.WriteLine($"{placa} representa uma placa.");
         else
             Console.WriteLine($"{placa} não representa uma placa.");
         
         Console.ReadKey();
         Console.WriteLine($"Pronto! Agora pra encerrar, vamos trabalhar com datas.");
         
         Console.ReadKey();
         Console.Clear();

         Console.WriteLine("Formatos para a data:");
         Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
         Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\".");
         Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
         Console.WriteLine("4 - A data com o mês por extenso.");

         Console.Write("Escolha sua opção: ");
         string? opcao = Console.ReadLine();

         switch (opcao)
         { 
           case "1":
               Console.Clear();
               Console.WriteLine("Hoje é " 
                                 + DateTime.Now.ToString("F", new CultureInfo("pt-BR")) + ".");
               break;
           case "2":
               Console.Clear();
               Console.WriteLine("Hoje é " 
                                 + DateTime.Now.ToString("d", new CultureInfo("pt-BR")) + ".") ;
               break;
           case "3":
               Console.Clear();
               Console.WriteLine("Agora é " 
                                 + DateTime.Now.ToString("t", new CultureInfo("pt-BR")) + ".") ;
               break;
           case "4":
               Console.Clear();
               Console.WriteLine("Hoje é " 
                                 + DateTime.Now.ToString("dd MMMM, yyyy", new CultureInfo("pt-BR")) + ".") ;
               break;
           
           default:
               Console.WriteLine("Opção Inválida!");
               break;
         }
         
         Console.ReadKey();
         Console.WriteLine($"{nome} {sobrenome}, muito obrigado por usar o meu programa. Até a próxima!");
         Console.ReadKey();

    } 
    static double Soma(double num1, double num2) => num1 + num2;
    static double Subtracao(double num1, double num2) => num1 - num2;
    static double Multiplicacao(double num1, double num2) => num1 * num2;
    static double Divisao(double num1, double num2) => num1 / num2;
    static double Media(double num1, double num2) => (num1 + num2) / 2;

    static int ContarCaracteres(string? frase)
    {
        if (frase is null) return 0;

        var cont = 0;

        foreach (var caracter in frase)
        {
            if(caracter.Equals(' ')) continue;
            cont++;
        }

        return cont;
    }

    static bool VerificarPlaca(string? placa)
    {
        if (placa is null || placa.Length != 7) return false;

        var letras = placa.Substring(0, 3);
        foreach (var letra in letras)
        {
            if (!char.IsLetter(letra)) return false;
        }

        var numeros = placa.Substring(3, 4);
        foreach (var numero in numeros)
        {
            if (!char.IsDigit(numero)) return false;
        }

        return true;
    }
}

