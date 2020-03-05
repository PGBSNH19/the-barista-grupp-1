using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Barista {
    public class CoffeeMachine : IStart, IEspresso, IStop
    {
        private List<Ingredient> ingredients;
        public Espresso espresso { get; set; }

        public IEspresso Start() 
        {
            this.ingredients = new List<Ingredient>();
            return this;
        }

        public IStop AddEspresso(int amount)
        {
            this.espresso = (new Espresso(
                (Bean) Program.Ingredients.Where(i => i.Name == "Mellan Rost").First(),
                (Water)Program.Ingredients.Where(i => i.Name == "Loka Citron").First()));
            return this;
        }

        public Coffee GetCoffee()
        {
            return new Coffee(this.ingredients);
        }

    }

    public interface IStart
    {
        public IEspresso Start();
    }

    public interface IEspresso
    {
        public IStop AddEspresso(int Amount);
    }

    public interface IStop
    {
        public Coffee GetCoffee();
    }



    public class Coffee
    {
        public List<Ingredient> Ingredients { get; set; }
        public Coffee(List<Ingredient> ingredients)
        {
            this.Ingredients = ingredients;
        }
    }


    public class Espresso : Ingredient
    {
        public Bean bean { get; }
        public Water water { get; }

        public int Amount { get; set; }

        public Espresso(Bean bean , Water water)
        {
            this.bean = bean;
            this.water = water;
            this.Amount = water.Amount;
        }

    }
}
