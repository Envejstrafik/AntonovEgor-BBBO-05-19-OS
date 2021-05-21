using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace Practice1._3
{
  [Serializable]
  class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }
    public Person() { }
  }

  class Program
  {
    static async Task Main(string[] args)
    {

      Console.Write("Введите название файла, который хотите создать (JSON): ");
      string fileName = Console.ReadLine();
      fileName += ".json";
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

      Person persObject = new Person();

      Console.Write("Введите имя человека: ");
      persObject.Name = Console.ReadLine();
      Console.Write("Введите возраст человека: ");
      persObject.Age = Convert.ToInt32(Console.ReadLine());

      await JsonSerializer.SerializeAsync<Person>(fileStream, persObject);

      Console.WriteLine("Объект был записан в файл.");
      fileStream.Close();
      Console.ReadKey();



      Console.Write("Введите название json-файла, который хотите вывести в консоль: ");
      fileName = Console.ReadLine();
      fileName += ".json";


      try
      {
        fileStream = File.Open(fileName, FileMode.Open);
      }
      catch
      {
        Console.WriteLine("Ошибка! Введено невозможное имя для файла, или директория недоступна!");
        Console.WriteLine("Не удалось открыть файл!");
        return;
      }

      Person restoredPersObject = await JsonSerializer.DeserializeAsync<Person>(fileStream);
      fileStream.Close();

      Console.Clear();
      Console.WriteLine($"Имя: {restoredPersObject.Name}");
      Console.WriteLine($"Возраст: {restoredPersObject.Age}");

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
