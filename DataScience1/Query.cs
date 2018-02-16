using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Query
    {
        public static List<User> query(Dictionary<int, List<User>> dictionary) {
            Console.WriteLine("Choose user");
            int selecteduser = int.Parse(Console.ReadLine());
            var user = dictionary[selecteduser];

            return user;
        }
    }
}
