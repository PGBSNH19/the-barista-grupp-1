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
    class Water : IIngredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
    }
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
    class Flavourings : IIngredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }

    }
}
