using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineRPG;
using System;

namespace UnitTestProject1
{

        [TestClass]
    public class FightUnitTest
    {
        [TestMethod()]
            public void WarriorAttackMag() 
            {
                var Geralt = new Warrior();
                var Xardas = new Mag();

                Console.WriteLine(Geralt);

                Console.WriteLine(Xardas);

            }
    }
}
