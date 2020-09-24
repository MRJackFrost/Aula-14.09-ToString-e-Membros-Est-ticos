using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ProdutoEstoque
{
    public class Produto
    {
        public string prodname;
        public double prodprice;
        public int prodstock;
        public double FullPrice()
        {
            double full = prodprice * prodstock;
            return full;
        }
        public void Adicionar(int quantidade){
            prodstock += quantidade;
        }

        public void Remover(int quantidade)
        {
            prodstock -= quantidade;
        }
        public override string ToString()
        {
            return "Dados do produto: " + prodname + ", preço: R$" + prodprice.ToString("F2", CultureInfo.InvariantCulture)+", estoque: "+prodstock+" preço total : R$"+FullPrice();
            
        }

    }
}
