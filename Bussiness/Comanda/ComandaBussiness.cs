using APIBarDG.Model;
using APIBarDG.Model.NotaFiscal;
using APIBarDG.Service.ComandaService;
using System;

namespace APIBarDG.Bussiness.Comanda
{
    public class ComandaBussiness : IControlaComanda
    {

        public Model.Comanda.Comanda RegistraItemComanda(Model.Comanda.Comanda comanda, Item item)
        {
            throw new NotImplementedException();
        }

        public NotaFiscal FechamentoComanda(Model.Comanda.Comanda comanda)
        {
            NotaFiscal notaFiscal = new NotaFiscal();

            return notaFiscal;
        }


        public void LimpaComanda(int id)
        {
            throw new NotImplementedException();
        }
    }
}
