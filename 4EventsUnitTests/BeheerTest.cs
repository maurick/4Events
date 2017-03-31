using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _4Events.Logic;
using _4Events.Database;
using _4Events.Model;
using System.Collections.Generic;

namespace _4EventsUnitTests
{
    [TestClass]
    public class BeheerTest
    {
        [TestMethod]
        public void AccountCache()
        {
            Beheer beheer = new Beheer(new BeheerContext());

            Account account = new Account
            {
                ID = 1,
                Email = "test@test.nl"
            };

            beheer.CreateAccountCache(account);

            Assert.AreEqual(1, beheer.GetAccountCache());
        }
    }
}
