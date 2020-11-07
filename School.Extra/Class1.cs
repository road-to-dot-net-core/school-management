using System;
using System.Collections.Generic;

namespace School.Extra
{
    public class Program
    {
        static List<int> MyList = new List<int>();
        static void FillValues()
        {
            for (int i = 1; i < 10; i++)
            {
                MyList.Add(i);
            }
          
        }
        static void Main(string[] args)
        {
            FillValues();
            foreach (int j in RunningTotal())
            {
                Console.WriteLine("total:" + j);
            }
            Console.ReadLine();
        }
        static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;
            List<int> _running = new List<int>();
            foreach (int i in MyList)
            {
                runningTotal += i;
                _running.Add(runningTotal);
                //yield return (runningTotal);
            }
            return _running;
        }
    }
}
