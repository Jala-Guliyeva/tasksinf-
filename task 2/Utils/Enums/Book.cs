using System;
using System.Collections.Generic;
using System.Text;

namespace Utils.Enums
{
    internal class Book:IEntity
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public bool IsDeleted { get; set; }

        public Book(string name,string authorname,int pagecount)
        {
            Name = name;
            AuthorName = authorname;    
            PageCount = pagecount;
        }
        public void Showinfo()
        {
            Console.WriteLine($"Name:{Name} - AuthorName:{AuthorName} - PageCount:{PageCount}");
        }

    }
}
