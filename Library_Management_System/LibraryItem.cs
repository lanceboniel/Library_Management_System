using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class LibraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }
}
