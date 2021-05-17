using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Practice1._3
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Введите название файла, который хотите создать (JSON): ");
      string fileName = Console.ReadLine();
      FileStream fileStream;
      try
      {
        fileStream = File.Create(fileName);
      }
      catch
      {
        Console.WriteLine("Ошибка! Введено невозможное имя для файла, или директория недоступна!");
        Console.WriteLine("Не удалось создать файл!");
        return;
      }
      Console.WriteLine("Файл создан успешно!");
      Console.ReadKey();

      Console.Write("Введите строку:");
      string strToFile = Console.ReadLine();
      byte[] input = new UTF8Encoding(true).GetBytes(strToFile);
      fileStream.Write(input, 0, input.Length);
      fileStream.Close();
      Console.WriteLine("Строка была записана в файл.");
      Console.ReadKey();

      Console.Write("Введите название файла, который хотите вывести в консоль: ");
      fileName = Console.ReadLine();
      StreamReader streamReader;
      try
      {
        streamReader = File.OpenText(fileName);
      }
      catch
      {
        Console.WriteLine("Ошибка! Введено невозможное имя для файла, или директория недоступна!");
        Console.WriteLine("Не удалось открыть файл!");
        return;
      }

      string strFromFile;
      while ((strFromFile = streamReader.ReadLine()) != null)
      {
        Console.WriteLine(strFromFile);
      }
      streamReader.Close();
      Console.WriteLine("Файл прочитан успешно!");
      Console.ReadKey();

      Console.WriteLine($"Удаление файла \"{fileName}\"");
      Console.Write("Вы уверены? (Y/N): ");
      string dlt = Console.ReadLine();
      if (dlt == "Y" || dlt == "y")
      {
        File.Delete(fileName);
        Console.WriteLine("Файл удалён успешно!");
      }
      else
        Console.WriteLine("Удаление файла было отменено пользователем");
      Console.ReadKey();
    }
  }
}
