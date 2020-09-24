using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a cotação do dolar é: " + Dolar.dolar.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Quantos dolares deseja comprar:");
            double real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double convertido = Dolar.conversor(real);

            Console.WriteLine("Preço total a pagar:" + convertido.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
