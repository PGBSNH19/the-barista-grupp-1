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

        public Ingredient(string name, string type, string manufacturer, decimal price, string unit, int amount)
        {
            this.Name = name;
            this.Type = type;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Unit = unit;
            this.Amount = amount;
        }
    }

    public class Bean : Ingredient
    {
        public bool Ecological { get; }
        public bool Fairtrade { get; }
        public string RoastType { get; }

        public Bean(string name, string type, string manufacturer, decimal price, string unit, int amount, bool ecological, bool fairtrade, string roastType) : base(name, type, manufacturer, price, unit, amount)
        {
            this.Ecological = ecological;
            this.Fairtrade = fairtrade;
            this.RoastType = roastType;
        }
    }

    public class Water : Ingredient
    {
        public Water(string name, string type, string manufacturer, decimal price, string unit, int amount) : base(name, type, manufacturer, price, unit, amount) { }
    }

    public class Milk : Ingredient
    {
        public float Fat { get; set; }
        public bool Lactose { get; set; }
        public bool Ecological { get; set; }

        public Milk(string name, string type, string manufacturer, decimal price, string unit, int amount, bool ecological, bool lactose, float fat) : base(name, type, manufacturer, price, unit, amount)
        {
            this.Fat = fat;
            this.Lactose = lactose;
            this.Ecological = ecological;
        }
    }

    public class Flavouring : Ingredient
    {
        public Flavouring(string name, string type, string manufacturer, decimal price, string unit, int amount) : base(name, type, manufacturer, price, unit, amount) { }
    }
}
