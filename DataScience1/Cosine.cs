using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Cosine
    {
        private static double distance;
        private static double part1;
        private static double part2;
        private static double part3;
        public static double CalculateCosine(Dictionary<int, List<User>> dictionary)
        {

            var user1 = Query.query(dictionary);
            var user2 = Query.query(dictionary);

            foreach (var item1 in user1)
            {
                part2 += Math.Pow(item1.Rating, 2);
                foreach (var item2 in user2.Where(x => x.Article == item1.Article))
                {
                    part1 += (item1.Rating * item2.Rating);
                    part3 += Math.Pow(item2.Rating, 2);
                }
            }
            distance = part1 / (Math.Sqrt(part2) * Math.Sqrt(part3));


            return distance;
        }
    }
}
