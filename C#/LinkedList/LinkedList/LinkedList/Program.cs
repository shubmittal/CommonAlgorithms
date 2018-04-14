using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var ll = new LinkedList<string>();

            ll.push("Jae");
            ll.push("Tony");
            ll.push("Stark");
            ll.print();

            ll.pop();
            ll.print();
            ll.pop();
            ll.pop();
            ll.pop();
            ll.print();
        }
    }
}
