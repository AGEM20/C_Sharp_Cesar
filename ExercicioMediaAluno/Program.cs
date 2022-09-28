namespace ExercicioMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media, exame;

            Console.WriteLine("Digite a Primeira Nota :");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Segunda Nota :");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Terceira Nota :");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Quarta Nota :");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovando ");
            }
            else
            {
                Console.WriteLine("Digite a Nota do Exame !!");
                exame = Convert.ToDouble(Console.ReadLine());
                media = (media + exame) / 2;

                if (media >= 5)
                Console.WriteLine("Aluno Aprovando");
            
                else
                {
                    Console.WriteLine("Aluno Reprovando ");
                }
            }            
            Console.ReadKey();
        }
    }
}
