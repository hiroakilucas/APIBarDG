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
 
        //private readonly InventoryContext _context;

        //public ComandaController(InventoryContext context)
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
        public async Comanda SetComanda(Comanda comanda)
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
    }
}
