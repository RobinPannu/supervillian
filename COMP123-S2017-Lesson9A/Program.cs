using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Robin singh
 * Date: July 11, 2017
 * Description: This is the driver class for my project
 * Version: 0.5 - Implemented the SuperVillian class
 */

namespace COMP123_S2017_Lesson9A
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superHero = new SuperHero("SuperHero Dude", 20);
            superHero.Powers.Add(new Power("Teleportation",50));
            superHero.Powers.Add(new Power("Phasing", 40));
            superHero.Powers.Add(new Power("Invisibility", 30));
            Console.WriteLine(superHero.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);

            SuperVillian superVillian = new SuperVillian("SuperVillian guy",50);
            superVillian.Powers.Add(new Power("Alpha beam", 50));
            superVillian.Powers.Add(new Power("Flying", 40));
            superVillian.Powers.Add(new Power("Wind Blowing", 30));
            Console.WriteLine(superVillian.ToString());
            Console.WriteLine("Karma: " + superHero.Karma);

        }
    }
}
