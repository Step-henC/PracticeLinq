using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string> { "Call of Duty", "Grand Theft auto", "NBA2k22", "Madden", "Devil May Cry", "Final Fantasy", "Animal Crossing" };
            var answer = games.OrderBy(x => x.Length).ToList();
            for(int i = 0; i < answer.Count; i++)
            {
                Console.WriteLine(answer[i]);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
