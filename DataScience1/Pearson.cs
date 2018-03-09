using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Pearson
    {

        private static double distance;
        private static double part1;
        private static double part2;
        private static double part3;
        private static double part4;
        private static double part21;
        private static double part22;
        private static double part31;
        private static double part32;
        private static double part41;
        private static double part42;
        private static double count;

        public static double CalculatePearson(Dictionary<int, double> user1, Dictionary<int, double> user2)
        {



            foreach (var item1 in user1)
            {
                foreach (var item2 in user2.Where(x => x.Key == item1.Key))
                {
                    part1 += item1.Value * item2.Value;
                    part21 += item1.Value;
                    part22 += item2.Value;
                    part31 += Math.Pow(item1.Value, 2);
                    part32 += item1.Value; //Has to be squared later on.
                    part41 += Math.Pow(item2.Value, 2);
                    part42 += item2.Value; //Has to be squared later on.
                    count += 1;
                }
            }

            part2 = part21 * part22;
            part3 = Math.Sqrt(part31 - (Math.Pow(part32, 2) / count));
            part4 = Math.Sqrt(part41 - (Math.Pow(part42, 2) / count));

            distance = (part1 - (part2 / count)) / ((part3 * part4));
            
            return distance;
        }
    }
}
