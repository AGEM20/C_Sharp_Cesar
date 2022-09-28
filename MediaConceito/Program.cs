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

            if (media >= 9.0 && media >= 10)
            {
                Console.WriteLine("Conceito A, Aluno aprovado Aprovando ");
            }
            if (media >= 7.0 && media < 8.9)
                {
                Console.WriteLine("Conceito B, Aluno aprovado Aprovando ");
            }
            if (media >= 5.0 && media < 6.9)
            {
                Console.WriteLine("Conceito C, Aluno aprovado Aprovando ");
            }
            if (media >= 2.0 && media < 4.9)
            {
                Console.WriteLine("Conceito D, Aluno aprovado Em Recuperação ");
            }
            if (media >= 0.0 && media < 1.9)
            {
                Console.WriteLine("Conceito E, Aluno aprovado  Reprovado");
            }
                          
            Console.ReadKey();
        }
    }
}
