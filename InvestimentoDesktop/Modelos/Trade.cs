using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestimentoDesktop.Modelos
{
    class Trade
    {
        public int Id { get; set; }
        public string TipoOperacao { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public static int idTrade = 0;

        public Trade()
        {
            idTrade++;
            Id = idTrade;
        }
    }
}
