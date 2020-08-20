using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameProject;
namespace UnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        RussianRoulette objTest = new RussianRoulette();
      
        [TestMethod]
        public void GenrateRandomNumber()
        {
            SpinChamber spin = new SpinChamber();
            spin.ChamberStart = objTest.spinChamber();
            spin.BulleteInChamber = objTest.spinChamber();
        }

        [TestMethod]
        public void TestGameRules()
        {
            Player gamePlayer = new Player();
            SpinChamber spin = new SpinChamber();
            spin.ChamberStart = objTest.spinChamber();
            spin.BulleteInChamber = objTest.spinChamber();
            int currentChamber = objTest.PlayGame(gamePlayer.NumberOfPlayer, spin.ChamberStart, spin.BulleteInChamber);
        }
    }
}
