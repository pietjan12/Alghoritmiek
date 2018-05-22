using Circustrein.api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Logic.Interfaces
{
    public interface IAnimalService
    {
        List<Animal> GetAllAnimals();

        void AddAnimal(Animal animal);

        Trein PerformAlghoritm();
    }
}
