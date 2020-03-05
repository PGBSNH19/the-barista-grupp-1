using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    public class CoffeeMachine
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
