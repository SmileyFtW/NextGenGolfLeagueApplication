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
    [XmlRoot("Players")]
    public class Players
    {
        [XmlArray("PlayerListing")]

        [XmlArrayItem("Player", typeof(Player))]
        public Hashtable playerList;

        //public Hashtable Players { get; }
        //public string FilePath { get; }
        //public string FileName { get; }

        //Constructor
        public Players()
        {
            playerList = new Hashtable();
        }
        
        public void AddPlayer(Player player)
        {
            playerList.Add(player.IDItem.ID.ToString(),player);
        }

        //public void SerializePlayersCollection(Hashtable players, string filePath, string fileName)
        //{
        //    if (players.Count > 0)
        //    {
        //        XmlSerializer serializer = new XmlSerializer(players.GetType());
        //        TextWriter textwriter = new StreamWriter(filePath + "\\" + fileName + ".xml");
        //        serializer.Serialize(textwriter, players);
        //        textwriter.Close();
        //    }
        //}

        //public Hashtable DeserializePlayersCollection(string filePath, string fileName)
        //{
        //    //TODO - make sure the file exists
        //    //TODO - write the code to get the file and turn it into a HashTable
        //    Hashtable result=new Hashtable();
        //    XmlSerializer serializer = new XmlSerializer(result.GetType());
        //    TextReader textReader = new StreamReader(filePath + "\\" + fileName + ".xml");
        //    result = (Players)serializer.Deserialize(textReader); //Deserialize(textReader);

        //    return result;
        //}
    }


}
