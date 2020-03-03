using System;
using System.Collections.Generic;
using System.Text;

namespace Barista
{
    class Bean
    {
        public string BeanType { get; set; }
        public string Manufacturer { get; set; }
        public bool Ecological { get; set; }
        public bool Fairtrade { get; set; }
        public string RoastType { get; set; }
        public float Grind { get; set; }

        public Bean(string _beanType, string _manufacturer, string _roastType, bool _ecological = false, bool _fairtrade = false, float _grind = 5)
        {
            this.BeanType = _beanType;
            this.Manufacturer = _manufacturer;
            this.Ecological = _ecological;
            this.Fairtrade = _fairtrade;
            this.RoastType = _roastType;
            this.Grind = _grind;
        }

    }
}
