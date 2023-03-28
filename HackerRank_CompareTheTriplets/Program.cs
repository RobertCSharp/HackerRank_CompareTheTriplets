using System;
using System.Collections.Generic;

namespace HackerRank_CompareTheTriplets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",CompareTriplets (new List<int>(){ 17, 28, 30 }, new List<int>(){ 99, 16, 18 })));
        }

        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int>();

            int counterAlice = 0;
            int counterBob = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    counterAlice++;
                }

                if (b[i] > a[i])
                {
                    counterBob++;
                }
            }

            result.Add(counterAlice);
            result.Add(counterBob);

            return result;
        }
    }
}
