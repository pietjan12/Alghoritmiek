using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.api.Models
{
    public class Trein
    {
        public List<Wagon> wagons { get; set; }

        public Trein()
        {
            wagons = new List<Wagon>();
        }
    }
}
