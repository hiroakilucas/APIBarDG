using APIBarDG.Data.Service;
using APIBarDG.Model;
using APIBarDG.Model.Comanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Data.Comanda
{
    public partial class ComandaDAO : IComandaDAO
    {
      

        //public getComanda(int idComanda)
        public Model.Comanda.Comanda getComanda(int idComanda)
        {

            Model.Comanda.Comanda comanda =  new Model.Comanda.Comanda();

            using (var db = new ComandaContext())
            {

                var dbcomanda = db.Comanda
                    .Where(b => b.ID == idComanda).FirstOrDefault();
                  //.Where(b => b.ID == idComanda).ToList();

                comanda = dbcomanda;
            }

            return comanda;
        }
        public Model.Comanda.Comanda cadastraComanda(int idComanda, List<Item> itens)
        {

            Model.Comanda.Comanda comanda = new Model.Comanda.Comanda();

            using (var db = new ComandaContext())
            {
                db.Add(new Model.Comanda.Comanda { ID = idComanda, Itens = itens, PromocaoAguaPedidos = 0 , PromocaoAguaRestantes = 0});
                db.SaveChanges();

                var dbcomanda = db.Comanda
                  .Where(b => b.ID == idComanda).FirstOrDefault();

                comanda = dbcomanda;
            }
            return comanda;
        }

    }
}
