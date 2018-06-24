using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace Laba3
{
    public class ArrayProcessing
    {
        public int[] arr;
        public int counter;
        public double Disp;
        public double Mo;
        public long sum, count;

        /// <summary>
        /// Генерация массива
        /// </summary>
        /// <param name="min">Минимальное значение в массиве</param>
        /// <param name="max">Максимальное значение в массиве</param>
        /// <param name="length">Длинна массива</param>
        public void arr_gen(int min, int max, int length)
        {
            arr = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)// цикл для заполнения массива
                arr[i] = rnd.Next(min, max);//заполнение массива случайными
        }

        /// <summary>
        /// Сортровка массива по возрастанию
        /// </summary>
        public int[] array_sort()
        {
            int[] sortArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sortArray[i] = arr[i];
            }
            Array.Sort(sortArray);
            return sortArray;
        }

        /// <summary>
        /// Вычисление суммы и количества элементов, у которых число,составленное 
        /// из двух первых цифр числа ai четное
        /// </summary>
        public int[] task15()
        {
            string temp = "";
            int number;

            int[] results = new int[2];

            for (int i = 0; i < arr.Length; i++)
            {
                temp = arr[i].ToString();
                if (temp.Length > 1)
                {
                    number = Convert.ToInt32(temp.Substring(0, 2));
                    if (number % 2 == 0)
                    {
                        results[0] += arr[i];
                        results[1]++;
                    }
                }
            }

            return results;
        }

        /// <summary>
        /// Вычисление математического ожидания и дисперсии
        /// </summary>
        /// <returns></returns>
        public double[] MO_Disp()
        {
            double[] results = new double[2];

            /*===============Вычисление математического ожидания============*/
            for (int i = 0; i < arr.Length; i++)
            {
                results[0] += arr[i];
            }

            results[0] /= arr.Length;
            Math.Round(results[0], 2, MidpointRounding.ToEven);
            /*==============================================================*/

            /*=============Вычисление дисперсии=============================*/
            for (int i = 0; i < arr.Length; i++)
            {
                results[1] += Math.Pow(arr[i] - results[0], 2);
            }

            results[1] /= (arr.Length - 1);
            Math.Round(results[1], 2, MidpointRounding.ToEven);
            /*==============================================================*/

            return results;
        }

        /// <summary>
        /// Вычисление суммы и количества чисел массива с нечетными номерами и большими числа С
        /// </summary>
        /// <returns></returns>
        public int[] task9(int C)
        {
            int[] results = new int[2];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1 && arr[i] > C)
                {
                    results[1]++;
                    results[0] += arr[i];
                }
            }

            return results;
        }

        /// <summary>
        /// Сохранение результатов в файл
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <returns></returns>
        public int saveResults(string fileName, int C)
        {
            if (fileName.IndexOf(".json") < 0)
                fileName += ".json";

            ArrayProcessingResults rs = new ArrayProcessingResults();

            rs.SortArray = array_sort(); ;
            rs.Task1 = MO_Disp();
            rs.Task9 = task9(C);
            rs.Task15 = task15();

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(ArrayProcessingResults));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    js.WriteObject(fs, rs);
                }
            }
            catch (IOException)
            {
                return 1;
            }
            catch (SerializationException)
            {
                return 2;
            }
            return 0;
        }

        /// <summary>
        /// Загрузка массив из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns></returns>
        public int loadArray(string fileName)
        {
            if (fileName.IndexOf(".json") < 0)
                fileName += ".json";

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(int[]));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                {
                    arr = (int[])js.ReadObject(fs);
                }
            }
            catch (IOException)
            {
                return 1;
            }
            catch (SerializationException)
            {
                return 2;
            }
            return 0;
        }

        /// <summary>
        /// Сохранение массива в файл
        /// </summary>
        /// <param name="fileName">имя файла</param>
        /// <returns></returns>
        public int saveArray(string fileName)
        {
            if (fileName.IndexOf(".json") < 0)
                fileName += ".json";

            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(int[]));
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                {
                    js.WriteObject(fs, arr);
                }
            }
            catch (IOException)
            {
                return 1;
            }
            catch (SerializationException)
            {
                return 2;
            }
            return 0;
        }

        public override string ToString()
        {
            string array = "";

            for (int i = 0; i < arr.Length; i++)
            {
                array += arr[i].ToString() + ", ";
            }
            return array;
        }

        public string arrayToString(int[] array)
        {
            string stringArray = "";

            for (int i = 0; i < array.Length; i++)
            {
                stringArray += arr[i].ToString() + ", ";
            }
            return stringArray;
        }

        public int[] UserArray
        {
            get { return arr; }
            set { arr = value; }
        }
    }

    [DataContract]
    class ArrayProcessingResults
    {
        int[] task15;
        double[] task1;
        int[] sortArray;
        int[] task9;

        public ArrayProcessingResults() { }

        /// <summary>
        /// Результаты вычисления задания 15
        /// </summary>
        [DataMember]
        public int[] Task15
        {
            get
            {
                return task15;
            }
            set
            {
                task15 = value;
            }
        }

        /// <summary>
        /// Результаты вычисления задания 1
        /// </summary>
        [DataMember]
        public double[] Task1
        {
            get
            {
                return task1;
            }
            set
            {
                task1 = value;
            }
        }

        /// <summary>
        /// Отсортированный массив
        /// </summary>
        [DataMember]
        public int[] SortArray 
        {
            get
            {
                return sortArray;
            }
            set
            {
                sortArray = value;
            }
        }

        /// <summary>
        /// Результаты вычисления задания 9
        /// </summary>
        [DataMember]
        public int[] Task9
        {
            get
            {
                return task9;
            }
            set
            {
                task9 = value;
            }
        }
    }
}