using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Barista {
    public class CoffeeMachine : IStart, IWater, IAdditive//, IStop
    {
        private List<Ingredient> ingredients = new List<Ingredient>();

        private CoffeeMachine() { }

        public static IStart Start() => new CoffeeMachine();

        public Coffee MakeEspresso()
        {
            return Start().AddBean((Bean)Program.Ingredients.First(i => i.Name == "Mellan Rost"), 10)
                .AddWater((Water)Program.Ingredients.First(i => i.Name == "Tap Water"), 10).GetCoffee();
        }

        public IWater AddBean(Bean bean, int amount)
        {
            bean.Amount = amount;
            this.ingredients.Add(bean);
            return this;
        }

        public IAdditive AddWater(Water water, int amount)
        {
            water.Amount = amount;
            this.ingredients.Add(water);
            return this;
        }

        public IAdditive AddMilk(Milk milk, int amount)
        {
            milk.Amount = amount;
            this.ingredients.Add(milk);
            return this;
        }
        public IAdditive AddFlavouring(Flavouring flavouring, int amount)
        {
            flavouring.Amount = amount;
            this.ingredients.Add(flavouring);
            return this;
        }

        public Coffee GetCoffee()
        {
            return new Coffee(this.ingredients);
        }
    }

    public interface IStart
    {
        public IWater AddBean(Bean bean, int amount);
        public Coffee MakeEspresso();
    }

    public interface IWater
    {
        public IAdditive AddWater(Water water, int amount);
    }

    public interface IAdditive
    {
        public IAdditive AddMilk(Milk milk, int amount);
        public IAdditive AddFlavouring(Flavouring flavouring, int amount);
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
}
