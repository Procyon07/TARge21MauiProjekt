using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal class CoffeeServices
    {
        private static List<Coffee> coffees = new()
        {
            new()
            {
                Name = "Cappucino",
                Subtitle = "The deliciously indulgent cup.",
                Description = "The perfect blend of creamy froth, bold espresso, and a sprinkle of cocoa magic, all in one deliciously indulgent cup",
                HeroImage = "cappucino.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new ()
                {
                    "https://www.acouplecooks.com/wp-content/uploads/2020/10/how-to-make-cappuccino-005.jpg",
                    "https://kawazmleczkiem.pl/app/uploads/2020/12/CAPPUCINO-1024x682-min-1024x682.jpg",
                    "https://noir.web.id/wp-content/uploads/2022/04/jual-cappucino-terdekat.jpg"

                }
            }
        };
    }
}
