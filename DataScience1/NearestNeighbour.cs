using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class NearestNeighbour
    {
        static int i = 0;

        public static void calculate(List<User> user1, List<User> user2, Dictionary<int, List<User>> dictionary) {

            Console.WriteLine("Target user is: " + user1[0].ID);
            foreach (var item in user2)
            {
                Console.WriteLine("User: " + user2[i].ID + " " + Euclidian.CalculateEuclidian(dictionary, user1, user2));
                i++;
            }
            Console.ReadLine();
        }
    }
}
