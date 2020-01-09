using GLA.DataIO;
using GLA.Models;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLA.Testing.Serialization
{
    [TestFixture]
    class PlayerCollectionSerializationTests
    {
        [Test]
        public void PlayerCollection_SerializationOfOnePlayer_ReturnsValidOnePlayerXML()
        {
            //Arrange
            //Player info
            string playerFirstName = "David";
            string playerLastName = "Miley";
            string playerIDprefix = "Pre";
            string playerIDsep = "Sep";
            int playerIDseqNumber = 1;
            int playerIDnumDigits = 3;

            //Player object
            Player player = new Player(playerIDprefix,playerIDsep,playerIDseqNumber,playerIDnumDigits);
            player.PersonalInfo.NameOfPerson.First = playerFirstName;
            player.PersonalInfo.NameOfPerson.Last = playerLastName;

            //Players Collection
            Hashtable playersCollection = new Hashtable();
            playersCollection.Add(player.IDItem.ID.ToString(), player);

            //Output path & file
            string outputPath = @"C:\Users\dgmsm\Source\Repos\SmileyFtW\NextGenGolfLeagueApplication\GLA\DataIO\DataIOTemp\";
            string outputFileName="TempPlayersXMLOutput";

            //Serialization
            PlayersCollectionSerialization playersCollectionSerialization = new PlayersCollectionSerialization(playersCollection);

            //Act

            //Assert
        }

    }
}
