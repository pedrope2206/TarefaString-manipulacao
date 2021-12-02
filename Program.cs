using System;

namespace TarefaString
{
    class Program
    {
        static void Main(string[] args)
        {

            String nome = "";
            String testo = "";
            String troca;
            String troca1 = "";
            int upper;
            int upper1;

            Console.WriteLine("Olá qual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("         ");
            Console.WriteLine($"Olá {nome} gostaria que me ajudasse com um projeto sobre string");
            Console.WriteLine("         ");
            Console.WriteLine("Faça o seguinte:Digite um texto qualquer");
            testo = Console.ReadLine();

            Console.WriteLine("         ");
            Console.WriteLine("Escreva uma palavra do seu testo para substituir por outra à sua escolha respectivamente:");
            troca = Console.ReadLine();
            troca1 = Console.ReadLine();

            testo = testo.Contains(troca) ? testo.Replace(troca, troca1) : testo.Replace(troca, troca);
            Console.WriteLine("   ");
            Console.WriteLine($"seu testo ficou assim depois da substituição: {testo}");

            Console.WriteLine("Escreva agora um número da sequência de caracteres que você escreveu para passar para uppercase");
            upper = Convert.ToInt16(Console.ReadLine());
            upper1 = Convert.ToInt16(Console.ReadLine());

            testo = testo.Substring(upper, upper1).ToUpper();

            Console.WriteLine("  ");
            Console.WriteLine($"seu testo ficou assim depos do uppercase {testo}");




        }
    }
}
