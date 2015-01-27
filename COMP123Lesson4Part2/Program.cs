using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123Lesson4Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero myHero = new Hero(7, 8, "female");
            myHero.doesGoodThings();

          Villain  myVillian = new Villain("SpiderGirl", 9, 9, "female");
          myVillian.doesBadThings();

            //WAIT FOR INPUT BEFORE CLOSING CONSOLE
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
        
        }
    }
}
