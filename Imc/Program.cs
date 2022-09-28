namespace Imc
{
    class Program
    {
        static void Main(string[] args)
        {
            double total, altura, peso;

            Console.WriteLine("Calcular IMC");
            Console.Write("De quantas pessoas desejar relalizar o calculo");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} Pessoa:");

                Console.WriteLine();

                Console.Write("Insira o Peso: ");

                peso = double.Parse(Console.ReadLine());

                Console.Write("Insira a Altura:");

                altura = double.Parse(Console.ReadLine());

                total = peso/(altura * altura);

                Console.WriteLine("Total:" + total.ToString("F2"));

                if (total<18.5)
                    Console.WriteLine("abaixo do peso normal");

                if (total >= 18.5 && total < 24.9)
                    Console.WriteLine("peso normal");

                if (total >= 24.9 && total <30)
                    Console.WriteLine("peso acima do normal");
                if (total >= 30)
                    Console.WriteLine("peso excessivo");
            }
        }
    }
}
