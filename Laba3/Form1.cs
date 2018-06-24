using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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

        ArrayProcessing my_array= new ArrayProcessing();
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
            save.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            // задание свойства FilterIndex – выбор типа файла
            save.FilterIndex = 1;
            // свойство Title - название окна диалога выбора файла
            save.Title = "Сохранить файл как";
            save.FileName = "array";
            if (save.ShowDialog() == DialogResult.OK)
            { // получаем имя файла для сохранения данных
                Fname = save.FileName;
                int result = my_array.saveArray(Fname);

                switch(result)
                {
                    case 0:
                        MessageBox.Show("Файл успешно сохранен!");
                        break;
                    case 1:
                        MessageBox.Show("Ошибка во время ввода/вывода!");
                        break;
                    case 2:
                        MessageBox.Show("Ошибка во время сериализации!");
                        break;
                }
            }
        }

        private void read_F1_Click(object sender, EventArgs e)
        {
            string Fname = "";
            open.InitialDirectory = "С:\\";
            // задание свойства Filter (2)
            open.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            open.Title = "Открыть файл";

            if (open.ShowDialog() == DialogResult.OK)
            { // получаем имя файла для сохранения данных
                Fname = open.FileName;
                int result = my_array.loadArray(Fname);
                switch (result)
                {
                    case 0:
                        MessageBox.Show("Файл успешно загружен!");
                        textBox1.Text = my_array.ToString();
                        dvg.RowCount = my_array.arr.Length;
                        for (int i = 0; i < my_array.arr.Length; i++)
                         {
                             dvg[1, i].Value = my_array.arr[i];
                             dvg[0, i].Value = i;
                         }
                        Perform.Enabled = true;
                        break;
                    case 1:
                        MessageBox.Show("Ошибка во время ввода/вывода!");
                        break;
                    case 2:
                        MessageBox.Show("Ошибка во время сериализации!");
                        break;
                }
            }

        }

        private void write_to_f2_Click(object sender, EventArgs e)
        {
             string Fname = ""; // для имени файла
            // задание начальной директории
             save.InitialDirectory = @"С:\";
            // задание свойства Filter
             save.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            // задание свойства FilterIndex – выбор типа файла
             save.FilterIndex = 1;
            // свойство Title - название окна диалога выбора файла
             save.Title = "Сохранить файл как";
             save.FileName = "F2";
             if (save.ShowDialog() == DialogResult.OK)
             { // получаем имя файла для сохранения данных
                 Fname = save.FileName;
                 int result = my_array.saveResults(Fname, (int)numericUpDown1.Value);
                 switch (result)
                 {
                     case 0:
                         MessageBox.Show("Файл успешно сохранен!");
                         break;
                     case 1:
                         MessageBox.Show("Ошибка во время ввода/вывода!");
                         break;
                     case 2:
                         MessageBox.Show("Ошибка во время сериализации!");
                         break;
                 }
             }
        }

        private void Perform_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int[] sortArray = my_array.array_sort();
                richTextBox1.Text += my_array.arrayToString(sortArray) +"\n";
            }
            if (radioButton2.Checked)
            {
                int[] results = my_array.task9((int)numericUpDown1.Value);
                richTextBox1.Text += "Сумма:" + results[0].ToString() + " Количество:" + results[1].ToString() + "\n";
            }
            if (radioButton3.Checked)
            {
                int[] results  = my_array.task15();
                richTextBox1.Text += "Сумма:" + results[0].ToString() + " Количество:" + results[1].ToString() + "\n";
            }
            if (radioButton4.Checked)
            {
                double[] results = my_array.MO_Disp();
                richTextBox1.Text += "Мат.ожидание:" + results[0].ToString() + "\n" + "Дисперсия:" + results[1].ToString() + "\n";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(generate, "Генерация массива");
            t.SetToolTip(radioButton1, "Сортировка массива в порядке возрастания");
            t.SetToolTip(radioButton2, "Определить сумму и количество элементов массива ai, у которых число, составленное из двух первых цифр числа ai, четное");
            t.SetToolTip(radioButton3, "Определить сумму и количество чисел больших за С с нечетными номерами");
            t.SetToolTip(radioButton4, "Вычислить математическое ожидание и дисперсию квадратов элементов массива");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

     

    }
}
