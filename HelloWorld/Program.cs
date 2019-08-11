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
            Message myMessage = new Message("Hello World - from Message Object");
            myMessage.Print();
            Message[] messages = new Message[4];
            messages[0] = new Message("Chris is a good teacher");
            messages[1] = new Message("Hey Stew");
            messages[2] = new Message("Bap Boop Beep");
            messages[3] = new Message("That is a silly name");
            Console.WriteLine("Please enter your name!");
            string name = Console.ReadLine().ToLower();
            if (name == "chris")
            {
                messages[0].Print();
            }
            else if (name == "kyle")
            {
                messages[1].Print();
            }
            else if (name == "charlie")
            {
                messages[2].Print();
            }
            else
            {
                messages[3].Print();
            }
            Console.ReadLine();
        }
    }
}
