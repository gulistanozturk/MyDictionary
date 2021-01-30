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

            Console.WriteLine("Kitap Fiyatı : " + books.Keys[0] + "\t" + "Kitabın Adı : " + books.Values[0]);
            Console.WriteLine("Kitap Fiyatı : " + books.Keys[1] + "\t" + "Kitabın Adı : " + books.Values[1]);
            Console.WriteLine("Kitap Fiyatı : " + books.Keys[2] + "\t" + "Kitabın Adı : " + books.Values[2]);
        }


    }
}
