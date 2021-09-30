using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_20_desafio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PARCELAMENTO:
            Console.WriteLine("Digite a data do primeiro vencimento");  
            DateTime data = DateTime.Parse(Console.ReadLine());
            DateTime dataLimite = DateTime.Parse("25/09/2021");
            if(data < dataLimite)
            {
                Console.WriteLine("Essa data não é válida\n");
                goto PARCELAMENTO;
            }
            Console.WriteLine("Quantas parcelas são?: ");
            int parc = int.Parse(Console.ReadLine());


            int c;

            for (c = 1; c <= parc; c++)
            {
            Console.WriteLine("\nData de vencimento número " + c.ToString("00") + ": " + data.ToString("dd/MM/yyyy"));
            data = data.AddMonths(1);
            }
            

            Console.ReadKey();
        }
    }
}
