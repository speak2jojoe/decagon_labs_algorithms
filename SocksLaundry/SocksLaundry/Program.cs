using System;

namespace SocksLaundry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SocksLaundry");
        }

        // function that given the `noOfWashes`, `cleanPile`, and `dirtyPile` returns the maximum number of pair of socks
        public static int maximumNumberOfPairOfSocks(int noOfWashes, int[] cleanPile, int[] dirtyPile)
        {
            int count = 0;
            for(int i = 1; i <= noOfWashes; i++)
            {
                if (dirtyPile[i] == 0)
                    count++;
            }
            return count;
        }
    }    
}
