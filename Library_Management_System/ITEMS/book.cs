using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.ITEMS
{
   public class book : LibraryItem
    {
        public int PageCount { get; set; }
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Page count: {PageCount}");
        }

    }
}
