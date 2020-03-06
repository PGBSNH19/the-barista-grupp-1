using System;
using System.Collections.Generic;
using System.Linq;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {

            Coffee c = CoffeeMachine.Start()
                .AddBean((Bean)Ingredients.First(i => i.Name == "Mellan Rost"), 10)
                .AddWater((Water)Ingredients.First(i => i.Name == "Loka Citron"), 10)
                .GetCoffee();

            foreach (var item in c.Ingredients.Select(i => i.Name))
            {
                Console.WriteLine(item);
            }

            Coffee espresso = CoffeeMachine.Start().MakeEspresso();

            foreach(var item in espresso.Ingredients)
            {
                Console.WriteLine(item.Amount);
               
            }

        }
        public static void Start()
        {
           
        }



        public static List<Ingredient> Ingredients = new List<Ingredient>()
        {
            new Bean (
                name: "Mellan Rost",
                type: "Robusta",
                manufacturer: "Gevalia",
                price: 4.5m,
                unit: "g",
                amount: 0,
                ecological: false,
                fairtrade: false,
                roastType: "Mellan Rost" 
            ),

            new Bean (
                name: "Mellan Rost",
                type: "Arabica",
                manufacturer: "Löfbergs Lila",
                price: 5.5m,
                unit: "g",
                amount: 0,
                ecological: true,
                fairtrade: true,
                roastType: "Mellan Rost"
            ),

            new Water (
                name: "Tap Water",
                type: "Still",
                manufacturer: "Communal",
                price: 0.3m,
                unit: "l",
                amount: 0
            ),

            new Water (                
                name: "Loka Citron",
                type: "Sparkling",
                manufacturer: "Loka",
                price: 14m,
                unit: "l",
                amount: 0
            ),

            new Milk (
                name: "iKaffe",
                type: "Havre",
                manufacturer: "Oatly",
                price: 20m,
                unit: "l",
                amount: 0,
                ecological: true,
                lactose: false,
                fat: 0.5f
            ),

            new Milk (
                name: "Mellanmjölk",
                type: "Mjölk",
                manufacturer: "Arla",
                price: 10m,
                unit: "l",
                amount: 0,
                ecological: false,
                lactose: true,
                fat: 1.5f
            ),

            new Flavouring (
                name: "Socker",
                type: "Strö",
                manufacturer: "Dansukker",
                price: 17m,
                unit: "kg",
                amount: 0
            ),

            new Flavouring (
                name: "Kardemumma",
                type: "Krydda",
                manufacturer: "Santa Maria",
                price: 1m,
                unit: "g",
                amount: 0
            ),
        };
    }
}

