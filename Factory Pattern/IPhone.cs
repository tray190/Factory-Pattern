using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class IPhone: ICellular
    {
        public string color { get; set; }
        public int HasSiri { get; set; }

        public void Phone()
        {
            Console.WriteLine("talking on a Iphone");
        }      
    }
}
