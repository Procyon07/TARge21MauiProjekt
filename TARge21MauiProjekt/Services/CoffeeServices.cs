using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    internal class CoffeeServices
    {
        private static readonly List<Coffee> coffees = new()
        {
            new()
            {
                Name = "Cappucino",
                Description = "The perfect blend of creamy froth, bold espresso, and a sprinkle of cocoa magic, all in one deliciously indulgent cup",
                Price = 4.99,
                HeroImage = "cappucino.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new ()
                {
                    "https://www.acouplecooks.com/wp-content/uploads/2020/10/how-to-make-cappuccino-005.jpg",
                    "https://kawazmleczkiem.pl/app/uploads/2020/12/CAPPUCINO-1024x682-min-1024x682.jpg",
                    "https://noir.web.id/wp-content/uploads/2022/04/jual-cappucino-terdekat.jpg"
                }
            },
            new()
            {
                Name = "Espresso",
                Description = "Espresso is a small but mighty coffee shot that packs a punch of bold, rich flavor. ",
                Price = 3.99,
                HeroImage = "espresso.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new ()
                {
                    "https://www.tasteofhome.com/wp-content/uploads/2023/03/TOH-espresso-GettyImages-1291298315-JVcrop.jpg",
                    "https://www.kohvisemu.ee/app/uploads/2020/08/espresso-2.jpg",
                    "https://aeromatic.app/img/recipe/photos/16x9-espresso.jpg"
                }
            },
            new()
            {
                Name = "Americano",
                Description = "Americano is a coffee superhero that combines the strength of espresso and the simplicity of water.",
                Price = 5.50,
                HeroImage = "americano.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new ()
                {
                    "https://www.cleaneatingkitchen.com/wp-content/uploads/2022/07/espresso-americano-over-ice-with-straw.jpg",
                    "https://mocktail.net/wp-content/uploads/2022/03/homemade-Iced-Americano-recipe_1ig.jpg",
                    "https://cdn.shopify.com/s/files/1/0219/5410/articles/Delicious-Homemade-Americano_1200x1200.jpg"
                }
            },
            new()
            {
                Name = "Latte",
                Description = "Latte, espresso with steamed milk, is a rich and creamy treat that'll make you smile.",
                Price = 5.99,
                HeroImage = "latte.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new ()
                {
                    "https://coffeeaffection.com/wp-content/uploads/2021/05/Spanish-latte-milk-and-espresso-500x500.jpg",
                    "https://coffeeatthree.com/wp-content/uploads/latte-1.jpg",
                    "https://www.foodandwine.com/thmb/bbGkMAcccFgLFuCrF68gUXCV0ak=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/What-Is-a-Latte-FT-BLOG0123-6f8fdce71fec475bb804381a15eb2ccf.jpg"
                }
            },
            new()
            {
                Name = "Macchiato",
                Description = "Macchiato, a mini espresso with milk foam, is like a little treat with a fun design.",
                Price = 4.99,
                HeroImage = "macchiato.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new ()
                {
                    "https://www.acouplecooks.com/wp-content/uploads/2020/10/how-to-make-a-macchiato-003s.jpg",
                    "https://ee.jura.com/-/media/global/images/coffee-recipes/images-redesign-2020/latte_macchiato_2000x1400px.jpg",
                    "https://ee.jura.com/-/media/global/images/coffee-recipes/images-redesign-2020/espresso_macchiato_2000x1400px.jpg"
                }
            },
            new()
            {
                Name = "Drip Coffee",
                Description = "Drip coffee is the reliable and satisfying way to enjoy classic coffee flavors.",
                Price = 3.99,
                HeroImage = "dripcoffee.png",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new ()
                {
                    "https://www.roastycoffee.com/wp-content/uploads/shutterstock_1027443565-800x534.jpg",
                    "https://minimalistbaker.com/wp-content/uploads/2019/01/Step-by-Step-instructions-for-How-to-Make-Pourover-Coffee-minimalistbaker-coffee-4.jpg",
                    "https://www.coffeedesk.com/blog/wp-content/uploads/2019/07/JJF_3805-1920x1280.jpg"
                }
            },
        };
        public static List<Coffee> GetFeaturedCoffees()
        {
            var random = new Random();
            var randomizedCoffees = coffees.OrderBy(item => random.Next());

            return randomizedCoffees.Take(2).ToList();
        }
        public static List<Coffee> GetAllCoffees()
        => coffees;

        public static Coffee GetPlanet(string coffeeName)
            => coffees.Where(_coffee => _coffee.Name == coffeeName).FirstOrDefault();
    }
}
