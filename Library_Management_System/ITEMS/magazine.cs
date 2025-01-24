using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System.ITEMS
{
    public class magazine : LibraryItem
    {
        public int IssueNumber { get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Issue Number: {IssueNumber}");
        }
    }
}
