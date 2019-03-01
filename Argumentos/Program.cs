using System;

namespace Argumentos
{
    /// <summary>
    /// Imprime no ecra os argumentos 
    /// </summary>
    class Program
    {
        /// <summary>
        /// O programa comeca aqui
        /// </summary>
        static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
