using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message myMessage;
            myMessage = new Message("Hello World - from Message Object");
            myMessage.Print();
            Console.ReadLine();
        }
    }
}
