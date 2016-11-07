using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsultGenerator {
    class Program {
        static void Main(string[] args) {
            Random random = new Random();
            string[] first = new string[] {"lazy", "stupid", "insecure", "idiotic", "slimy", "slutty",
                                            "smelly", "pompous", "communist", "dicknose", "pie-eating",
                                            "racist", "elitist", "white trash", "drug-loving", "butterface",
                                            "tone deaf", "ugly", "creepy"};
            string[] second = new string[] {"dounche", "ass", "turd", "rectum", "butt", "cock", "shit",
                                            "crotch", "bitch", "turd", "prick", "slut", "taint", "fuck",
                                            "dick", "boner", "shart", "nut", "sphincter"};
            string[] third = new string[] {"pilot", "canoe", "captain", "pirate", "hammer", "knob", "box",
                                            "jockey", "nazi", "waffle", "goblin", "blossum", "biscuit",
                                            "clown", "socket", "monster", "hound", "dragon", "balloon" };
            while (true) {
                Console.WriteLine(first[random.Next(first.Length)] + " " + second[random.Next(second.Length)] + " " + third[random.Next(third.Length)]);
                Console.ReadLine();
            }
        }
    }
}
