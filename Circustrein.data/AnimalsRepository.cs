using Circustrein.api.Models;
using Circustrein.data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.data
{
    public class AnimalsRepository : IAnimalRepository
    {
        private List<Animal> animals;

        public AnimalsRepository()
        {
            animals = new List<Animal>();
        }

        public List<Animal> GetAllAnimals()
        {
            return animals;
        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
    }
}
