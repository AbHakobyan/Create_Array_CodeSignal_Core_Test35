using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_Array_CodeSignal_Core_Test35
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = createArray(5);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        static int[] createArray(int size)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                list.Add(1);
            }
            int[] array = list.ToArray();
            return array;
        }

    }
}
