using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace macas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a Quantidade de macas que deseja adquirir:");
            int QtdMacas = int.Parse(Console.ReadLine());
            
            double totalCompra = 0;
            double valorUnitario = 0;
          
            if (QtdMacas <= 12)
            {
                valorUnitario = 1.30;                          
            }
            else
            {
                valorUnitario = 1;
            }

            totalCompra = QtdMacas * valorUnitario;
            
            Console.WriteLine("Valor Total: ", totalCompra.ToString());
            Console.WriteLine(totalCompra.ToString());
            Console.ReadKey();
        }
    }
}
