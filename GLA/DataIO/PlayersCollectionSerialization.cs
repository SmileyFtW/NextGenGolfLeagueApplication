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
    class PlayersCollectionSerialization
    {
        [XmlArray("PlayerListing")]
        [XmlArrayItem("Player", typeof(Player))]

        public Hashtable Players { get; }
        public string FilePath { get; private set; }
        public string FileName { get; private set; }

        //Constructor
        public PlayersCollectionSerialization(Hashtable players)
        {
            Players = players;

        }

        public void SerializePlayersCollection(string outputFilePath, string outputFileName)
        {
            if (Players.Count > 0)
            {
                FilePath = outputFilePath;
                FileName = outputFileName;

                XmlSerializer serializer = new XmlSerializer(Players.GetType());
                TextWriter textwriter = new StreamWriter(outputFilePath + "/" + outputFileName + ".xml");
                serializer.Serialize(textwriter, Players);
                textwriter.Close();
            }
        }

        public Hashtable DeserializePlayersCollection()
        {
            
            //TODO - write the code to get the file and turn it into a HaashTable
            Hashtable result=new Hashtable();
            return result;
        }
    }


}
