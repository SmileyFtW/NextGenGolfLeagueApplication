using GLA.Interfaces;
using GLA.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Testing.PlayerManagement
{
    [TestFixture]
    class PlayerMgtTests
    {
        [Test]
        public void Player_AddNewNoID_ReturnsNoID()
        {
            //Arrrange
            IPlayer player;

            //Act
            player = new Player();
            string result = player.IDItem.ID;

            //Assert
            Assert.AreEqual("", result);
        }
        [Test]
        public void Player_AddNewWithID2020SepSeq1NumDig3_Returns2020Sep001()
        {
            IPlayer player;
            string prefix = "2020";
            string separator = "Sep";
            int sequenceNumber = 1;
            int numDigits = 3;
            string expected = "2020Sep001";

            player = new Player(prefix, separator, sequenceNumber, numDigits);
            string result = player.IDItem.ID;

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Player_AddNewWithPreyyyySepDashSeq1NumDig3_ReturnsyyyyDash001()
        {
            IPlayer player;
            string prefix = "yyyy";
            string separator = "-";
            int sequenceNumber = 1;
            int numDigits = 3;
            string expected = "yyyy-001";

            player = new Player(prefix, separator, sequenceNumber, numDigits);
            string result = player.IDItem.ID;

            Assert.AreEqual(expected, result);
        }

        //TODO test to make sure the number of digits is at least equal to the order of magnitude of the sequence number
    }
}
