namespace IdadeDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, numDias;

            Console.WriteLine("Informe a sua idade:");

            idade = Convert.ToInt32(Console.ReadLine());

            numDias = idade * 365;
                                
            Console.WriteLine("Voce viveu mais de {0} dias : ",numDias);
            Console.ReadKey();
        }
    }
}