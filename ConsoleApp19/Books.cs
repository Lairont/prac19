using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Books
    {
        public string Title;
        public string Author;
        public int Year;
        public int Pages;
        public void Info()
        {
            Console.WriteLine($"Название: {Title}\nАвтор: {Author}\nГод выпуска: {Year}\nОбъем в листах: {Pages}");
        }
    }
}
