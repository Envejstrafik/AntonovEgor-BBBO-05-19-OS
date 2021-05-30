using System;
using System.Collections.Generic;

namespace Practice_5
{
  class Program
  {
    static int maxMemForCell = 16384; // Количество памяти на одну ячейку
    static int cellCount = 4; // Количество ячеек памяти
    static int[] cellsOfProcesses = new int[cellCount]; // Массив ячеек памяти

    static List<Tuple<int, int>> process = new List<Tuple<int, int>>();
    static List<int> queue = new List<int>();
    static void Main(string[] args)
    {
      for (int i = 0; i < cellCount; i++)
      {
        cellsOfProcesses[i] = maxMemForCell; // Задание максимальной памяти в начале для каждой ячейки
      }
      while (true)
      {
        if (Menu() == -1) break;
      }
    }
    static int Menu()
    {
      Console.Clear();
      Console.WriteLine("----Меню----");
      Console.WriteLine("1. Добавить процесс");
      Console.WriteLine("2. Удалить процесс");
      Console.WriteLine("3. Информация о процессах");
      Console.WriteLine("4. Информация о памяти");
      Console.WriteLine("5. Выход"); Console.WriteLine();
      Console.Write("Ваш выбор: ");
      int choise;
      try
      {
        choise = Convert.ToInt32(Console.ReadLine());
      }
      catch
      {
        return 0;
      }
      
      switch (choise)
      {
        case 1:
          addProcess();
          break;
        case 2:
          deleteProcess();
          break;
        case 3:
          Console.Clear();
          infoProcess();
          break;
        case 4:
          infoMemory();
          break;
        case 5:
          return -1;
      }
      return 0;
    }
    static void addProcess()
    {
      int memory;
      while (true)
      {
        Console.Clear();
        Console.Write("Введите количество памяти на процесс: ");
        try
        {
          memory = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.Write("Вы ввели неверное значение...");
          Console.ReadKey();
          continue;
        }
        if(memory > maxMemForCell || memory < 1)
        {
          Console.Write($"Значение должно быть в диапазоне от 1 до {maxMemForCell}...");
          Console.ReadKey();
          continue;
        }
        break;
      }
      for(int i = 0; i < cellCount; i++)
      {
        if (cellsOfProcesses[i] == maxMemForCell) // Если в ячейке максимум свободной памяти, то процесс запустится в ней
        {
          cellsOfProcesses[i] = cellsOfProcesses[i] - memory;
          Console.WriteLine($"Процесс {memory} запущен в ячейке {i}");
          
          try // try-catch блок для исключения ошибки index out of range
          {
            if (process[i].Item2 == -5)// Маркер ранее удалённой и не заполненной ячейки (см. функцию удаления)
            {
              process.RemoveAt(i);
              process.Insert(i, new Tuple<int, int>(memory, i));
            }
          }
          catch
          {
            process.Add(new Tuple<int, int>(memory, i));
          }
          
          Console.Clear();
          infoProcess();
          break;
        } else if (i == cellCount - 1)
        {
//          Console.ReadLine();
          Console.WriteLine($"Процесс {memory} добавлен в ячейку очереди");
          queue.Add(memory);
          Console.Clear();
          infoProcess();
        }
      }
    }
    static void infoProcess()
    {
      Console.WriteLine("----Список процессов в работе----");
      if(process.Count == 0)
      {
        Console.WriteLine("Процессы отсутствуют");
      } else
      for (int i = 0; i < process.Count; i++)
      {
       if(process[i].Item1 != maxMemForCell)
        Console.WriteLine($"Ячейка {process[i].Item2+1}: процесс на {process[i].Item1} байт");
       else
        Console.WriteLine($"Ячейка свободна");
       }
      Console.WriteLine();
      Console.WriteLine("----Список процессов в очереди----");
      if (process.Count == 0)
      {
        Console.WriteLine("Процессы отсутствуют");
      } else 
      for (int i = 0; i < queue.Count; i++)
      {
          Console.WriteLine($"{i+1}. Процесс {queue[i]}");
      }
      Console.ReadKey();
    }
    static void infoMemory()
    {
      Console.Clear();
      Console.WriteLine("----Информация о памяти----");
      for(int i = 0; i < cellCount; i++)
      {
        if (cellsOfProcesses[i] == maxMemForCell)
        {
          Console.WriteLine($"Ячейка {i + 1} свободна");
        } 
        else Console.WriteLine($"Ячейка {i + 1} - {cellsOfProcesses[i]} байт");
      }
      Console.ReadKey();
    }
    static void deleteProcess()
    {
      int numOfCell; // номер удаляемой ячейки
      while (true)
      {
        Console.Clear();
        infoProcess();
        Console.Write("Введите номер ячейки, из которой хотите удалить процесс: ");
        try
        {
          numOfCell = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
          Console.Write("Вы ввели неверное значение...");
          Console.ReadKey();
          continue;
        }
        if (numOfCell > cellCount || numOfCell < 1)
        {
          Console.Write($"Значение должно быть в диапазоне от 1 до {cellCount}...");
          Console.ReadKey();
          continue;
        }
        break;
      }
      cellsOfProcesses[numOfCell-1] = maxMemForCell; // "Освобождение памяти" в ячейке
      process.RemoveAt(numOfCell-1); // Удаление процесса
      if (queue.Count != 0)
      { //Если в очереди что-то есть, то оно вставляется на место удаленного процесса
        process.Insert(numOfCell - 1, new Tuple<int, int>(queue[0], numOfCell - 1)); 
        queue.RemoveAt(0); // Первый процесс из очереди удаляется
      } else
        process.Insert(numOfCell - 1, new Tuple<int, int>(maxMemForCell, -5)); // Отрицательный номер ячейки (-5) используется как маркер пустой ячейки

    }
  }
}
