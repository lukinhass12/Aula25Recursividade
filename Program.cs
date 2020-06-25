using System;

namespace Aula25Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade fibo = new Recursividade();
            fibo.SequenciaFibonacci(0,1,30);
            System.Console.WriteLine(fibo.SequenciaFibonacci(5));
        }
            
    }
}
