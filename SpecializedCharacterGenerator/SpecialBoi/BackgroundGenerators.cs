using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SpecialBoi
{
    class BackgroundGenerators
    {
        private static Dictionary<string, string> Feats = new Dictionary<string, string>();
        private static Dictionary<string, string> Races = new Dictionary<string, string>();
        private static Dictionary<string, string> Classes = new Dictionary<string, string>();
        private static Dictionary<string, string> Backgrounds = new Dictionary<string, string>();

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
                tempKey = i.Substring(0, i.IndexOf(",") + 1);
                tempEntry = i.Substring(i.IndexOf(",") + 1);

                Classes.Add(tempKey, tempEntry);
            }
            foreach (string i in backgrounds)
            {
                tempKey = i.Substring(0, i.IndexOf(",") + 1);
                tempEntry = i.Substring(i.IndexOf(",") + 1);

                Backgrounds.Add(tempKey, tempEntry);
            }
        }
    }
}
