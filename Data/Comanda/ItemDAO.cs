using APIBarDG.Data.Service;
using APIBarDG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Data.Comanda
{
    public class ItemDAO : IItemDAO
    {
        public Item getItem(string nomeItem)
        {
            Item item = new Item();

            using (var db = new ItemContext())
            {
                var itens = db.Item
                  .Where(b => b.Nome == nomeItem).FirstOrDefault();

                item.ID = itens.ID;
                item.Nome = itens.Nome;
                item.Preco = itens.Preco;
            }

            return item;
        }
    }
}
