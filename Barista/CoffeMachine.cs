using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    public class CoffeeMachine
    {
        public List<IIngredient> Ingredients = new List<IIngredient>()
        {
            new Bean {
                Name = "Mellan Rost",
                Type = "Robusta",
                Manufacturer = "Gevalia",
                Price = 45, Unit = "g",
                Ecological = false,
                Fairtrade = false,
                RoastType = "Mellan Rost" },

            new Bean {
                Name = "Mellan Rost",
                Type = "Arabica",
                Manufacturer = "Löfbergs",
                Price = 55,
                Unit = "g",
                Ecological = true,
                Fairtrade = true,
                RoastType = "Mellan Rost" },

            new Water {
                Name = "Loka Citron",
                Type = "Still",
                Manufacturer = "Loka",
                Price = 13,
                Unit = "l" },

            new Milk {
                Name = "iKaffe",
                Type = "Havre",
                Ecological = true,
                Fat = 0.5f,
                Lactose = false,
                Manufacturer = "Oatly",
                Price = 20,
                Unit = "l"
            },

            new Milk
            {
                Name = "Mellanmjölk",
                Type = "Ko-mjölk",
                Ecological = false,
                Fat = 1.5f,
                Lactose = true,
                Manufacturer = "Arla",
                Price = 14,
                Unit = "l"
            },

            new Flavourings
            {
                Name = "Socker",
                Type = "Strö",
                Manufacturer = "Dansukker",
                Price = 17,
                Unit ="kg"
            },

            new Flavourings
            {
                Name = "Kardemumma",
                Type = "Krydda",
                Manufacturer = "Santa Maria",
                Price = 1,
                Unit ="g"
            }
        };

        Bean bönan = new Bean();
    }
}
