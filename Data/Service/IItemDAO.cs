using APIBarDG.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Data.Service
{
    public interface IItemDAO
    {

        Item getItem(string nomeItem);
    }
}
