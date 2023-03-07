using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averageScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double score1 = 0, score2 = 0, score3 = 0, score4 = 0, score5 = 0;
            double total = 0, average = 0;

            Console.WriteLine("Please enter score 1: ");
            score1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter score 2: ");
            score2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter score 3: ");
            score3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter score 4: ");
            score4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter score 5: ");
            score5 = Convert.ToInt32(Console.ReadLine());

            total = (score1 + score2 + score3 + score4 + score5);
            average = (total / 5);

            Console.WriteLine("Your average score is: " + average);
            Console.ReadLine();

            if (average >= 75)
            {
                Console.WriteLine("Passed");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Failed");
                Console.ReadLine();
            }
        }
    }
}