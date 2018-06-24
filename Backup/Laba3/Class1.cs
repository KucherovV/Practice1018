using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba3
{
    class Class1
    {
       public  long[] arr;
       public int counter;
       public double Disp;
       public double Mo;
       public long sum, count;
         public  void arr_gen(int min, int max, int length)
        {
            arr = new long[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)// цикл для заполнения массива
                arr[i] = rnd.Next(min, max);//заполнение массива случайными
        }
         public void revers_sort()
         {
             Array.Sort(arr);
             Array.Reverse(arr);
         }
         public void simple()
         {
             counter = 0;
             for (int i = 0; i < arr.Length; i++)
             {
                 bool flag = false;
                 if ((arr[i] == 2 || arr[i] == 3) )
                 {
                     counter++;
                     continue;

                 }
                 if (arr[i] % 2 == 0 || arr[i] % 3 == 0 || arr[i] == 1)
                     continue;
                 else
                 {
                     for (int j = 7, z = 5; j * j < arr[i] || z * z < arr[i]; j = j + 6, z = z + 6)
                         if (arr[i] % j == 0 || arr[i] % z == 0)
                         {
                             flag = true;
                             break;
                         }
                     if (!flag)
                         counter++;
                 }
             }
         }

         public void MO_Disp()
         {
             double Mo_2=0,Mo_4=0;
              Mo= arr.Average();
            for (int i = 0; i < arr.Length; i++)
            {
                Mo_2 += arr[i] * arr[i] / arr.Length;
                Mo_4 += (arr[i] * arr[i] * arr[i] * arr[i]) / arr.Length;
            }
             Disp = Mo_4 - Mo_2 * Mo_2;
         }
         public void pair()
         {
             int a=0,b=0;
             sum = 0;
             count = 0;

             for (int i = 0; i < arr.Length; i++)
             {
                 if (arr[i] <100)
                     continue;

                 string s = arr[i].ToString();
                 a = int.Parse(s[s.Length - 1].ToString());
                 b = int.Parse(s[s.Length - 3].ToString());
                 if ((a + b) % 2 == 0)
                 {
                     sum+=arr[i];
                     count++;
                 }

             }      
         }
    }
}
