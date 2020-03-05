using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public int Amount { get; set; }

    }
       public class Bean : Ingredient
    {
        public bool Ecological { get; set; }
        public bool Fairtrade { get; set; }
        public string RoastType { get; set; }

        public Bean()
        {


        }
    }
    public class Water : Ingredient
    {
    }
    public class Milk : Ingredient
    {
        public float Fat { get; set; }
        public bool Lactose { get; set; }
        public bool Ecological { get; set; }
    }
    public class Flavourings : Ingredient
    {

    }

   

}
