using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    internal class WarrantyStudent:Student
    {
        public string OldGroupNo { get; set; }

        public override void ShowInfo()
        {
            Console.WriteLine($"OldGroup: {OldGroupNo}");
        }
    }
}
