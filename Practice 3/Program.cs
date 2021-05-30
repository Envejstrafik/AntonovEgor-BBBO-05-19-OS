using System;
using System.Threading;
using System.Collections.Generic;

namespace Practice_3
{
  class Program
  {
    static List<int> produce = new List<int>();
    static List<int> consume = new List<int>();


    static bool needToProduce = true;
    
    static void Manufacturer(object num)
    {
      bool isSleeping = false;
      int number = (int)num;

      int generatedNum = -5; // Число, генерируемое производителем

      Random rnd = new Random();
 
      while (needToProduce)
      {
        if(produce.Count >= 100)
        {
          Console.WriteLine($"Производитель №{number} спит");
          isSleeping = true;
          Thread.Sleep(1500);
          continue;
        }
        else if(produce.Count <= 80 && isSleeping)
        {
          Console.WriteLine($"Производитель №{number} просыпается");
          isSleeping = false;
          generatedNum = rnd.Next(1, 100);
          produce.Add(generatedNum);
        } 
        Console.WriteLine($"Производитель №{number} создал число {generatedNum}");
      }
      Console.WriteLine($"Производитель №{number} закончил работу");
    }
    static void Consumer(object Num)
    {
      
      bool isSleeping = false;
      int number = (int)Num;

      int consumingNum; // Число, забираемое потребителем
      while (produce.Count != 0 || needToProduce == true)
      {
        if (produce.Count == 0)
        {
          Console.WriteLine($"Потребитель №{number} спит");
          isSleeping = true;
          Thread.Sleep(1500);
          continue;
        }
        else if (isSleeping == true)
        {
          Console.WriteLine($"Потребитель №{number} просыпается");
          isSleeping = false;
        }
        if (produce.Count != 0)
        {
          consumingNum = produce[0];
          produce.RemoveAt(0);
          consume.Add(consumingNum);
          Console.WriteLine($"Потребитель №{number} взял число {consumingNum}");
          Thread.Sleep(0);
        }
        else
        {
          Thread.Sleep(0);
          continue;
        }
      }
      Console.WriteLine($"Потребитель №{number} закончил работу");
    }
    static void Main(string[] args)
    {
      char Qexit;
      List<Thread> prod = new List<Thread>();
      List<Thread> cons = new List<Thread>();

      for (int i = 0; i < 3; i++) // 3 производителя
      {
        prod.Add(new Thread(new ParameterizedThreadStart(Manufacturer)));
        prod[i].Start(i);
      }
      for (int i = 0; i < 2; i++) // 2 потребителя
      {
        cons.Add(new Thread(new ParameterizedThreadStart(Consumer)));
        cons[i].Start(i);
      }

      while (needToProduce)
      {
        Qexit = Console.ReadKey().KeyChar;
        if (Qexit == 'q')
        {
          needToProduce = false;
        }      
      }
    }
  }
}
