using System; 

namespace Aula25Recursividade
{
    public class Recursividade
    {
        public void SequenciaFibonacci(int num1, int num2, int vezes){
            if(vezes > 0){
                System.Console.WriteLine(num1);
                SequenciaFibonacci(num2, num1 + num2, vezes - 1);
            }


        }
        public int Fatorial(int numero){
            if(numero == 1){
                return 1;
            }else{
                return numero = Fatorial( numero - 1);
            }

        }

    }
}