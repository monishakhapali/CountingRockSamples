using System;
using System.Collections.Generic;

namespace CountingRockSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int[] samples = new int[] { 345, 604, 321, 433, 704, 470, 808, 718, 517, 811 };
            int[] samples = { 400, 567, 890, 765, 987 };
            Array.Sort(samples);
            int[,] ranges = new int[,] { {300 ,380 }, { 800 ,1000 } };
           
            int r = 2; 
            List<int> count = new List<int>();
            int c = 0;
            for (int i =0; i<r;i++)
            {
                int lowbound = ranges[i,0];
                int upbound = ranges[i, 1];
                for (int j = 0; j < samples.Length; j++)
                {
                    if (samples[i] > lowbound && samples[i] < upbound)
                    {
                        c += 1;
                    }
                }
                count.Add(c);
            }
            //for(int i=0; i< samples.Length; i++)
            //{
              
            //    if(samples[i] > ranges[0,0] && samples[i]<ranges[0,1] )
            //    {
            //        count1++;
            //    }
            //    if (samples[i] > ranges[1, 0] && samples[i] < ranges[1, 1])
            //    {
            //        count2++;
            //    }

            //}
            foreach(var v in count)
            {
                Console.WriteLine(v);
            }
            Console.ReadLine();
        }
    }
}
