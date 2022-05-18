using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    internal class SnakeRandom
    {
        public static int num1;
        public static void Snake()
        {
            Random obj1 = new Random();
            num1 = obj1.Next(1, 7); 


        if (num1 == 1)
            {
                Console.WriteLine("U got" + num1);
            }
            else if (num1 == 2)
            {
                Console.WriteLine("U got" + num1);

            }
            else if (num1 == 3)
            {
                Console.WriteLine("U got" + num1);

            }
            else if (num1 == 4)
            {
                Console.WriteLine("U got" + num1);
            }
            else if (num1 == 5)
            {
                Console.WriteLine("U got" + num1);

            }
            else if (num1 == 6)
            {
                Console.WriteLine("U got" + num1);
            }
            else
            {
                Console.WriteLine("U got Nothing");
            }

        }
    }
}
