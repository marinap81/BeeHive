using System;
using System.Collections.Generic;
using BeeHive.Models;

namespace BeeHive
{
    class Program
    { 
        static void Main(string[] args)
        {
            /*A console application needs to created to manage some beehives.  The application needs to be able to:
               Create beehives (with bees)
                From each beehive run the CollectHoney method for a specified number of days
                Report on the number of bees in each beehive */

            Console.WriteLine("Hello World!");

             /*create new objects of Bees,*/
            Bee bee1 = new Bee("John", 3.2f);
            Bee bee2 = new Bee("Paul", 2.7f);
            Bee bee3 = new Bee("George", 1.1f);
            Bee bee4 = new Bee("Ringo", 2.0f);

            Bee bee5 = new Bee("Kurt", 2.3f);
            Bee bee6 = new Bee("Dave", 7.4f);
            Bee bee7 = new Bee("Krist", 1.5f);
            

            /*create 2 beehives to store the above bees into allocating them into either beehive'A' or beehive'B'*/

            uniqueBeehive hiveA = new uniqueBeehive(10);
            uniqueBeehive hiveB = new uniqueBeehive(20);

            hiveA.BeesList.Add(bee1);
            hiveA.BeesList.Add(bee2);
            hiveA.BeesList.Add(bee3);
            hiveA.BeesList.Add(bee4);

            hiveB.BeesList.Add(bee5);
            hiveB.BeesList.Add(bee6);
            hiveB.BeesList.Add(bee7);

            /*output the total of the function stored in unique beehive*/


            hiveA.CollectHoneyAmount(10);
            hiveB.CollectHoneyAmount(20);
            

        }
    }
}
