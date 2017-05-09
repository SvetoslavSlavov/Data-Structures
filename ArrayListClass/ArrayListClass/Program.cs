using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Hello");
            list.Add(5);
            list.Add(3.123232);
            list.Add(DateTime.Now);

            for (int i = 0; i < list.Count; i++)
            {
                object value = list[i];
                Console.WriteLine("Index = {0}; Value = {1};",i,value);
            }
        }
    }
}
