using GLA.DataIO;
using GLA.Models;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GLA.Testing.Serialization
{
    [TestFixture]
    class PlayerCollectionSerializationTests
    {
        // Cannot use xml serialization for any of this because all bjects
        // implement Interfaces; Interfaces cannot be xml serialized.
        //[Test]
        //public void Player_SerializationDesrialization_ReturnsOriginal()
        //{
        //    //Arrange
        //        //Player info
        //    string playerFirstName = "David";
        //    string playerLastName = "Miley";
        //    string playerIDprefix = "Pre";
        //    string playerIDsep = "Sep";
        //    int playerIDseqNumber = 1;
        //    int playerIDnumDigits = 3;

        //        //Player object
        //    Player serializedPlayer = new Player(playerIDprefix, playerIDsep, playerIDseqNumber, playerIDnumDigits);
        //    serializedPlayer.PersonalInfo.NameOfPerson.First = playerFirstName;
        //    serializedPlayer.PersonalInfo.NameOfPerson.Last = playerLastName;

        //        //Output path & file
        //    string xmlPath = @"C:\Users\dgmsm\Source\Repos\SmileyFtW\NextGenGolfLeagueApplication\GLA\DataIO\DataIOTemp\";
        //    string xmlFileName = "TempPlayersXMLOutput.xml";
        //    string fullXmlPath = xmlPath + "\\" + xmlFileName;

        //        //Serialization
        //        //Create instance of XML Serializer
        //    XmlSerializer serializer = new XmlSerializer(serializedPlayer.GetType());
        //        // Create an instance of System.IO.TextWriter 
        //        // to save the serialized object to disk
        //    TextWriter textWriter = new StreamWriter(fullXmlPath);
            
        //    //Act
        //        // Serialize the player object
        //    serializer.Serialize(textWriter, serializedPlayer);
        //    textWriter.Close();

        //    //Deserialize the xml
        //    // Create an instance of System.IO.TextReader 
        //    // to load the serialized data from disk
        //    TextReader textReader = new StreamReader(fullXmlPath);

        //    // Assign the deserialized object to the deserializedPlayersCollection object
        //    Player deserializedPlayer;
        //    deserializedPlayer = (Player)serializer.Deserialize(textReader);
        //    textReader.Close();


        //    //Assert
        //    Assert.AreEqual(serializedPlayer, deserializedPlayer);

        //}


        //[Test]
        //public void PlayerCollection_SerializationOfOnePlayer_ReturnsValidOnePlayerXML()
        //{
        //    //Arrange
        //        //Player info
        //    string playerFirstName = "David";
        //    string playerLastName = "Miley";
        //    string playerIDprefix = "Pre";
        //    string playerIDsep = "Sep";
        //    int playerIDseqNumber = 1;
        //    int playerIDnumDigits = 3;

        //        //Player object
        //    Player player = new Player(playerIDprefix,playerIDsep,playerIDseqNumber,playerIDnumDigits);
        //    player.PersonalInfo.NameOfPerson.First = playerFirstName;
        //    player.PersonalInfo.NameOfPerson.Last = playerLastName;

        //        //Players Collection Serialization
        //    Players serializedPlayersCollection = new Players();
        //    serializedPlayersCollection.AddPlayer(player);
        //    Players deserializedPlayersCollection = new Players();

        //        //Output path & file
        //    string xmlPath = @"C:\Users\dgmsm\Source\Repos\SmileyFtW\NextGenGolfLeagueApplication\GLA\DataIO\DataIOTemp\";
        //    string xmlFileName="TempPlayersXMLOutput.xml";
        //    string fullXmlPath = xmlPath + "\\" + xmlFileName;

        //        //Serialization
        //            //Create instance of XML Serializer
        //    XmlSerializer serializer = new XmlSerializer(serializedPlayersCollection.GetType());
        //    // Create an instance of System.IO.TextWriter 
        //    // to save the serialized object to disk
        //    TextWriter textWriter = new StreamWriter(fullXmlPath);

        //    //Act
        //        // Serialize the employeeList object
        //    serializer.Serialize(textWriter, serializedPlayersCollection);
        //    textWriter.Close();

        //        //Deserialize the xml
        //            // Create an instance of System.IO.TextReader 
        //            // to load the serialized data from disk
        //    TextReader textReader = new StreamReader(fullXmlPath);

        //            // Assign the deserialized object to the deserializedPlayersCollection object
        //    deserializedPlayersCollection = (Players)serializer.Deserialize(textReader);
        //    textReader.Close();


        //    //Assert
        //    Assert.AreEqual(serializedPlayersCollection, deserializedPlayersCollection);
        //}

    }
}
