using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1.Ivan");
            stack.Push("2.Rado");
            stack.Push("3.Maria");
            stack.Push("4.Georgy");

            Console.WriteLine("Top = "+stack.Pop());
            while (stack.Count>0)
            {
                string personName = stack.Pop();
                Console.WriteLine(personName);
            }
        }
    }
}
