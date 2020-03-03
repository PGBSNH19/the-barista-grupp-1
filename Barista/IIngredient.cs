using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    interface IIngredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }

    }
}
