using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataScience1
{
    class Program
    {
        public static int number;
        public static Dictionary<int, List<User>> dictionary;

        static void Main(string[] args)
        {
            dictionary = Dictionary.ReadFile();
            ChooseStrategy();
        }
        public static void ChooseStrategy()
        {

            Console.WriteLine("What Strategy do you want to use? \nPress 1 for Euclidian \nPress 2 for Manhatten \nPress 3 for Pearson \nPress 4 for Cosine");
            number = int.Parse(Console.ReadLine());
            var user1 = Query.ChooseUser(dictionary);
            var user2 = Query.OtherUsers(dictionary);

            NearestNeighbour.calculate(user1, user2, dictionary);

            //switch (number)
            //{
            //    case 1:
            //        Console.WriteLine("you have chosen Euclidian");
            //        Console.WriteLine("The similarity is: " + Euclidian.CalculateEuclidian(dictionary));
            //        Console.ReadLine();
            //        break;
            //    case 2:
            //        Console.WriteLine("You have chosen Manhatten");
            //        Console.WriteLine("The similarity is: " + Manhatten.CalculateManhatten(dictionary));
            //        Console.ReadLine();
            //        break;
            //    case 3:
            //        Console.WriteLine("You have chosen Pearson");
            //        Console.WriteLine("The similarity is: " + Pearson.CalculatePearson(dictionary));
            //        Console.ReadLine();
            //        break;
            //    case 4:
            //        Console.WriteLine("You have chosen Cosine");
            //        Console.WriteLine("The similarity is: " + Cosine.CalculateCosine(dictionary));
            //        Console.ReadLine();
            //        break;
            //    default:
            //        Console.WriteLine("You chose something which isn't available. Program will close");
            //        Console.ReadLine();
            //        break;
            //}
        }
    }
}
