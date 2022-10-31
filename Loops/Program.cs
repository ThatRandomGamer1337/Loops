using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - - - - -
            int start = 0;
            int end = 4;

            int i = start;

            int[] ammo = new int[5]; // Array
            ammo[0] = 6;
            ammo[1] = 2;
            ammo[2] = 25;
            ammo[3] = 60;
            ammo[4] = 10;

            // - - - - -

            while (i <= end) // Loop
            {
                Console.WriteLine("Weapon #" + i + ": " + ammo[i]);
                i = i + 1;
            }

            Console.WriteLine();
            Console.ReadKey(true);

        }

    }
}
