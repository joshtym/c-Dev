using System;
using System.Collections.Generic;

namespace c_Dev
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = System.Environment.OSVersion.ToString();
            List<int> testList = new List<int>();

            for (int i = 0; i < 10; ++i)
                testList.Add(i);

            foreach (var num in testList)
                Console.WriteLine(num);
                
            Console.WriteLine(name);
        }
    }
}
