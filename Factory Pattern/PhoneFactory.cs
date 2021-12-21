using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
     class PhoneFactory
    {
        public ICellular CreatePhone(string userImput)
        {
            switch (userImput.ToLower())
            {
                case "Android":
                    return new Android() { color = "green", IsReliable = true };

                case "Iphone":
                    return new IPhone();
                default:
                    return new IPhone();
            }
        }
    }
 }
