using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VegStore.Models;

namespace VegStore.Service
{
    public class VegetableService
    {
        private readonly static IEnumerable<Vegetable> _Vegetables = new List<Vegetable>
        {
            new Vegetable
            {
                Name = "Tomato",
                Image = "tomato",
                Price = 5.00,
            },
            new Vegetable
            {
                Name = "Carrot",
                Image = "carrot",
                Price = 7.00,
            },
            new Vegetable
            {
                Name = "Corn",
                Image = "corn",
                Price = 15.00,
            },
            new Vegetable
            {
                Name = "Red Chill",
                Image = "red_chili_pepper",
                Price = 5.00,
            },
            new Vegetable
            {
                Name = "Pumpkin",
                Image = "pumpkin",
                Price = 50.00,
            },
            new Vegetable
            {  
                Name = "Onion",
                Image = "onion",
                Price = 40
            },
            new Vegetable
            {
                Name = "Ginger",
                Image = "aadu",
                Price = 40
            },
            new Vegetable
            {
                Name = "bit",
                Image = "bit",
                Price = 40
            },
            new Vegetable
            {
                Name = "brinjal",
                Image = "brinjal",
                Price = 40
            },
            new Vegetable
            {
                Name = "brocolli",
                Image = "brocolli",
                Price = 40
            },
            new Vegetable
            {
                Name = "Cabbage",
                Image = "cabbage",
                Price = 40
            },
            new Vegetable
            {
                Name = "Capsicum",
                Image = "capsicum",
                Price = 40
            },
            new Vegetable
            {
                Name = "carrot",
                Image = "carrot",
                Price = 40
            },
            new Vegetable
            {
                Name = "cauliflower",
                Image = "cauliflower",
                Price = 40
            },
            new Vegetable
            {
                Name = "Kothamari",
                Image = "coriander",
                Price = 40
            },
            new Vegetable
            {
                Name = "fansi",
                Image = "fansi",
                Price = 40
            },
            new Vegetable
            {
                Name = "methi",
                Image = "fenugreek",
                Price = 40
            },
            new Vegetable
            {
                Name = "Kakdi",
                Image = "kakdi",
                Price = 40
            },
            new Vegetable
            {
                Name = "Karela",
                Image = "karela",
                Price = 40
            }
        };

        public IEnumerable<Vegetable> GetAllVegetables() => _Vegetables;

        public IEnumerable<Vegetable> GetPopularVegetables(int count = 6) => _Vegetables
            .OrderBy(p => Guid.NewGuid()).Take(count);

        public IEnumerable<Vegetable> SearchVegetables(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _Vegetables
            : _Vegetables.Where(p => p.Name.Contains(searchTerm,
                StringComparison.OrdinalIgnoreCase));
    }
}
