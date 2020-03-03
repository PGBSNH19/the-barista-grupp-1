using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    class Bean : IIngredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }

        public bool Ecological { get; set; }
        public bool Fairtrade { get; set; }
        public string RoastType { get; set; }

        public Bean()
        {

        }
    }
}
