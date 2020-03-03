using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    class Milk : IIngredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public float Fat { get; set; }
        public bool Lactose { get; set; }
        public bool Ecological { get; set; }
    }
}
