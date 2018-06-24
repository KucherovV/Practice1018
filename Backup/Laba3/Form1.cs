using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;
using System.IO;
namespace Laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 my_array= new Class1();
        int length;
        string rezult = "";
        private void generate_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           int min = Convert.ToInt32(left.Value);// вводим левую границу массива
            int max = Convert.ToInt32(right.Value); // вводим правую границу
            length = Convert.ToInt32(size.Value);//ввод размерности
            if (min > max)
            {
                MessageBox.Show("Неккоректный ввод!", "Ошибка");
                Perform.Enabled = false;
                dvg.Rows.Clear();
                length = 0;
            }
            else
            {
                my_array.arr_gen(min, max, length);
                dvg.RowCount = length;
                for (int i = 0; i < my_array.arr.Length; i++)
                {
                    textBox1.Text += my_array.arr[i].ToString() + " ";
                    dvg[1, i].Value = my_array.arr[i];
                    dvg[0, i].Value = i;
                }

                Perform.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      
        private void write_to_f1_Click(object sender, EventArgs e)
        {
            
            string Fname = ""; // для имени файла
            // задание начальной директории
            save.InitialDirectory = @"С:\" ;
            // задание свойства Filter
            save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // задание свойства FilterIndex – выбор типа файла
            save.FilterIndex = 1;
            // свойство Title - название окна диалога выбора файла
            save.Title = "Сохранить файл как";
            save.FileName = "array";
            if (save.ShowDialog() == DialogResult.OK) 
            { // получаем имя файла для сохранения данных
                Fname = save.FileName;
            // выделяем память для объекта типа FileStream
            FileStream fs = new FileStream(Fname,FileMode.Create, FileAccess.Write);
            if (fs != null) // в случае успеха создаем объект
            { // типа StreamWriter и ассоциируем его с объектом fs
            StreamWriter wr = new StreamWriter(fs);

                // записываем данные
            if (length>0) // если массив создан
            for (int i = 0; i <my_array.arr.Length; ++i)
                wr.WriteLine(my_array.arr[i]);
                   
            else { MessageBox.Show( "Массив не создан!","Сообщение");  }
                // переносим данные в файл
                wr.Flush();
                // fs.Length - длина потока в байтах
                // закрываем объекты wr и fs
                wr.Close();
                fs.Close();
                }
              }
            if (length > 0)
                 MessageBox.Show("Массив успешно записан в файл!", "Сообщение");

        }

        //}

        private void read_F1_Click(object sender, EventArgs e)
        {
            try
            {
                // количество выводимых чисел
                int length = Convert.ToInt32(size.Value);
                // для имени файла
                string Fname = "";
                open.InitialDirectory = "С:\\";
                // задание свойства Filter (2)
                open.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                open.Title = "Открыть файл";

                if (open.ShowDialog() == DialogResult.OK)
                    Fname = open.FileName;


                FileStream fs = new FileStream(Fname, FileMode.Open,
                FileAccess.Read);
                if (fs != null) // в случае успеха создания объекта fs
                {            // создаем объект типа StreamReader и 
                    // ассоциируем его с объектом fs
                    StreamReader r = new StreamReader(fs);
                    string s = ""; string ss = "";
                    // первое чтение символов из потока до конца
                    ss = r.ReadToEnd();
                    int j = 0;
                    for (int i = 0; i < ss.Length; ++i)
                    {  // подсчет количества '\n'
                        if (ss[i] == '\n') { ++j; }
                    }  // создание массива размерности j
                    float[] ar = new float[j];
                    // возврат в начало потока
                    fs.Position = 0;
                    for (int i = 0; i < j; ++i)
                    { // второе чтение из потока, читаем построчно
                        ar[i] = (float)Convert.ToDouble(r.ReadLine());
                        s += " " + ar[i];
                    }  // также выводим число символов '\n' в потоке
                    size.Value = j;
                    // вывод из потока считанного массива ar и числа
                    textBox1.Text = s;
                    // закрываем объекты r и fs
                    r.Close(); fs.Close();

                }
            }
            catch
            {
                return;
            }

        }

        private void write_to_f2_Click(object sender, EventArgs e)
        {
             string Fname = ""; // для имени файла
            // задание начальной директории
             save.InitialDirectory = @"С:\";
            // задание свойства Filter
             save.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            // задание свойства FilterIndex – выбор типа файла
             save.FilterIndex = 1;
            // свойство Title - название окна диалога выбора файла
             save.Title = "Сохранить файл как";
             save.FileName = "F2";
             if (save.ShowDialog() == DialogResult.OK) 
            { // получаем имя файла для сохранения данных
                Fname = save.FileName;
            // выделяем память для объекта типа FileStream
            FileStream fs = new FileStream(Fname,FileMode.Create, FileAccess.Write);
            if (fs != null) // в случае успеха создаем объект
            { // типа StreamWriter и ассоциируем его с объектом fs
            StreamWriter wr = new StreamWriter(fs);

                // записываем данные
           
                wr.WriteLine(richTextBox1.Text);
                   
           
                wr.Flush();
                // fs.Length - длина потока в байтах
                // закрываем объекты wr и fs
                wr.Close();
                fs.Close();
                }
              }
            if (length > 0)
                 MessageBox.Show("Массив успешно записан в файл!", "Сообщение");

        
        }

        private void Perform_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                my_array.revers_sort();
                textBox1.Clear();
               // rezult+=
                for (int i = 0; i < my_array.arr.Length; i++)
                {
                    textBox1.Text += my_array.arr[i].ToString() + " ";
                    dvg[1, i].Value = my_array.arr[i];
                    dvg[0, i].Value = i;
                }
                rezult= "Полученный массив:" + textBox1.Text;
            }
            if (radioButton2.Checked)
            {
                my_array.pair();
                rezult = "Сумма:" + my_array.sum.ToString() + " Количество:" + my_array.count.ToString();
            }
            if (radioButton3.Checked)
            {
                my_array.simple();
                rezult = "Количество простых чисел:" + my_array.counter.ToString();

            }

            if (radioButton4.Checked)
            {
                my_array.MO_Disp();
                rezult = "Мат.ожидание:" + my_array.Mo.ToString() + "\n"+"Дисперсия:" + my_array.Disp.ToString();
            }

            richTextBox1.Text += rezult+"\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(generate, "Генерация массива");
            t.SetToolTip(radioButton1, "Сортировка массива в обратном порядке");
            t.SetToolTip(radioButton2, "Определить сумму и количество элементов массива ai, у которых число, составленное из последней и третьей с конца цифр числа ai, четное");
            t.SetToolTip(radioButton3, "Определить количество простых чисел массива методом пробных делителей");
            t.SetToolTip(radioButton4, "Вычислить математическое ожидание и дисперсию квадратов элементов массива.");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

      

       

    }
}
