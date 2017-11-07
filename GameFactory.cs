using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace NewLab2
{
    public class GameFactory
    {
        public List<Game> gameList;
        StreamWriter writer;
        XmlSerializer serial;


        public String FilePath { get; set; }

        public void createGameList()
        {
            gameList = new List<Game>();

            gameList.Add(new Game("Flies", 12, "Beetles", 23));
            gameList.Add(new Game("Flies", 53, "Beetles", 64));
            gameList.Add(new Game("Flies", 43, "Beetles", 44));
            gameList.Add(new Game("Flies", 64, "Beetles", 75));
            gameList.Add(new Game("Flies", 33, "Beetles", 43));
            gameList.Add(new Game("Flies", 90, "Beetles", 12));
        }

        public Boolean serializeGameList()
        {
            try
            {
                serial = new XmlSerializer(gameList.GetType());
                writer = new StreamWriter(@"..\..\game.xml");
                serial.Serialize(writer, gameList);
                writer.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
