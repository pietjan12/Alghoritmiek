using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Circustrein.api.Models;
using Circustrein.Logic;
using Circustrein.data;

namespace Circustrein.Tests
{
    [TestClass]
    public class LogicTests
    {
        private AnimalService _AnimalService;
        private List<Animal> animals;

        public LogicTests() {
            _AnimalService = new AnimalService();
        }

        [TestMethod]
        public void TestSizeFitsDoesFit()
        {
            Animal a1 = new Animal();
            a1.animalSize = AnimalSize.Groot;

            Animal a2 = new Animal();
            a2.animalSize = AnimalSize.Klein;

            Assert.AreEqual(true, _AnimalService.SizeFits(a1, a2));
        }

        [TestMethod]
        public void TestSizeFitsDoesNotFit()
        {
            Animal a1 = new Animal();
            a1.animalSize = AnimalSize.Groot;

            Animal a2 = new Animal();
            a2.animalSize = AnimalSize.Klein;

            Assert.AreEqual(false, _AnimalService.SizeFits(a2, a1));
        }

        [TestMethod]
        public void TestWagonHasMeatEater() {
            Animal a1 = new Animal();
            a1.foodType = FoodType.Vlees;

            Wagon w = new Wagon();
            w.animals.Add(a1);
            Assert.AreEqual(true, _AnimalService.WagonHasMeatEater(w));
        }

        [TestMethod]
        public void TestWagonDoesNotHaveMeatEater() {
            Animal a1 = new Animal();
            a1.foodType = FoodType.Planten;

            Wagon w = new Wagon();
            w.animals.Add(a1);
            Assert.AreEqual(false, _AnimalService.WagonHasMeatEater(w));
        }

        [TestMethod]
        public void TestWagonHasRoom() {
            Wagon w = new Wagon();

            Animal a = new Animal();
            a.animalSize = AnimalSize.Groot;
            w.animals.Add(a);

            Assert.AreEqual(true, _AnimalService.WagonHasRoom(w, a));
        }

        [TestMethod]
        public void TestWagonDoesNotHaveRoom()
        {
            Wagon w = new Wagon();
            Animal a = new Animal();
            a.animalSize = AnimalSize.Groot;
            a.points = 5;
            Animal a2 = new Animal();
            a2.animalSize = AnimalSize.Groot;
            a2.points = 5;
            w.animals.Add(a);
            w.animals.Add(a2);
            w.FreePoints -= a.points;
            w.FreePoints -= a2.points;

            Animal a3 = new Animal();
            a3.animalSize = AnimalSize.Klein;
            a3.points = 1;

            Assert.AreEqual(false, _AnimalService.WagonHasRoom(w, a3));
        }

        [TestMethod]
        public void TestAddTwoPlantEaters() {
            Animal a = new Animal();
            a.foodType = FoodType.Planten;
            a.animalSize = AnimalSize.Groot;
            a.points = 5;

            Animal a2 = new Animal();
            a2.foodType = FoodType.Planten;
            a2.animalSize = AnimalSize.Groot;
            a2.points = 5;

            //Testen
            _AnimalService.AddAnimal(a);
            _AnimalService.AddAnimal(a2);

            Trein t = _AnimalService.PerformAlghoritm();

            Assert.AreEqual(1, t.wagons.Count);
        }

        [TestMethod]
        public void TestAddMediumMeatLargePlant()
        {
            Animal a = new Animal();
            a.foodType = FoodType.Vlees;
            a.animalSize = AnimalSize.Middel;
            a.points = 3;

            Animal a2 = new Animal();
            a2.foodType = FoodType.Planten;
            a2.animalSize = AnimalSize.Groot;
            a2.points = 5;

            _AnimalService.AddAnimal(a);
            _AnimalService.AddAnimal(a2);

            Trein t = _AnimalService.PerformAlghoritm();
            Assert.AreEqual(1, t.wagons.Count);
        }

        [TestMethod]
        public void TestAddLargeMeatLargePlant()
        {
            Animal a = new Animal();
            a.foodType = FoodType.Vlees;
            a.animalSize = AnimalSize.Groot;
            a.points = 5;

            Animal a2 = new Animal();
            a2.foodType = FoodType.Planten;
            a2.animalSize = AnimalSize.Groot;
            a2.points = 5;

            _AnimalService.AddAnimal(a);
            _AnimalService.AddAnimal(a2);

            Trein t = _AnimalService.PerformAlghoritm();
            Assert.AreEqual(2, t.wagons.Count);
        }
    }
}
