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

        public static void StartUp()
        {
            //read the files in
            string[] feats = File.ReadAllLines("feats.txt");
            string[] races = File.ReadAllLines("races.txt");
            string[] classes = File.ReadAllLines("classes.txt");
            string[] backgrounds = File.ReadAllLines("backgrounds.txt");

            //sort the arrays
            Array.Sort(feats);
            Array.Sort(races);
            Array.Sort(classes);
            Array.Sort(backgrounds);

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
    }
}
