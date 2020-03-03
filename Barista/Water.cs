﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    class Water : IIngredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
    }
}
