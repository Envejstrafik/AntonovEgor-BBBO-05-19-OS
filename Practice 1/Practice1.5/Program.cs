using System;
using System.IO;
using System.Text;
using System.IO.Compression;

namespace Practice1._5
{
  class Program
  {
    static void Main(string[] args)
    {
      DirectoryInfo dirInfo = new DirectoryInfo("dirToZip");
      if(!dirInfo.Exists)
      {
        dirInfo.Create();
      }
      else { Console.WriteLine("Директория \"dirToZip\" существует"); }

      Console.Write("Введите название файла, который хотите сжать: ");
      string fileName = Console.ReadLine();
      FileStream fileStream;
      try
      {
        fileStream = File.Create("dirToZip\\" + fileName);
      }
      catch
      {
        Console.WriteLine("Ошибка! Введено невозможное имя для файла, или директория недоступна!");
        Console.WriteLine("Не удалось создать файл!");
        return;
      }

      byte[] input = new UTF8Encoding(true).GetBytes("Строка в файле для проверки успеха архивации");
      fileStream.Write(input, 0, input.Length);
      fileStream.Close();
      
      Console.WriteLine("Файл создан успешно!");
      Console.ReadKey();

      ZipFile.CreateFromDirectory("dirToZip", "zip.zip");
      ZipFile.ExtractToDirectory("zip.zip", "dirFromZip");

      StreamReader streamReader;

      try
      {
        streamReader = File.OpenText("dirFromZip\\" + fileName);
      }
      catch
      {
        Console.WriteLine("Ошибка! Директория недоступна!");
        Console.WriteLine("Не удалось открыть файл!");
        return;
      }

      Console.Clear();

      Console.WriteLine(streamReader.ReadLine());
      streamReader.Close();

      Console.WriteLine($"Удаление созданного файла и архива...");
      Console.Write("Вы уверены? (Y/N): ");
      string dlt = Console.ReadLine();
      if (dlt == "Y" || dlt == "y")
      {
        File.Delete("zip.zip");
        File.Delete("dirFromZip\\" + fileName);
        File.Delete("dirToZip\\" + fileName);
        Directory.Delete("dirToZip");
        Directory.Delete("dirFromZip");
        Console.WriteLine("Файлы удалёны успешно!");
      }
      else
        Console.WriteLine("Удаление файла было отменено пользователем");
      Console.ReadKey();

    }
  }
}
