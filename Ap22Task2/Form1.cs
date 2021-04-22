using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ap22Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] numbers = new int[25]; 
        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            string numberstring = "";

            //for loop (start, end, step
            for (int number = 0; number < numbers.Length; number ++)
            {
                int num = x.Next(1, 101); //Generate a random number from 1-100
                numbers[number] = num; // assign x to the numbers array at index [number]
                numberstring += (numbers[number].ToString() + ", ");
            }
            textBox1.Text = numberstring;

        }

  
        private void BtnEvenSort_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Array.Sort(numbers);

            for (int x = 0; x < numbers.Length; x++)
            {
                //if (numbers[x] % 2) 
            }
            string evenstring = "";
            string oddstring = "";

            foreach(int x in numbers)
            {
                if (x % 2 != 0) //find even numbers
                {
                    evenstring += x + ", ";
                } else // left over numbers must be odd (because they are not even)
                {
                    oddstring += x + ", ";
                }
            }
            textBox2.Text = evenstring;
            textBox3.Text = oddstring;
        }

        //private void string DisplayNumbers(arra num)
        //{

        //}
    }
}
