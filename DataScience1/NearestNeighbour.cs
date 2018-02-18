using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class NearestNeighbour
    {

        public static void calculate(List<double> similarity) {

            foreach (var item in similarity)
            {
                Console.WriteLine("Similarity = " + item);
            }
        }
    }
}
