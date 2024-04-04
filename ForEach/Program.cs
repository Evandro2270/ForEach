using System;
using System.Globalization;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                int N;
                N = int.Parse(Console.ReadLine());

                string[] vet = new string[N];

                for (int i = 0; i < N; i++)
                {
                    vet[i] = Console.ReadLine();
                }
                /* Console.WriteLine("Nome lidos: ");
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(vet[i]);
                }
                */
                Console.WriteLine("Nome lidos: ");
                foreach (string x in vet)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}