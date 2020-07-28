using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBarDG.Bussines.Comanda;
using APIBarDG.Model;
using APIBarDG.Model.Comanda;
using APIBarDG.Model.NotaFiscal;
using APIBarDG.Util.Enum;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Extensions.Logging;

namespace APIBarDG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ComandaController : ControllerBase
    {        

        [HttpGet("{id}")]
        public Comanda GetComanda(int id)
        {
            Comanda Comanda = new Comanda(); 
            Item Item = new Item();

            return Comanda;
        }

        [HttpPost]
        //public async Comanda SetComanda(Comanda comanda)
        public Comanda RegistraItemComanda(int idComanda, string nomeItem)
        {

            Comanda comanda = new Comanda();
            comanda.Itens = new List<Item>();

            ComandaBussines comandaBussines = new ComandaBussines();

            comandaBussines.RegistraItemComanda(idComanda, nomeItem);

            Item item = new Item();

            item.ID = 1;
            item.Nome = "Banana";
            item.Preco = 1.1;

            comanda.Itens.Add(item);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetComanda", new { id = comanda.ID }, comanda);

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
