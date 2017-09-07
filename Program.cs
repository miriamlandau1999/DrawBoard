using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14_2_
{
    class Program
    {   static int x = Console.WindowWidth / 2;
        static int y = Console.WindowHeight / 2;
        static bool flag = true;
        static bool keepGoing = true;
        static List<int> list = new List<int>();
        static int entry;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Instructions:");
            Console.WriteLine("Use the arrow keys to draw your design");
            Console.WriteLine("Press the R Key to replay your design");
            Console.WriteLine("Press esc to stop");
            Console.WriteLine("Press G for green, B for blue, and Y for yellow");
            Console.SetCursorPosition(x, y);
            
            while (keepGoing)
            {
                entry = (GetKeyPress());
                prompt(entry);
                createList();
            }
        }
        static void prompt(int entry)
        {
            if(entry == 37)
            {
                x--;
                Console.SetCursorPosition(x, y);
                print();
            }
            else if (entry == 39)
            {
                x++;
                Console.SetCursorPosition(x, y);
                print();
            }
            else if (entry == 40)
            {
                y++;
                Console.SetCursorPosition(x, y);
                print();
            }
            else if (entry == 38)
            {
                y--;
                Console.SetCursorPosition(x, y);
                print();
            }
            else if (entry == 71)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (entry == 66)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (entry == 89)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (entry == 27)
            {
                keepGoing = false; 
            }
            else if(entry == 80)
            {
                flag = !flag;
            }
            else if(entry == 82)
            {
                replay(list);
            }
            
        }
        static void print()
        {
            if(flag)
            {
                Console.Write("*");
            }
        }
        static int GetKeyPress()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            return (int)key.Key;
        }
        static void replay(List<int> replay)
        {
            Console.Clear();
            resetVariables();
            for(int i = 0; i < replay.Count; i++)
            {
                System.Threading.Thread.Sleep(200);
                prompt(replay[i]);
            }
        }
        static void resetVariables()
        {
            x = Console.WindowWidth / 2;
            y = Console.WindowHeight / 2;
        }
        static void createList()
        {
            if (entry != 82)
            {
                list.Add(entry);
            }
        }
    }
}
