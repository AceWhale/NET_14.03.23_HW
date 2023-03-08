using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._03._23_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 1, 2, 3, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 1, 3, 4, 5, 7 , 11};

            #region 1
            var buf_1 = arr1.Except(arr2);
            foreach (int i in buf_1)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region 2
            var buf_2 = arr1.Intersect(arr2);
            foreach (int i in buf_2)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region 3
            var buf_3 = arr1.Union(arr2);
            foreach (int i in buf_3)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion

            #region 4
            var buf_4 = arr1.Distinct();
            foreach (int i in buf_4)
                Console.Write(i + " ");
            Console.WriteLine();
            #endregion
        }
    }
}
