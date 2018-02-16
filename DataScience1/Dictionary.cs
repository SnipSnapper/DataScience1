using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Dictionary
    {
        readonly static string path = "../../Data/userItem.data";
        static Dictionary<int, List<User>> dictionary = new Dictionary<int, List<User>>();

        public static Dictionary<int, List<User>> ReadFile()
        {

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    int userID = int.Parse(values[0]);
                    int article = int.Parse(values[1]);
                    double rating = double.Parse(values[2]);


                    FillDictionary(userID, article, rating);
                }

            }
            //Write();
            return dictionary;
        }

        public static Dictionary<int, List<User>> FillDictionary(int userID, int article, double rating)
        {

            if (dictionary.ContainsKey(userID))
            {
                dictionary[userID].Add(new User { ID = userID, Article = article, Rating = rating });
            }
            else
            {
                dictionary.Add(userID, new List<User>());
                dictionary[userID].Add(new User { ID = userID, Article = article, Rating = rating });
            }
            return dictionary;

        }
        public static void Write()
        {

            foreach (KeyValuePair<int, List<User>> pair in dictionary)
            {
                Console.WriteLine(pair.Key);
                foreach (var item in pair.Value)
                {
                    Console.WriteLine(" Article: {0} Rating: {1} ", item.Article, item.Rating);
                }
                Console.ReadLine();
            }
        }
    }
}
