using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Query
    {
        private static int selecteduser;
        private static List<User> userlist= new List<User>();
        public static List<User> ChooseUser(Dictionary<int, List<User>> dictionary) {
            Console.WriteLine("Choose user");
            selecteduser = int.Parse(Console.ReadLine());
            var user = dictionary[selecteduser];

            return user;
        }
        public static List<User> OtherUsers(Dictionary<int, List<User>> dictionary) {

            var users = from n in dictionary
                        where n.Key != selecteduser
                        select n;

            foreach (KeyValuePair<int, List<User>> pair in users)
            {
                int i = 0;
                userlist.Add(pair.Value[i]);
                i++;
            }
            return userlist;

        }
    }
}
