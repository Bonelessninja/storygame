using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storygame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Times up...");
            Console.WriteLine("BONENINJA entertainment");
            Console.WriteLine("");
            Console.WriteLine("you enter a door to a hall. " +
 "The door locks behind you are in what looks to be a room with a vent." +
 " The lights turn off,  you go to the vent and enter through it you enter a bigger hall with red flashing lights and a table knocked over. " +
 "     Where do you go from here? ");
            Console.WriteLine("");
            A();
            Console.ReadKey();
        }
        static void A()
        {
            Console.Write("A1 - back from where you came. ");
            Console.Write("B2 -  continue down the hall. ");
            Console.Write("C1 – look around the vent. ");

        }
    }
}
