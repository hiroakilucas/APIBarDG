using APIBarDG.Model.Comanda;
using APIBarDG.Model.NotaFiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Service.ComandaService
{
    interface INotaFiscal
    {
        NotaFiscal GerarNotaFiscal(Comanda comanda);

    }
}
