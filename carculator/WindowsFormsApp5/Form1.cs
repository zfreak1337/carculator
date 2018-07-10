using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
      
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(num1.Text);
            double number2 = Convert.ToDouble(num2.Text);
            double result;
            result = 0;
            switch (((Button)sender).Name)
            {
                case "Multiplication":
                    result = number1 * number2;
                    break;
                case "Division":
                    result = number1 / number2;
                    break;
                case "Plus":
                    result = number1 + number2;
                    break;
                case "Minus":
                    result = number1 - number2;
                    break;
               
        
            }
            resultt.Text = result.ToString();
        }

        private void Mult_Click(object sender, EventArgs e)
        {
           
        }

        private void sum_Click(object sender, EventArgs e)
        {
           
        }

        private void sub_Click(object sender, EventArgs e)
        {
            
        }
    }
}
