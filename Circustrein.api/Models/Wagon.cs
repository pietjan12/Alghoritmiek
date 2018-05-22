using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.api.Models
{
    public class Wagon
    {
        public List<Animal> animals { get; set; }
        public int FreePoints { get; set; }

        public Wagon()
        {
            animals = new List<Animal>();
            FreePoints = 10;
        }
    }
}
