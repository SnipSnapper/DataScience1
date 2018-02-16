using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Euclidian
    {
        static double distance;
        static double calculatedDistance;
        public static double CalculateEuclidian(Dictionary<int, List<User>> dictionary) {

            var user1 = Query.query(dictionary);
            var user2 = Query.query(dictionary);

            foreach (var item in user1)
            {
                foreach (var items in user2.Where(x => x.Article == item.Article))
                {
                    distance += Math.Pow((item.Rating - items.Rating),2);
                }
            }
            calculatedDistance = 1 / (1 + Math.Sqrt(distance));
            return calculatedDistance;
        }

    }
}
