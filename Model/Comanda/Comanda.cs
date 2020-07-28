using System.Collections.Generic;
using System.Security.Policy;

namespace APIBarDG.Model.Comanda
{
    public class Comanda
    {
        public int ID { get; set; }
        public List<Item> Itens { get; set; }

        public double PromocaoAguaPedidos { get; set; }
        public double PromocaoAguaRestantes { get; set; }
    }
}
