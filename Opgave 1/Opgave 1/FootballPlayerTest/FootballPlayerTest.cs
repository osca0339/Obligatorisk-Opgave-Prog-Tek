using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Opgave_1;

namespace FootballPlayerTest
{
    [TestClass]
    public class FootballPlayerTest
    {
        private FootballPlayer _footballPlayer = new FootballPlayer();
        
        [TestMethod]
        public void IdTest()
        {
            _footballPlayer.Id = 1;
            Assert.AreEqual(1, _footballPlayer.Id);
            _footballPlayer.Id = 10;
            Assert.AreEqual(10, _footballPlayer.Id);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.Id = 0);
        }

        [TestMethod]
        public void NameTest()
        {
            _footballPlayer.Name = "Mikkel";
            Assert.AreEqual("Mikkel", _footballPlayer.Name);
            _footballPlayer.Name = "Joakim";
            Assert.AreEqual("Joakim", _footballPlayer.Name);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.Name = "Ib");
        }

        [TestMethod]
        public void PriceTest()
        {
            _footballPlayer.Price = 1;
            Assert.AreEqual(1, _footballPlayer.Price);
            _footballPlayer.Price = 720000;
            Assert.AreEqual(720000, _footballPlayer.Price);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.Price = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.Price = -1);
        }

        [TestMethod]
        public void ShirtNumberTest()
        {
            _footballPlayer.ShirtNumber = 50;
            Assert.AreEqual(50, _footballPlayer.ShirtNumber);
            _footballPlayer.ShirtNumber = 1;
            Assert.AreEqual(1, _footballPlayer.ShirtNumber);
            _footballPlayer.ShirtNumber = 100;
            Assert.AreEqual(100, _footballPlayer.ShirtNumber);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = 0);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _footballPlayer.ShirtNumber = 101);
        }
    }
}
