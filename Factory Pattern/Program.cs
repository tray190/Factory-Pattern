using System;

namespace Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what type of phone do you like? Android or IPhone??");
            string userImput = Console.ReadLine();

            PhoneFactory Factory = new PhoneFactory();
           ICellular phone1 = Factory.CreatePhone(userImput);

            phone1.Phone();

            Console.WriteLine("Lets get another phone");
            userImput = Console.ReadLine();
        }
    }
}
