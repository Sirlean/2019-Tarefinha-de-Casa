using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirlean.Projeto001.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome!");
            var entrada = Console.ReadLine();
            string texto = FormatarEntrada(entrada);
            Console.WriteLine(texto);
            Console.Read();
        }

        private static string FormatarEntrada(string entrada)
        {
            return string.Format("Seu nome é: {0}.", entrada);
        }
    }
}
