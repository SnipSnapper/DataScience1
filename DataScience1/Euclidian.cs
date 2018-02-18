using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Euclidian
    {
        private static double distance;
        private static double calculatedDistance;
        public static double CalculateEuclidian(Dictionary<int, List<User>> dictionary) {

            var user1 = Query.query(dictionary);
            var user2 = Query.query(dictionary);

            foreach (var item1 in user1)
            {
                foreach (var item2 in user2.Where(x => x.Article == item1.Article))
                {
                    distance += Math.Pow((item1.Rating - item2.Rating),2);
                }
            }
            calculatedDistance = 1 / (1 + Math.Sqrt(distance));
            return calculatedDistance;
        }

    }
}
