﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIBarDG.Model.Comanda
{
    public class Comanda
    {
        public int ID { get; set; }
        public List<Item> Item { get; set; }
    }
}
