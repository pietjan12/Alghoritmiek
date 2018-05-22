using Circustrein.api.Models;
using Circustrein.data;
using Circustrein.data.Interfaces;
using Circustrein.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein.Logic
{
    //TODO : UITBREIDBAAR MAKEN
    public class AnimalService : IAnimalService
    {
        private IAnimalRepository _context { get; set; }

        public AnimalService()
        {
            _context = new AnimalsRepository();
        }

        public List<Animal> GetAllAnimals()
        {
            return _context.GetAllAnimals();
        }

        public void AddAnimal(Animal animal)
        {
            _context.AddAnimal(animal);
        }

        public Trein PerformAlghoritm()
        {
            Trein trein = new Trein();
            Wagon wagon = new Wagon();
            trein.wagons.Add(wagon);


            List<Animal> Animals = _context.GetAllAnimals();

            foreach(Animal a in Animals)
            {
                
                bool AnimalHasBeenAdded = false;
                foreach(Wagon w in trein.wagons)
                {
                    if (WagonHasRoom(w, a)) {
                        //Plek in wagon
                        if(a.foodType != FoodType.Planten) {
                            //Vlees of omnivoor
                            if(!WagonHasMeatEater(w))
                            {
                                w.animals.Add(a);
                                w.FreePoints -= a.points;
                                AnimalHasBeenAdded = true;
                            }
                        } else
                        {
                            //planteters

                            //Grootste vleeseter in de wagon opvragen, en meteen controleren of deze kleiner is dan de planteter
                            Animal BiggestAnimalEater = w.animals.FirstOrDefault(a2 => a2.foodType != FoodType.Planten);
                            if(BiggestAnimalEater != null)
                            {
                                //Er zit een vleeseter/omnivoor in de wagon
                                if(SizeFits(a, BiggestAnimalEater))
                                {
                                    //De planteneter past in de wagon
                                    w.animals.Add(a);
                                    w.FreePoints -= a.points;
                                    AnimalHasBeenAdded = true;
                                }
                            } else
                            {
                                //er zit geen vleeseter/omnivoor in en er is plek.
                                w.animals.Add(a);
                                w.FreePoints -= a.points;
                                AnimalHasBeenAdded = true;
                            }
                        }
                    }
                }

                //Dier is niet gekoppeld aan bestaande wagon, toevoegen aan nieuwe wagon.
                if(!AnimalHasBeenAdded)
                {
                    Wagon w = new Wagon();
                    w.animals.Add(a);
                    w.FreePoints -= a.points;
                    trein.wagons.Add(w);
                }

            }

            return trein;
        }

        public bool WagonHasRoom(Wagon w, Animal a)
        {
            return w.FreePoints >= a.points;
        }

        public bool WagonHasMeatEater(Wagon w)
        {
            //Kan vlees of omnivoor zijn.
            return w.animals.Exists(a => a.foodType != FoodType.Planten);
        }

        public bool SizeFits(Animal animaltoadd, Animal animalinwagon)
        {
            return animaltoadd.animalSize > animalinwagon.animalSize;
        }
    }
}
