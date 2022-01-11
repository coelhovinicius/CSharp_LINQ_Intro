/* LINQ - Language Integrated Query */

/*>>> PROGRAMA PRINCIPAL <<< */
using System;
using System.Linq; // Necessario para utilizar o LINQ

namespace Aula226_LINQ_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Source
            int[] numbers = new int[] { 2, 3, 4, 5 }; // Vetor de numeros inteiros

            // Expressao para consulta - Query
            var result = numbers // Tipo IEnumerable
                .Where(x => x % 2 == 0) // Onde o numero for par - Expressao Lambda direto na linha
                .Select(x => x * 10); // Seleciona esse numero e multiplica por 10 - Outra expressao Lambda em linha

            // Executar a consulta - Query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}
