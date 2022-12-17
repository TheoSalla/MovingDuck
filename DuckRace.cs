using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuckArt
{
    public class DuckRace
    {
        private static readonly object consoleLock = new object();



        public void RunningDuck(int position)
        {
            lock (consoleLock)
            {
                Console.CursorTop = position;
                string duck = @"
     __
 ___( o)>
 \ <_. )
  `---'
";

                List<string> s = duck.Split('\n').ToList();

                int start = 0;
                while (true)
                {
                    foreach (var item in s)
                    {
                        Console.CursorLeft += start;

                        Thread.Sleep(1);
                        System.Console.WriteLine(item);
                    }
                    Thread.Sleep(1000);
                    Console.Clear();
                    start += 5;
                }
            }
        }
    }
}