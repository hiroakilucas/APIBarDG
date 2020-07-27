using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIBarDG.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace APIBarDG.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ComandaController : ControllerBase
    {

        //private readonly ComandaDAO _context;

        //public ComandaController(ComandaDAO context)
        //{
        //    _context = context;
        //}

        [HttpGet("{id}")]
        public Comanda Get(int id)
        {
            Comanda Comanda = new Comanda(); 
            Item Item = new Item();

            Item.ID = 1;
            Item.Nome = "Banana";
            Item.Preco = 1.1;
            Comanda.ID = 1;
            Comanda.Item = Item;

            return Comanda;
        }

        [HttpPost]
        //public async Comanda SetComanda(Comanda comanda)
        public Comanda SetComanda(Comanda comanda)
        {

            Comanda Comanda = new Comanda();
            //Item Item = new Item();

            //Item.ID = 1;
            //Item.Nome = "Banana";
            //Item.Preco = 1.1;
            //Comanda.ID = 1;
            //Comanda.Item = Item;

            //_context.Comanda.Add(Comanda);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetComanda", new { id = comanda.ID }, comanda);

            return Comanda;

        }

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
