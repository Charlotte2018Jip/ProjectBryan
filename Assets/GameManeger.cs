
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

static class GameManager
    {[System.Serializable]
        class SaveData
        {
            public int level = 0;
            public int highscore = 0;
            public int[] levels = new int[10];
        }


        public static int level = 10;
        public static int highscore = 0;
        public static bool[] levels = new bool[4];

        static SaveData saveData = new SaveData();

    public static void loadDataToDisk()
    {

        //saveData = Newtonsoft.Json.JsonConvert.DeserializeObject<SaveData>(inputstring);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open("./gamesave.save", FileMode.Open);
        saveData = (SaveData)bf.Deserialize(file);
        file.Close();

        //saveData.level = levels[] ;

    }
        public static void saveDataToDisk()
        {
        //savedata object vullen met de gewenste data
        for (int i = 0; i < levels.Length; i++)
        {
            saveData.level = i;
        }

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create("./gamesave.save");
        bf.Serialize(file, saveData);
        file.Close();
        // savedata object omzetten naar string in json formaat. 
        //string outputString = Newtonsoft.Json.JsonConvert.SerializeObject(saveData);

        //bestand wegschrijven naar de locale file savedata.dat.
        //File.WriteAllText(@".\saveData.dat", outputString);
    }
    }