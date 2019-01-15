using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace inf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
            numericUpDownForN.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        List<string> arr = new List<string>();//Массив, в который  записываются символы в 16-ой системе
        private void button_Input_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox_input.Text.Length; i++)
            {
                if (!((textBox_input.Text[i] >= 48 && textBox_input.Text[i] <= 57) || (textBox_input.Text[i] >= 65 && textBox_input.Text[i] <= 70) || (textBox_input.Text[i] >= 97 && textBox_input.Text[i] <= 102)))
                {
                    MessageBox.Show("Допустимы только цифры 16-ной системы", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }


            if (textBox_input.Text.Trim() == "")
            {
                MessageBox.Show("Поле ввода не может быть пустым", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            if (textBox_input.Text.Length >= 17)
            {
                MessageBox.Show("Недопустимо большое число", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            numericUpDownForN.Enabled = false;
            label4.Text = "Для изменения размера массива вам потребуется сбросить введенные данные";
            string str = "Вывод полученного массива:";
            int N = (int)numericUpDownForN.Value;
            if (arr.Count == N)
                return;
            arr.Add(textBox_input.Text);
            for (int i = 0; i < arr.Count; i++)
            {
                if (i == N)
                    break;
                str += arr[i] + " ";
            }
            label_End.Text = str;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (arr.Count == 0)
            {
                MessageBox.Show("Добавьте хотя-бы один элемент в массив", "Ошибка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            string str = "";
            List<double> ar = new List<double>();
            foreach (string element in arr)
            {
                double sum = 0;
                string sign = "", exp = "", mant = "";
                string hex = element;
                string bin = Convert.ToString(Convert.ToInt64(hex, 16), 2);
                string bin0 = "";
                int count = 0;
                int a = hex.Length;
                for (int i = 0; i < hex.Length; i++)//преобразование из 16-ой систему в 2-ную со всеми нулями
                {
                    bin0 += "0000";
                }
                if (!bin.Contains("1"))
                    bin = bin0;
                else
                {
                    while (hex[count] == 48)
                    {
                        bin = "0000" + bin;

                        count++;
                        if (a == count)
                        {
                            break;
                        }
                    }
                    if (hex[count] == 49)
                    {
                        bin = "000" + bin;
                    }
                    if (hex[count] >= 50 && hex[count] <= 51)
                    {
                        bin = "00" + bin;
                    }
                    if (hex[count] >= 52 && hex[count] <= 55)
                    {
                        bin = "0" + bin;
                    }

                }

                for (int i = 0; i < bin.Length; i++)//разбивание двоичного числа на: знак, экспоненту и мантиссу
                {
                    if (i == 0)
                        sign += bin[i];//знак
                    if (i >= 1 && i <= 5)
                        exp += bin[i];//экспонента
                    if (i >= 6 && i <= 15)
                        mant += bin[i];//мантисса
                    if (i > 15)
                        break;
                }
                a = mant.Length;
                while (exp.Length != 5)//добавление недостающих нулей к мантиссе
                {
                    for (int i = 0; i < 5 - exp.Length; i++)
                        exp = exp + "0";
                }
                while (mant.Length != 10)//добавление недостающих нулей к мантиссе
                {
                    for (int i = 0; i < 10 - a; i++)
                    {
                        mant = mant + "0";
                    }
                }
                mant = "1." + mant;//Добавление к мантиссе незначещей единицы
                int exp_ToInt = Convert.ToInt32(exp, 2);//Перевод экспонеты из двоичного в десятичное представление 
                int true_degree = exp_ToInt - 15;//Нахождение иситнной степени
                mant = (double.Parse(mant) * Math.Pow(10, true_degree)).ToString("F14");
                if (mant.Contains("."))
                {
                    count = -mant.Substring(0, mant.LastIndexOf('.')).Length;
                    for (int i = 0; i < mant.Length; i++)
                    {
                        if (mant[i] != 46 && mant[i] != 49) count++;
                        if (mant[i] == 49)
                        {
                            count++;
                            sum += Math.Pow(2, -count);
                        }
                    }
                }
                else
                {
                    sum = Convert.ToInt32(mant, 2);
                }
                if (sign == "1")
                {
                    sum *= -1;
                }
                ar.Add(sum);
            }
            ar.Sort();
            ar.Reverse();
            foreach (double item in ar)
            {
                str += item + " ";
            }
            label1.Text = "Преобразование: "+ str;
            textBox1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDownForN.Enabled = true;
            arr.Clear();
            label_End.Text = "Вывод полученного массива:";
            label1.Text = "Преобразование:";
            label4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
