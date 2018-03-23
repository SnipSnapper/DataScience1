using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Neighbour
    {
        public int ID { get; set; }
        public Dictionary<int, double> ratings { get; set; }
        public double sim { get; set; }
    }
}
