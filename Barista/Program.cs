using System;
using System.Collections.Generic;

namespace Barista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIngredient> Ingredients = new List<IIngredient>();
            Ingredients.Add(new Bean { 
                Name = "Mellan Rost", 
                Type = "Robusta", 
                Manufacturer = "Gevalia", 
                Price = 45, Unit = "g", 
                Ecological = false, 
                Fairtrade = false, 
                RoastType = "Mellan Rost" });
            Ingredients.Add(new Bean { 
                Name = "Mellan Rost", 
                Type = "Arabica", 
                Manufacturer = "Löfbergs", 
                Price = 55, 
                Unit = "g", 
                Ecological = true, 
                Fairtrade = true, 
                RoastType = "Mellan Rost" });

            Ingredients.Add(new Water { 
                Name = "Loka Citron", 
                Type = "Still", 
                Manufacturer = "Loka", 
                Price = 13, 
                Unit = "l" });

            Ingredients.Add(new Milk { Name="iKaffe", Type="Havre",  });


            Start();

        }
        public Start()
        {

        }
    }
}
