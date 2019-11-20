using System;
using System.Collections.Generic;

namespace LivecodeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> sampleDict = new Dictionary<string, int>();
            Dictionary<string, int> longRepeat(string sample)

            {
                string[] sampleArr = sample.Split();

                for (int i = 0; i < sample.Length; i++)
                {
                    int k = 0;
                    for (int j = 0; j < sample.Length; j++)
                    {
                        if (sampleArr[i] == sampleArr[j])
                        {
                            sampleDict.Add(sampleArr[i], k + 1);

                        }

                    }

                }
                return sampleDict;
            }
            Console.WriteLine("The string is 'aaa' and result is: " + longRepeat("aaa"));

        }
    }
}
