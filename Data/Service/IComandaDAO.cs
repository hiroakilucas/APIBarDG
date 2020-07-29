using APIBarDG.Model;
using APIBarDG.Model.Comanda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Data.Service
{
    public interface IComandaDAO
    {

        Model.Comanda.Comanda getComanda(int idComanda);
        Model.Comanda.Comanda cadastraComanda(int idComanda, List<Item> item);

        //Model.Comanda.Comanda registraItem(nomeItem);

        //public limpaComanda(idComanda);
    }
}
