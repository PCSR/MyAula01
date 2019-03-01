using System;

namespace Argumentos
{
    /// <summary>
    /// Imprime no ecra os argumentos 
    /// </summary>
    class Program
    {
        /// <summary>
        /// O Programa comeca aqui
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
