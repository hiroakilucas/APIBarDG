using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBarDG.Bussines.Comanda;
using APIBarDG.Data;
using APIBarDG.Model;
using APIBarDG.Model.Comanda;
using APIBarDG.Model.NotaFiscal;
using APIBarDG.Service.ComandaService;
using APIBarDG.Util.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace APIBarDG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ComandaController : ControllerBase
    {

        private readonly ComandaContext _context;
        private readonly IControlaComanda _controlaComanda;
        
        public ComandaController(ComandaContext context, IControlaComanda controlaComanda)
        {
            _context = context;
            _controlaComanda = controlaComanda;
        }

        //[HttpGet]
        //[Route("ObterComanda")]
        //public Comanda GetComanda(int id)
        //{

        //    //return await _context.Comanda;
        //    Comanda Comanda = new Comanda();
        //    Comanda.Itens = new List<Item>();
        //    Item Item = new Item();

        //    using (var db = new ItemContext())
        //    {
        //        //db.Add(new Item { ID = 1, Nome = "cerveja", Preco = 5.00 });
        //        //db.Add(new Item { ID = 2, Nome = "conhaque", Preco = 20.00 });
        //        //db.Add(new Item { ID = 3, Nome = "suco", Preco = 50.00 });
        //        //db.Add(new Item { ID = 4, Nome = "agua", Preco = 70.00 });
        //        //db.SaveChanges();

        //        var itens = db.Item
        //          .Where(b => b.ID == id).FirstOrDefault();                  

        //        Item.ID = itens.ID;
        //        Item.Nome = itens.Nome;
        //        Item.Preco = itens.Preco;

        //        Comanda.Itens.Add(Item);
        //    }

        //    return Comanda;
        //}

        [HttpPost]
        [Route("AdicionaItemComanda")]
        public Comanda RegistraItemComanda(int idComanda, string nomeItem)
        {
            Comanda comanda = new Comanda();
            comanda.Itens = new List<Item>();

            _controlaComanda.RegistraItemComanda(idComanda, nomeItem);

            return comanda;
        }

        

        //[HttpPost]
        //public Comanda LimpaComanda(int idComanda)
        //{
        //    Comanda comanda = new Comanda();
        //    ComandaBussines comandaBussines = new ComandaBussines();

        //    comanda = comandaBussines.LimpaComanda(idComanda);

        //    return comanda;
        //}


        // DELETE: api/Products/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Comanda>> DeleteItem(int id)
        //{
        //var comanda = await _context.Comanda.FindAsync(id);
        //if (products == null)
        //{
        //    return NotFound();
        //}

        //_context.Products.Remove(products);
        //await _context.SaveChangesAsync();

        //    return comanda;
        //}

        //private bool ItemExists(int id)
        //{
        //    return _context.Comanda.Any(e => e.ID == id);
        //}
    }
}
