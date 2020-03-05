using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    public class CoffeeMachine
    {

        private CoffeeMachine() { }

        //public IStart Start() => new CoffeeMachine();

        public void AddEspresso(int amount)
        {

        }

    }

    public interface IStart
    {
        public void AddEspresso(int Amount);
    }

    public interface IStop
    {

    }

    public class Espresso
    {
        Bean bean;
        Water water;

        public int Amount { get; set; }

        public Espresso(Bean bean , Water water)
        {
            this.bean = bean;
            this.water = water;
            this.Amount = water.Amount;
        }

    }
}
