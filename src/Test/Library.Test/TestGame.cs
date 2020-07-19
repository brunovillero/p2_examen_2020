using NUnit.Framework;
using System.Collections.Generic;
using System;
using Library;
namespace Library.Test
{
    public class TestsGame
    {
        private GameManager game;
        private Traveler juan;
        private Traveler jose;
        private Traveler silvia;

        [SetUp]
        public void Setup()
        {
            juan   = new Traveler("Juan");
            jose   = new Traveler("Jose");
            silvia = new Traveler("Silvia");

            game = new GameManager(new List<Traveler>{juan, jose, silvia});
        }

        [Test]
        public void TestTravelerMovingBackToStart()
        {
            game.MoveTravelerToStation(2, juan);
            Assert.Throws(
                typeof(Exception),
                delegate { game.MoveTravelerToStation(0, juan); },
                "Traveler already visited this station."
            );
        }

        [Test]
        public void TestFarmExperience()
        {
            game.MoveTravelerToStation(3, juan);
            
            game.DoExperiencience(juan);
            Assert.AreEqual(3, juan.Coins);
        }

        [Test]
        public void TestThermalWatersExperience()
        {
            game.MoveTravelerToStation(4, juan);
            
            game.DoExperiencience(juan);
            Assert.AreEqual(2, juan.Points);
        }

        [Test]
        public void TestOceanExperience()
        {
            game.MoveTravelerToStation(2, juan);
            
            game.DoExperiencience(juan);
            Assert.AreEqual(1, juan.Points);
            
            game.DoExperiencience(juan);
            game.DoExperiencience(juan);
            Assert.AreEqual(9, juan.Points);
        }

        [Test]
        public void TestMountainExperience()
        {
            game.MoveTravelerToStation(1, jose);
            
            game.DoExperiencience(jose);
            Assert.AreEqual(1, jose.Points);           
            
            game.DoExperiencience(jose);
            game.DoExperiencience(jose);
            game.DoExperiencience(jose);
            Assert.AreEqual(10, jose.Points);
        }

        [Test]
        public void TestStationLimit()
        {
            game.MoveTravelerToStation(3, jose);
            Assert.Throws(
                typeof(Exception),
                delegate { game.MoveTravelerToStation(3, juan); },
                "To many travelers in this experience."
            );
        }

        [Test]
        public void TestWinner()
        {
            game.MoveTravelerToStation(1, jose);
            game.DoExperiencience(jose);

            game.MoveTravelerToStation(1, juan);
            game.DoExperiencience(juan);

            game.MoveTravelerToStation(4, silvia);
            game.DoExperiencience(silvia);

            Assert.AreEqual(silvia, game.TheWinnerIs());
        }
    }
}