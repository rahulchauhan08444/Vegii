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
    Name = "ટમેટા",
    Image = "tomato"
},
new Vegetable
{
    Name = "ગાજર",
    Image = "carrot"
},
new Vegetable
{
    Name = "મકાઈ",
    Image = "corn"
},
new Vegetable
{
    Name = "લાલ મરચું",
    Image = "red_chili_pepper"
},
new Vegetable
{
    Name = "કોળું",
    Image = "pumpkin"
},
new Vegetable
{
    Name = "ડુંગળી",
    Image = "onion"
},
new Vegetable
{
    Name = "આદુ",
    Image = "aadu"
},
new Vegetable
{
    Name = "બીટ",
    Image = "bit"
},
new Vegetable
{
    Name = "રિંગણ",
    Image = "brinjal"
},
new Vegetable
{
    Name = "બ્રોકોલી",
    Image = "brocolli"
},
new Vegetable
{
    Name = "કોટમરી",
    Image = "coriander"
},
new Vegetable
{
    Name = "ફણસી",
    Image = "fansi"
},
new Vegetable
{
    Name = "મેથી",
    Image = "fenugreek"
},
new Vegetable
{
    Name = "કાકડી",
    Image = "kakdi"
},
new Vegetable
{
    Name = "કારેલા",
    Image = "karela"
},
new Vegetable
{
    Name = "ભીંડા",
    Image = "ladyfinger"
},
new Vegetable
{
    Name = "લસણ",
    Image = "lasan"
},
new Vegetable
{
    Name = "લીલું લસણ",
    Image = "lilu_lasan"
},
new Vegetable
{
    Name = "મકાઈ",
    Image = "makay"
},
new Vegetable
{
    Name = "મરચા",
    Image = "marcha"
},
new Vegetable
{
    Name = "મૂળા",
    Image = "mula"
},
new Vegetable
{
    Name = "પાલક",
    Image = "palak"
},
new Vegetable
{
    Name = "પરવળ",
    Image = "parval"
},
new Vegetable
{
    Name = "બટેટા",
    Image = "potato"
},
new Vegetable
{
    Name = "શક્કરકંદ",
    Image = "sakarkolu"
},
new Vegetable
{
    Name = "સરઘવો",
    Image = "sarghavo"
},
new Vegetable
{
    Name = "તુવેર",
    Image = "tuver"
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
