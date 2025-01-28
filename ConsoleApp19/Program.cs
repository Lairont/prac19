using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();
            books.Title = "Евгений Онегин";
            books.Author = "А.С.Пушкин";
            books.Year = 1833;
            books.Pages = 224;
            books.Info();
            Console.ReadLine();
        }
    }
}
