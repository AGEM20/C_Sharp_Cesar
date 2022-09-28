using System;

namespace MediaVetor
{
    class Program
    {
        static void Main(String[] args)
        {
            double[] valor = new double[3];

            for (int i = 0; i < valor.Length; i++)
            {
                Console.WriteLine("Insira o " + (i+1)+ "ª valor");
                valor[i] = double.Parse(Console.ReadLine());
            }

            double soma = 0;

            for(int i = 0; i < valor.Length; i++)
            {
                soma +=valor[i];
            }

            Console.WriteLine("A Média é:" + (soma / valor.Length));
        }
        
    }
    
}



