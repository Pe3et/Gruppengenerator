using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Gruppengenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Aaron Boeck",
                              "Alexander Noel",
                              "Christopher Bendel",
                              "Ekhard Seer",
                              "Ezequiel Kovar Bodasiuk",
                              "Felix Martin",
                              "Hannes Kühl",
                              "Jakob Warmholdt",
                              "Jessica Ludwig",
                              "Johannes Schiemacher",
                              "Lucas Herrmann",
                              "Matthias Brasch",
                              "Michael Kehnscherper",
                              "Paul Garno",
                              "Paul Rutkiewitz",
                              "Stanislav Kovalenko",
                              "Theodor Gaede",
                              "Till Sieling",
                              "Peter Wolf",
                              };
            Random r = new Random();
            Console.WriteLine("Gruppengröße:");
            int groupsize = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            File.Delete(@"gruppen.txt");
            TextWriter tw = new StreamWriter(@"gruppen.txt");
            int groupcount = names.Length / groupsize; 
            for (int j = 0; j < groupcount; j++)
            {
                Console.WriteLine("Gruppe " + (j+1)+":");
                tw.WriteLine("Gruppe " + (j+1)+":");
                for (int i = 0; i < groupsize; i++)
                            {
                                int random = r.Next(names.Length);
                                if (names[random]!="0")
                                {
                                    Console.WriteLine(names[random]);
                                    tw.WriteLine(names[random]);
                                    names[random] = "0";
                                }
                                else { i--; }
                            }
                Console.WriteLine();
                tw.WriteLine();
            }
            Console.WriteLine("Übrig:");
            tw.WriteLine("Übrig:");
            foreach (string name in names)
            {
                if (name != "0")
                {
                    Console.WriteLine(name);
                    tw.WriteLine(name);
                }
            }
            Console.WriteLine("\nDie Gruppen sind in der Datei 'gruppen.txt' abgespeichert.");
            tw.Close();
            Console.Read();
        }
    }
}
