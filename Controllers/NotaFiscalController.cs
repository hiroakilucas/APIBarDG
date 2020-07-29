using APIBarDG.Bussines.Comanda;
using APIBarDG.Model.NotaFiscal;
using APIBarDG.Service.ComandaService;
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

        private readonly IControlaComanda _controlaComanda;

        public NotaFiscalController( IControlaComanda controlaComanda)
        {
            _controlaComanda = controlaComanda;
        }

        [HttpPost]
        public NotaFiscal FechamentoComanda(int idComanda)
        {
            NotaFiscal notaFiscal = new NotaFiscal();
            _controlaComanda.FechamentoComanda(idComanda);

            return notaFiscal;
        }

    }
}
