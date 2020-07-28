using APIBarDG.Model;
using APIBarDG.Model.Comanda;
using APIBarDG.Model.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Service.ComandaService
{
    interface IControlaComanda
    {

        Comanda RegistraItemComanda(int idComanda, string nomeItem);
        NotaFiscal FechamentoComanda(int comanda);
        Comanda LimpaComanda(int id);

    }
}
