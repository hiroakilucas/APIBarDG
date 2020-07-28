using APIBarDG.Bussines.Comanda;
using APIBarDG.Model.NotaFiscal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class NotaFiscalController
    {

        [HttpPost]
        public NotaFiscal FechamentoComanda(int idComanda)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            ComandaBussines comandaBussines = new ComandaBussines();

            notaFiscal = comandaBussines.FechamentoComanda(idComanda);

            return notaFiscal;
        }

    }
}
