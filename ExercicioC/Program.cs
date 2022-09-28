namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, maior = 0;

            Console.WriteLine("Informe o Primeiro Valor :");
            n = Convert.ToInt32(Console.ReadLine());
            maior = n;

            Console.WriteLine("Informe o Segundo Valor :");
            n = Convert.ToInt32(Console.ReadLine());
            if(n > maior)
            {
                maior = n;
            }

            Console.WriteLine("Informe o Terceiro Valor :");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
            }

            Console.WriteLine("Informe o Quarto Valor :");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
            }

            Console.WriteLine("Informe o Quinto Valor :");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > maior)
            {
                maior = n;
            }
            Console.WriteLine("O Maio Valor Informado é :" +maior);
            Console.ReadKey();
        }
    }
}
