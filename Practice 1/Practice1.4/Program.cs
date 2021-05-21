using System;
using System.IO;
using System.Xml.Linq;

namespace Practice1._4
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Введите название файла, который хотите создать (xml): ");
      string fileName = Console.ReadLine();
      fileName += ".xml";

      XDocument xLibrary = new XDocument();
      XElement books = new XElement("books");
      

      Console.Write("Введите количество книг, которое вы хотите внести: ");
      int numOfBooks = Convert.ToInt32(Console.ReadLine());

      string name;
      string author;
      string pubHouse;
      string price;

      

      for (int i = 0; i < numOfBooks; i++)
      {
        XElement book = new XElement("book");
        Console.Clear();
        Console.WriteLine($"Книга {i+1} из {numOfBooks}"); Console.WriteLine();

        Console.Write("Введите название книги: ");
        name = Console.ReadLine();
        XAttribute nameBookAttr = new XAttribute("name", name);

        Console.Write("Введите автора книги: ");
        author = Console.ReadLine();
        XElement authorBook = new XElement("author", author);

        Console.Write("Введите издательство книги: ");
        pubHouse = Console.ReadLine();
        XElement pubHouseBook = new XElement("pubHouse", pubHouse);

        Console.Write("Введите стоимость книги: ");
        price = Console.ReadLine();
        XElement priceBook = new XElement("price", price);

        book.Add(nameBookAttr);
        book.Add(authorBook);
        book.Add(pubHouseBook);
        book.Add(priceBook);
        books.Add(book);
      }
      xLibrary.Add(books);
      xLibrary.Save(fileName);

      Console.WriteLine("Файл был успешно записан!");
      Console.ReadLine();
      Console.Clear();



      Console.Write("Введите название файла, который хотите прочитать (xml): ");
      fileName = Console.ReadLine();
      fileName += ".xml";
      int counter = 1;
      XDocument openedLibrary = XDocument.Load(fileName);
      Console.Clear();
      foreach (XElement bookElement in openedLibrary.Element("books").Elements("book"))
      {
        
        XAttribute nameAttribute = bookElement.Attribute("name");
        XElement autorElement = bookElement.Element("author");
        XElement pubHouseElement = bookElement.Element("pubHouse");
        XElement priceElement = bookElement.Element("price");

        if(nameAttribute != null && autorElement != null && pubHouseElement != null && priceElement != null)
        {
          Console.WriteLine($"{counter}.");
          Console.WriteLine($"Название: \"{nameAttribute.Value}\"");
          Console.WriteLine($"Автор: {autorElement.Value}");
          Console.WriteLine($"Издательство: {pubHouseElement.Value}");
          Console.WriteLine($"Цена: {priceElement.Value}");
          Console.WriteLine();
        }
        counter++;
      }


      Console.WriteLine($"Удаление файла \"{fileName}\"");
      Console.Write("Вы уверены? (Y/N): ");
      string dlt = Console.ReadLine();
      if (dlt == "Y" || dlt == "y")
      {
        File.Delete(fileName);
        Console.WriteLine("Файл удалён успешно!");
      }
      else Console.WriteLine("Удаление файла было отменено пользователем");
    }
  }
}
