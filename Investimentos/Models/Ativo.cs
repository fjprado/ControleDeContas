using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Investimentos.Models
{
    public class Ativo
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Sigla { get; set; }
        public string Empresa { get; set; }
        public double ValorInvestido { get; set; }

        public static int idAtivo = 0;

        public Ativo()
        {
            idAtivo++;
            Id = idAtivo;
            ValorInvestido = 0;
        }
    }
}
