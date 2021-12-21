using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class Android: ICellular
    {
        public string color { get; set; }
        public bool IsReliable { get; set; }

        public void Phone()
        {
            Console.WriteLine($"I'll call you back in a minute my {color} phone");
        }
    }
}
