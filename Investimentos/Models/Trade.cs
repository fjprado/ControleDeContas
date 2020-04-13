using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investimentos.Models
{
    public class Trade
    {
        public int Id { get; private set; }
        public int AtivoId { get; set; }
        public virtual Ativo Ativo { get; set; }
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
