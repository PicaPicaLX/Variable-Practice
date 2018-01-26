using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            int x;
            int y;
            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine();
            */


            Console.WriteLine("What is your name?");
            // 方法 “WriteLine” 指的是在这一行显示完内容后直接跳到下一行
            Console.Write("Type your first name: ");
            // 方法 “Write” 指的是显示括号中的内容但是不跳到下一行，需要按回车
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;

            Console.Write("Type your last name: ");
            myLastName = Console.ReadLine();
            /*  
            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine(); 
            // 与36~38行相比，这是一种能够减少代码量的方法：
            */

            Console.WriteLine("Hello, " +
                myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
