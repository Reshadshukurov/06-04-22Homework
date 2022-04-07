using _06_04_22.Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_04_22.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> number = new MyList<int>();
            int[] num = new int[10];
            num[0] = 5;
            num[1] = 3;
            num[2] = 6;
            num[3] = 7;
            Resize(ref num, num.Length + 1);
            Console.WriteLine(num.Length);
            Console.ReadLine();
        }

        static void Resize<T>(ref T[] arr1, int length)
        {
            T[] arr2 = new T[length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            arr1 = arr2;
        }
    }
}



