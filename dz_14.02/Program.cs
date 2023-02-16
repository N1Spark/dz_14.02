using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_14._02
{
    class Program
    {
        interface ICalc
        {
            int Less(int valueToCompare);
            int Greater(int valueToCompare);

        }
        interface IOutput2
        {
            void ShowEven();
            void ShowOdd();
        }
        interface ICalc2
        {
            int CountDistinct();
            int EqualToValue(int valueToCompare);

        }
        class Array : ICalc, IOutput2, ICalc2
        {
            public int[] arr;
            public Array(params int[] a)
            {
                arr = new int[a.Length];
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = a[i];
            }
            public int Less(int valueToCompare)
            {
                int buf = 0;
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] < valueToCompare)
                        buf++;
                return buf;
            }
            public int Greater(int valueToCompare)
            {
                int buf = 0;
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] > valueToCompare)
                        buf++;
                return buf;
            }
            public void ShowEven()
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] % 2 == 0 && arr[i] != 0)
                        Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
            public void ShowOdd()
            {
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] % 2 != 0)
                        Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
            public int CountDistinct()
            {
                int buf = 0;
                bool check = true;
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length; j++)
                    {
                        if (i == j)
                            continue;
                        if (arr[i] == arr[j])
                        {
                            check = false;
                            break;
                        }
                        else
                            check = true;
                    }
                    if (check)
                        buf++;
                    else
                        check = true;
                }
                return buf;
            }
            public int EqualToValue(int valueToCompare)
            {
                int buf = 0;
                for (int i = 0; i < arr.Length; i++)
                    if (arr[i] == valueToCompare)
                        buf++;
                return buf;
            }

        }
    }
}
