using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace book
{
    class Library
    {
        private List<Book> bookList;



        private static void Print(Book s)
        {
            Console.WriteLine(s.ToString());
        }

        public void Show()
        {
            bookList.ForEach(Print);
        }

        public void Save()
        { }

        public void Read()
        { }

        public Library()
        {
            this.bookList = new List<Book>();
        }

        public Library(Book[] bookArray)
        {
            this.bookList = new List<Book>(bookArray);
        }

        public void Add(Book newBook)
        {
            bookList.Add(newBook);
        }

        public List<Book> Search(object search)
        {
            List<Book> result = bookList.FindAll
                (
                    delegate(Book bk)
                    {
                        return ((bk.ISBN == Convert.ToInt32(search)) || (bk.Name == Convert.ToString(search)) || (bk.Author == Convert.ToString(search)));
                    }
                );
            return result;
        }
        
        public void Remove(int ISBN)
        {
            Book result;
            result = bookList.Find
                (
                    delegate(Book bk)
                    {
                        return bk.ISBN==ISBN;
                    }
                );
            bookList.Remove(result);
        }
    }
}
