using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    class CoffeMachine
    {
        public Bean  bean;
        public string WaterSource { get; set; }
        public float Temperature { get; set; }
        public float Pressure { get; set; }
        public float Waterlevel { get; set; }
        public float BeansAmount { get; set; }
        public float MilkAmpount { get; set; }
        public float CupSize { get; set; }
    }
}
