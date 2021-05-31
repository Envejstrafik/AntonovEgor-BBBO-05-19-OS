using System;
using System.Collections.Generic;
using System.Threading;

namespace Practice_4
{
  class Program
  {
    static List<Thread> threads = new List<Thread>();

    static bool t1_isSleep, t2_isSleep, t3_isSleep;


    static void progModule1()
    {
      string alpha;
      for(UInt64 i = UInt64.MinValue; i < UInt64.MaxValue; i++)
        for (UInt64 j = UInt64.MinValue; j < UInt64.MaxValue; j++)
          for (UInt64 k = UInt64.MinValue; k < UInt64.MaxValue; k++)
            for (UInt64 l = UInt64.MinValue; l < UInt64.MaxValue; l++)
              for (UInt64 m = UInt64.MinValue; m < UInt64.MaxValue; m++)
              {
                alpha = Convert.ToString(i);
                alpha = Convert.ToString(j);
                alpha = Convert.ToString(k);
                alpha = Convert.ToString(l);
                alpha = Convert.ToString(m);
              }
    }
    static void progModule2()
    {
      string betta;
      for (UInt32 i = UInt32.MinValue; i < UInt32.MaxValue; i++)
        for (UInt32 j = UInt32.MinValue; j < UInt32.MaxValue; j++)
          for (UInt32 k = UInt32.MinValue; k < UInt32.MaxValue; k++)
            for (UInt32 l = UInt32.MinValue; l < UInt32.MaxValue; l++)
              for (UInt32 m = UInt32.MinValue; m < UInt32.MaxValue; m++)
              {
                betta = Convert.ToString(i);
                betta = Convert.ToString(j);
                betta = Convert.ToString(k);
                betta = Convert.ToString(l);
                betta = Convert.ToString(m);
              }
    }
    static void progModule3()
    {
      string gamma;
      for (UInt16 i = UInt16.MinValue; i < UInt16.MaxValue; i++)
        for (UInt16 j = UInt16.MinValue; j < UInt16.MaxValue; j++)
          for (UInt16 k = UInt16.MinValue; k < UInt16.MaxValue; k++)
            for (UInt16 l = UInt16.MinValue; l < UInt16.MaxValue; l++)
              for (UInt16 m = UInt16.MinValue; m < UInt16.MaxValue; m++)
              {
                gamma = Convert.ToString(i);
                gamma = Convert.ToString(j);
                gamma = Convert.ToString(k);
                gamma = Convert.ToString(l);
                gamma = Convert.ToString(m);
              }
    }
    
    
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
