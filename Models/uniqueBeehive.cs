using System;
using System.Collections.Generic;

namespace BeeHive.Models
{
    public class uniqueBeehive
    {
        
        public int maxQuantity { get; set; }
        public List<Bee> BeesList { get; set; }
        

        public uniqueBeehive(int maxQty)
        {
            this.BeesList = new List<Bee>();
            this.maxQuantity = maxQty;
        }

        public void CollectHoneyAmount(int days) 
        {
            float total = 0f;                   /*To initialize a float variable, use the suffix f */
            int numberDays = 2;

            for ( int i = 0 ; i < this.BeesList.Count ; ++i ) 
            {
                total += this.BeesList[i].Size * (numberDays * 0.2f);
            }

            Console.WriteLine(total);
        }
    

    }
}