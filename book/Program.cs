using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] a=new Book[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Book {0}:",i+1);
                a[i].ISBN=Convert.ToInt32(Console.ReadLine());
                a[i].Name = Console.ReadLine();
                a[i].Author = Console.ReadLine();
            }
            Library my=new Library(a);
            my.Show();
            

        }
    }
}
