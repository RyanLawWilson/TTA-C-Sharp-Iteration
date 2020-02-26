using System;
using System.Collections.Generic;

// Page 137

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] > 85)
                {
                    Console.WriteLine("Passing test score " + testScores[i]);
                }
            }

            string[] names = { "Jesse", "Ryan", "Bob Guy", "Adam" };
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "Jesse")
                {
                    Console.WriteLine(names[i]);
                }
            }

            Console.Read();
        }
    }
}
