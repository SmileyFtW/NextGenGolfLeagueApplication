using GLA.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace GLA.DataIO
{
    [XmlRoot("GolfLeaguePlayers")]
    class PlayersCollection
    {
        [XmlArray("PlayerListing")]
        [XmlArrayItem("Player", typeof(Player))]

        public Hashtable Players { get; }

        //Constructor
        public PlayersCollection(Hashtable players)
        {
            Players = players;
        }

        public void SerializePlayersCollection(string outputFilePath, string outputFileName)
        {
            if (Players.Count > 0)
            {
                XmlSerializer serializer = new XmlSerializer(Players.GetType());
                TextWriter textwriter = new StreamWriter(outputFilePath + "/" + outputFileName + ".xml");
                serializer.Serialize(textwriter, Players);
                textwriter.Close();
            }
        }

        public Hashtable DeserializePlayersCollection(string filePath, string fileName)
        {
            Hashtable result=new Hashtable();
            return result;
        }
    }


}
