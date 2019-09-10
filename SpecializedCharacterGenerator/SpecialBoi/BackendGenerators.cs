using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpecialBoi
{
    class BackendGenerators
    {
        public static Dictionary<string, string> Feats = new Dictionary<string, string>();
        public static Dictionary<string, string> Races = new Dictionary<string, string>();
        public static Dictionary<string, string> Classes = new Dictionary<string, string>();
        public static Dictionary<string, string> Backgrounds = new Dictionary<string, string>();
        public static Dictionary<string, string> Priorites = new Dictionary<string, string>();

        public static void StartUp()
        {
            //read the files in
            string[] feats = File.ReadAllLines("feats.txt");
            string[] races = File.ReadAllLines("races.txt");
            string[] classes = File.ReadAllLines("classes.txt");
            string[] backgrounds = File.ReadAllLines("backgrounds.txt");
            string[] priorities = File.ReadAllLines("priorities.txt");

            //sort the arrays
            Array.Sort(feats);
            Array.Sort(races);
            Array.Sort(classes);
            Array.Sort(backgrounds);
            Array.Sort(priorities);

            string tempKey;
            string tempEntry;

            //convert the arrays into usable dictionaries
            foreach (string i in feats)
            {
                tempKey = i.Substring(0, i.IndexOf("|"));
                tempEntry = i.Substring(i.IndexOf("|") + 1);

                Feats.Add(tempKey, tempEntry);
            }
            foreach (string i in races)
            {
                tempKey = i.Substring(0, i.IndexOf(","));
                tempEntry = i.Substring(i.IndexOf(",") + 1);

                Races.Add(tempKey, tempEntry);
            }
            foreach (string i in classes)
            {
                tempKey = i.Substring(0, i.IndexOf(","));
                tempEntry = i.Substring(i.IndexOf(",") + 1);

                Classes.Add(tempKey, tempEntry);
            }
            foreach (string i in backgrounds)
            {
                tempKey = i.Substring(0, i.IndexOf(","));
                tempEntry = i.Substring(i.IndexOf(",") + 1);

                Backgrounds.Add(tempKey, tempEntry);
            }
            foreach (string i in priorities)
            {
                tempKey = i.Substring(0, i.IndexOf(","));
                tempEntry = i.Substring(i.IndexOf(",") + 1);

                Priorites.Add(tempKey, tempEntry);
            }
        }

        public static string getSubClassType(string Class)
        {
            switch (Class)
            {
                case "Barbarian":
                    return "Path of the";
                case "Bard":
                    return "College of";
                case "Cleric":
                    return "Domain of";
                case "Druid":
                    return "Circle of the";
                case "Fighter":
                    return "Archetype:";
                case "Monk":
                    return "Way of the";
                case "Paladin":
                    return "Oath of";
                case "Ranger":
                    return "Archetype:";
                case "Rogue":
                    return "Archetype:";
                case "Sorcerer":
                    return "Origin:";
                case "Warlock":
                    return "Patron:";
                case "Wizard":
                    return "School of";
                default:
                    return "Subclass:";
            }

        }

        private static int[] characterRoller()
        {

            //variables
            int[] roll1 = new int[4];
            int[] roll2 = new int[4];
            int[] roll3 = new int[4];
            int[] roll4 = new int[4];
            int[] roll5 = new int[4];
            int[] roll6 = new int[4];
            int i = 0;

            int[] rolls = new int[6];

            Random die = new Random();

            //roll 4d6 6 times
            for (i = 0; i < 4; i++)
            {
                roll1[i] = die.Next(1, 7);
            }

            for (i = 0; i < 4; i++)
            {
                roll2[i] = die.Next(1, 7);
            }

            for (i = 0; i < 4; i++)
            {
                roll2[i] = die.Next(1, 7);
            }

            for (i = 0; i < 4; i++)
            {
                roll3[i] = die.Next(1, 7);
            }

            for (i = 0; i < 4; i++)
            {
                roll4[i] = die.Next(1, 7);
            }

            for (i = 0; i < 4; i++)
            {
                roll5[i] = die.Next(1, 7);
            }

            for (i = 0; i < 4; i++)
            {
                roll6[i] = die.Next(1, 7);
            }

            //sort the unadjusted arrays
            Array.Sort(roll1);
            Array.Sort(roll2);
            Array.Sort(roll3);
            Array.Sort(roll4);
            Array.Sort(roll5);
            Array.Sort(roll6);

            //sum the top 3 and add them to the arraylist
            rolls[0] = roll1[1] + roll1[2] + roll1[3];
            rolls[1] = roll2[1] + roll2[2] + roll2[3];
            rolls[2] = roll3[1] + roll3[2] + roll3[3];
            rolls[3] = roll4[1] + roll4[2] + roll4[3];
            rolls[4] = roll5[1] + roll5[2] + roll5[3];
            rolls[5] = roll6[1] + roll6[2] + roll6[3];

            Array.Sort(rolls);

            return rolls;

        }

        private static void setPriorities(string clas, string subclass)
        {
            switch (clas)
            {
                
            }
        }
    }
}
