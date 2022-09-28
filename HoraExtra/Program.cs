using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace CalculoSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double HoraNormal = 10.00, HoraExtra = 15.00, QtdNormal=0, QtdExtra = 0, SalarioLiquido =0, SalarioBruto =0;

            Console.WriteLine("Informe a Quantidade de Horas normais Trabalhada :");
            QtdNormal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a Quantidade de Horas Extra Trabalhada :");
            QtdExtra = Convert.ToDouble(Console.ReadLine());

            QtdNormal += QtdNormal * HoraNormal;
            QtdExtra += QtdExtra * HoraExtra;

            SalarioBruto = QtdNormal + QtdExtra;
            Console.WriteLine("O Salario Bruto é :", SalarioBruto.ToString());
            Console.WriteLine(SalarioBruto.ToString());

            SalarioLiquido = SalarioLiquido + ( SalarioBruto * 0.9);
                      
            Console.WriteLine("O Salario Liguindo é :",SalarioLiquido.ToString());
            Console.WriteLine(SalarioLiquido.ToString());

            Console.ReadKey();

        }

    }
             
    
}


