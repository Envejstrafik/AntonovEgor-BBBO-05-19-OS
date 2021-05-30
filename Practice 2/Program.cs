using System;
using System.Threading;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;


namespace Practice_2
{
  public class Streams
  {
    public int numberStream;
    public int countStreamTries;
    public Streams() { }
  }
  class Program
  {
    public static int countOfStreams;
    public static string[] hashes = new string[3];
    static void Main(string[] args)
    {
      hashes[0] = "1115dd800feaacefdf481f1f9070374a2a81e27880f187396db67958b207cbad";
      hashes[1] = "3a7bd3e2360a3d29eea436fcfb7e44c735d117c42d1c1835420b6b9942dd4f1b";
      hashes[2] = "74e1bb62f8dabb8125a58852b63bdf6eaef667cb56ac7f7cdba6d7305c50a22f";

      Console.WriteLine("Будет выполнен брутфорс паролей по следующим хешам: ");
      for (int i = 0; i < 3; i++)
      {
        Console.WriteLine($"{i + 1}. {hashes[i]}");
      }
      Console.WriteLine();
      Console.Write("Выберите количество потоков (1-26): ");
      countOfStreams = Convert.ToInt32(Console.ReadLine());

      List<Thread> threads = new List<Thread>();
      List<Streams> streams = new List<Streams>();

      if ((countOfStreams >= 1) && (countOfStreams <= 26))
      {
        int countStreamTries = 26 / countOfStreams;
        int countStreamMOD = 26 % countOfStreams;

        for (int i = 0; i < countOfStreams; i++)
        {
          threads.Add(new Thread(new ParameterizedThreadStart(tBrootforce)));
          streams.Add(new Streams());
          streams[i].countStreamTries = countStreamTries;
          streams[i].numberStream = i;
          if (countStreamMOD >= 1)
          {
            streams[i].countStreamTries++;
            countStreamMOD--;
          }
          threads[i].Start(streams[i]);
        }
      }
    }


    public static void tBrootforce(object Object)
    {
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      char[] pass = new char[5];
      string password;
      string newHash;
      Streams stream = (Streams)Object;

      for (int i = 0; i < stream.countStreamTries; i++)
        for (int j = 97; (j <= 122); j++)
          for (int k = 97; (k <= 122); k++)
            for (int l = 97; (l <= 122); l++)
              for (int m = 97; (m <= 122); m++)
              {
                pass[0] = Convert.ToChar(97 + stream.numberStream + i * countOfStreams);
                pass[1] = Convert.ToChar(j);
                pass[2] = Convert.ToChar(k);
                pass[3] = Convert.ToChar(l);
                pass[4] = Convert.ToChar(m);
                password = new string(pass);
                //    Console.WriteLine(password);
                newHash = getHash(password);

                for (int n = 0; n < 3; n++)
                {
                  if (newHash == hashes[n])
                  {
                    Console.WriteLine($"pass: {password}");
                    Console.WriteLine($"hash: {newHash}");
                    Console.WriteLine($"pwned for {stopwatch.ElapsedMilliseconds} ms. in stream #{stream.numberStream}");
                  }
                  Thread.Sleep(0);
                }

              }
    }


    public static string getHash(string text) // Функция взята из открытых источников
    {
      byte[] data = Encoding.Default.GetBytes(text);
      var result = new SHA256Managed().ComputeHash(data);
      return BitConverter.ToString(result).Replace("-", "").ToLower();
    }
  }
}
