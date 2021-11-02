using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleFileExplorer
{
    class ConsoleExplorer
    {
        public int _index = 0;

        public List<string> files = Directory.GetFileSystemEntries(".").ToList();
        public void Run()
        {
            ConsoleColor chosenindex = ConsoleColor.Cyan;
            while (true)
            {
                foreach (var item in files)
                {
                    if (File.Exists(item))
                    {

                        if (item == files[_index])
                        {
                            Console.BackgroundColor = chosenindex;
                            Console.WriteLine("-" + Path.GetFileName(item));
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.WriteLine("-" + Path.GetFileName(item));
                        }
                    }
                    else if (Directory.Exists(item))
                    {
                        if (item == files[_index])
                        {
                            Console.BackgroundColor = chosenindex;
                            Console.WriteLine("-" + Path.GetFileName(item));
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else
                        {
                            Console.WriteLine("#" + Path.GetFileName(item));
                        }   
                    }
                    
                }
                Changeindex();
                Console.Clear();
            }
        }
        public void Changeindex()
        {
            int change = 0;
            ConsoleKey choice = Console.ReadKey().Key;

            switch (choice)
            {
                case ConsoleKey.UpArrow:
                    {
                        change--;
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        change++;
                        break;
                    }
                default:
                    break;
            }

            if (_index + change >= 0 && _index + change < files.Count )
            {
                _index += change;
            }
        }
    }
}
