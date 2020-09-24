using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    class Dolar
    {
        public static double dolar = 3.10;
        public static double iof = 6;

        public static double conversor(double reais){
            reais = reais * dolar;
            double calc = reais * iof / 100;
            reais = reais + calc;
            return reais;
        }
    }
}
