using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Management_System.ITEMS;

namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>();

            libraryItems.Add(new book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "9780743273565",
                PageCount = 180
            });
            libraryItems.Add(new magazine
            {
                Title = "National Geographic",
                Author = "Various",
                ISBN = "00279358",
                IssueNumber = 102
            });
            foreach (LibraryItem item in libraryItems)
            {
                item.DisplayDetails();
                Console.WriteLine(); 
            }
        }
    }
}
