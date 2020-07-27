using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Model.NotaFiscal
{
    public class NotaFiscal
    {
        public List<Item> Item { get; set; }
        public double Desconto { get; set; }
        public double ValorTotal { get; set; }

    }
}
