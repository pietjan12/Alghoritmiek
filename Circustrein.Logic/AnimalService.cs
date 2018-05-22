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

       /* public Trein PerformAlghoritm()
        {
            Trein trein = new Trein();
            //Benodigde dieren opvragen
            List<Animal> animals = _context.GetAllAnimals();

            //Alle vleeseters geordend van klein naar groot
            IEnumerable<Animal> MeatEaters = animals.Where(a => a.foodType == FoodType.Vlees).OrderByDescending(a => a.animalSize);

            //Alle planteters
            IEnumerable<Animal> PlantEaters = animals.Where(a => a.foodType == FoodType.Planten);
            //Alle planteters op basis van grootte
            List<Animal> LargePlantEaters = PlantEaters.Where(a => a.animalSize == AnimalSize.Groot).ToList();
            List<Animal> MediumPlantEaters = PlantEaters.Where(a => a.animalSize == AnimalSize.Middel).ToList();
            List<Animal> SmallPlantEaters = PlantEaters.Where(a => a.animalSize == AnimalSize.Klein).ToList();


            //Als allereerste 2 grote planteters koppelen voor 10 punten wagon.
            while(LargePlantEaters.Count > 1)
            {
                Wagon w = new Wagon();
                Animal LargePlant1 = LargePlantEaters[0];
                Animal LargePlant2 = LargePlantEaters[1];

                w.animals.Add(LargePlant1);
                w.animals.Add(LargePlant2);
                w.FreePoints -= LargePlant1.points;
                w.FreePoints -= LargePlant2.points;

                LargePlantEaters.Remove(LargePlant1);
                LargePlantEaters.Remove(LargePlant2);

                trein.wagons.Add(w);
            }

            //Hierna kleine planteters proberen te koppelen aan 10/9/8 punten wagon
            for(int i = SmallPlantEaters.Count - 1; i > -1; i--)
            {
                Wagon w = new Wagon();

                //proberen 1 smallplanteter met 3 mediumplanteters te koppelen voor 10 punten
                if(MediumPlantEaters.Count > 2)
                {
                    Animal SmallPlant = SmallPlantEaters[0];
                    Animal MediumPlant1 = MediumPlantEaters[0];
                    Animal MediumPlant2 = MediumPlantEaters[1];
                    Animal MediumPlant3 = MediumPlantEaters[2];

                    w.animals.Add(SmallPlant);
                    w.animals.Add(MediumPlant1);
                    w.animals.Add(MediumPlant2);
                    w.animals.Add(MediumPlant3);
                    w.FreePoints = 0;

                    SmallPlantEaters.Remove(SmallPlant);
                    MediumPlantEaters.Remove(MediumPlant1);
                    MediumPlantEaters.Remove(MediumPlant2);
                    MediumPlantEaters.Remove(MediumPlant3);
                } 
                //proberen 4 smallplanteaters met 2 mediumplanteters te koppelen voor 10 punten
                else if (SmallPlantEaters.Count > 3 && MediumPlantEaters.Count > 1)
                {
                    Animal SmallPlant1 = SmallPlantEaters[0];
                    Animal SmallPlant2 = SmallPlantEaters[1];
                    Animal SmallPlant3 = SmallPlantEaters[2];
                    Animal SmallPlant4 = SmallPlantEaters[3];
                    Animal MediumPlant1 = MediumPlantEaters[0];
                    Animal MediumPlant2 = MediumPlantEaters[1];

                    w.animals.Add(SmallPlant1);
                    w.animals.Add(SmallPlant2);
                    w.animals.Add(SmallPlant3);
                    w.animals.Add(SmallPlant4);
                    w.animals.Add(MediumPlant1);
                    w.animals.Add(MediumPlant2);
                    w.FreePoints = 0;

                    SmallPlantEaters.Remove(SmallPlant1);
                    SmallPlantEaters.Remove(SmallPlant2);
                    SmallPlantEaters.Remove(SmallPlant3);
                    SmallPlantEaters.Remove(SmallPlant4);
                    MediumPlantEaters.Remove(MediumPlant1);
                    MediumPlantEaters.Remove(MediumPlant2);
                }

                //Proberen 7 smallplanteaters met 1 mediumplanteter te koppelen voor 10 punten
                else if(SmallPlantEaters.Count > 6 && MediumPlantEaters.Count > 0)
                {
                    Animal SmallPlant1 = SmallPlantEaters[0];
                    Animal SmallPlant2 = SmallPlantEaters[1];
                    Animal SmallPlant3 = SmallPlantEaters[2];
                    Animal SmallPlant4 = SmallPlantEaters[3];
                    Animal SmallPlant5 = SmallPlantEaters[4];
                    Animal SmallPlant6 = SmallPlantEaters[5];
                    Animal SmallPlant7 = SmallPlantEaters[6];
                    Animal MediumPlant1 = MediumPlantEaters[0];

                    w.animals.Add(SmallPlant1);
                    w.animals.Add(SmallPlant2);
                    w.animals.Add(SmallPlant3);
                    w.animals.Add(SmallPlant4);
                    w.animals.Add(SmallPlant5);
                    w.animals.Add(SmallPlant6);
                    w.animals.Add(SmallPlant7);
                    w.animals.Add(MediumPlant1);
                    w.FreePoints = 0;

                    SmallPlantEaters.Remove(SmallPlant1);
                    SmallPlantEaters.Remove(SmallPlant2);
                    SmallPlantEaters.Remove(SmallPlant3);
                    SmallPlantEaters.Remove(SmallPlant4);
                    SmallPlantEaters.Remove(SmallPlant5);
                    SmallPlantEaters.Remove(SmallPlant6);
                    SmallPlantEaters.Remove(SmallPlant7);
                    MediumPlantEaters.Remove(MediumPlant1);
                }

                //proberen 10 smallplanteters voor 10 punten
                else if(SmallPlantEaters.Count > 9)
                {
                    Animal SmallPlant1 = SmallPlantEaters[0];
                    Animal SmallPlant2 = SmallPlantEaters[1];
                    Animal SmallPlant3 = SmallPlantEaters[2];
                    Animal SmallPlant4 = SmallPlantEaters[3];
                    Animal SmallPlant5 = SmallPlantEaters[4];
                    Animal SmallPlant6 = SmallPlantEaters[5];
                    Animal SmallPlant7 = SmallPlantEaters[6];
                    Animal SmallPlant8 = SmallPlantEaters[7];
                    Animal SmallPlant9 = SmallPlantEaters[8];
                    Animal SmallPlant10 = SmallPlantEaters[9];

                    w.animals.Add(SmallPlant1);
                    w.animals.Add(SmallPlant2);
                    w.animals.Add(SmallPlant3);
                    w.animals.Add(SmallPlant4);
                    w.animals.Add(SmallPlant5);
                    w.animals.Add(SmallPlant6);
                    w.animals.Add(SmallPlant7);
                    w.animals.Add(SmallPlant8);
                    w.animals.Add(SmallPlant9);
                    w.animals.Add(SmallPlant10);

                    w.FreePoints = 0;

                    SmallPlantEaters.Remove(SmallPlant1);
                    SmallPlantEaters.Remove(SmallPlant2);
                    SmallPlantEaters.Remove(SmallPlant3);
                    SmallPlantEaters.Remove(SmallPlant4);
                    SmallPlantEaters.Remove(SmallPlant5);
                    SmallPlantEaters.Remove(SmallPlant6);
                    SmallPlantEaters.Remove(SmallPlant7);
                    SmallPlantEaters.Remove(SmallPlant8);
                    SmallPlantEaters.Remove(SmallPlant9);
                    SmallPlantEaters.Remove(SmallPlant10);
                }

                //grote planteters vullen met 4/5 Kleine planteters, zodat er 9 of 10 punten verdient worden (ipv 8 bij medium meat)
                else if (LargePlantEaters.Count > 0 && SmallPlantEaters.Count >= 4)
                {
                    Animal LargePlant = LargePlantEaters[0];
                    w.animals.Add(LargePlant);
                    w.FreePoints -= LargePlant.points;
                    
                    
                    for(int i2 = 0; i2 < SmallPlantEaters.Count; i2++)
                    {
                        //Toevoegen aan wagon en verwijderen uit lijst.
                        Animal SmallPlant = SmallPlantEaters[0];
                        w.animals.Add(SmallPlant);
                        w.FreePoints -= SmallPlant.points;

                        SmallPlantEaters.RemoveAt(0);
                    }

                    //Largeplant uit list verwijderen
                    LargePlantEaters.Remove(LargePlant);
                }

                //TODO, CONTROLEREN OF DINGEN HIER OPGEMAAKT MOETEN WORDEN, ALS JE ALLEEN MEDIUM EN KLEINE PLANT DOET KLOPPEN DE WAGONS NIET ( KLEINE WORDEN IN EEN WAGON GEDAAN, MAAR MEDIUM WORDEN GENEGEERD)

                //Geen matches gevonden, zoveel mogelijk opvullen met smallplanteaters
                else
                {
                    while (w.FreePoints - 1 >= 0 && SmallPlantEaters.Count > 0)
                    {
                        Animal SmallPlant = SmallPlantEaters[0];

                        w.animals.Add(SmallPlant);
                        w.FreePoints -= SmallPlant.points;

                        SmallPlantEaters.Remove(SmallPlant);
                    }
                }

                trein.wagons.Add(w);

            }

            //Hierna door alle vleeseters lopen met resterende planteneters
            foreach(Animal a in MeatEaters)
            {
                //mag zoiezo maar een per vleeseter per wagon, per foreach dus een nieuwe wagon maken
                Wagon w = new Wagon();
                w.FreePoints -= a.points;
                w.animals.Add(a);

                //Volgorde van list (Klein > Middel > Groot)
                if(a.animalSize == AnimalSize.Groot) {
                    //Grote vleeseter moet alleen, niks doen.
                }
                else if(a.animalSize == AnimalSize.Middel) {
                    //Medium vleeseter

                    //Kan alleen maar een grote planteter meekrijgen (8 punten totaal)
                    if(LargePlantEaters.Count > 0)
                    {
                        Animal LargePlant = LargePlantEaters[0];

                        w.animals.Add(LargePlant);
                        w.FreePoints -= LargePlant.points;

                        //Item uit list verwijderen
                        LargePlantEaters.Remove(LargePlant);
                    }
                }
                else if(a.animalSize == AnimalSize.Klein) {
                    //9 punten vrij

                    int AmountToFill = w.FreePoints / 3;
                    //Als allereerste proberen op te vullen met 3 medium plant eters
                    if (MediumPlantEaters.Count >= AmountToFill)
                    {
                        //Zoveel als nodig toevoegen.
                        for (int i = 0; i < AmountToFill; i++)
                        {
                            //Plant toevoegen aan wagon
                            Animal MediumPlant = MediumPlantEaters[0];
                            w.animals.Add(MediumPlant);
                            w.FreePoints -= MediumPlant.points;

                            //Plant verwijderen uit lijst
                            MediumPlantEaters.Remove(MediumPlant);
                        }
                    } else
                    {
                        //Er is nog plek voor een largeplanteter
                        if (LargePlantEaters.Count > 0 && w.FreePoints >= 5)
                        {
                            //4 punten vrij
                            Animal LargePlant = LargePlantEaters.First();

                            //toevoegen aan wagon
                            w.animals.Add(LargePlant);
                            w.FreePoints -= LargePlant.points;
                            //Plant van lijst verwijderen, is gekoppeld aan wagon.
                            LargePlantEaters.Remove(LargePlant);
                        }

                        //Wagon vullen met medium planten zolang er genoeg ruimte is en mediumplanteters in de lijst zitten.
                        while (w.FreePoints >= 3 && MediumPlantEaters.Count > 0)
                        {
                            Animal MediumPlant = MediumPlantEaters[0];
                            w.animals.Add(MediumPlant);
                            w.FreePoints -= MediumPlant.points;
                            //Mediumplant uit lijst verwijderen
                            MediumPlantEaters.Remove(MediumPlant);
                        }
                    }

                    //Kan niet gevuld worden, alleen in een wagon.
                }

                //Wagon aan trein toevoegen.
                trein.wagons.Add(w);
            }

            return trein;
        } */

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
            return w.FreePoints > a.points;
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
