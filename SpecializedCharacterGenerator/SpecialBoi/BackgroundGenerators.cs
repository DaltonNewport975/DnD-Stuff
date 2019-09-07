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
        private Dictionary<string, string> Feats = new Dictionary<string, string>();
        private Dictionary<string, string> Races = new Dictionary<string, string>();
        private Dictionary<string, string> Classes = new Dictionary<string, string>();
        private Dictionary<string, string> Backgrounds = new Dictionary<string, string>();

        public static void StartUp()
        {
            string[] feats = File.ReadAllLines("feats.txt");
            string[] races = File.ReadAllLines("races.txt");
            string[] classes = File.ReadAllLines("classes.txt");
            string[] backgrounds = File.ReadAllLines("backgrounds.txt");
        }
    }
}
