using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> books = new MyDictionary<int, string>();
            books.Add(50, "Elon Musk ");
            books.Add(30, "Google Sırları");
            books.Add(200, "Clean Code");

           foreach (KeyValuePair<int, string> book in books)
            {
                Console.WriteLine("Kitap Fiyatı : = {0}, Kitabın Adı : = {1}", book.Key, book.Value);
            }
        }


    }
}
