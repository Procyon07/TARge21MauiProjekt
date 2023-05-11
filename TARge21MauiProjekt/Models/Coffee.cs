using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Coffee
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string HeroImage { get; set; }
        public double Price { get; set; }
        public Color AccentColorStart { get; set; }
        public Color AccentColorEnd { get; set; }
        public List<string> Images { get; set; }
       
    }
}
