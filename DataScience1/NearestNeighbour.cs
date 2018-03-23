using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class NearestNeighbour
    {
        private static double threshold = 0.35;
        private static List<Neighbour> nearneighbour = new List<Neighbour>();
        Neighbour neighbour = new Neighbour();
        static int i = 1;

        public static List<Neighbour> Calculate(int targetuser, Dictionary<int, Dictionary<int, double>> dictionary, Interface algo)
        {

            foreach (var item in dictionary)
            {
                if (item.Key != targetuser)
                {
                   
                    double sim = algo.Calculate(dictionary[targetuser], item.Value);

                   

                    if (sim > threshold)
                    {
                        Neighbour neighbour = new Neighbour
                        {
                            ID = item.Key,
                            ratings = item.Value,
                            sim = sim,
                        };

                        if (nearneighbour.Count() < 3)
                        {
                            nearneighbour.Add(neighbour);

                        }
                        else
                        {
                            threshold = nearneighbour.Select(x => x.sim).Min();
                            if (sim > threshold)
                            {
                                nearneighbour.Remove(nearneighbour.Find(x => x.sim == threshold));
                                nearneighbour.Add(neighbour);
                            }
                            
                        }

                    }
                    

                }

            }
            foreach (var item in nearneighbour.OrderByDescending(x => x.sim))
            {
                Console.WriteLine("Nearest Neighbour " + i + ": " + item.ID  + " with similarity: " + item.sim);
                i++;
            }

            return nearneighbour;


        }
    }
}
