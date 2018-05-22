using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.api.Models
{
    public class Animal
    {
        public AnimalSize animalSize { get; set; }
        public FoodType foodType { get; set; }
        public int points { get; set; }
    }
}
