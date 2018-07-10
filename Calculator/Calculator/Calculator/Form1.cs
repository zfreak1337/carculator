﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
       


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
           
            Calculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double answerDigit = calculator.Calculate(firstNumber, secondNumber);



            textBox3.Text = answerDigit.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(textBox1.Text);
            OoneCalculator calculator = OneArgumentFactory.CreateCalculator(((Button) sender).Name);
            double answerDight = calculator.Calculate(firstNumber);
            textBox3.Text = answerDight.ToString(CultureInfo.InvariantCulture);

        }
    }
}
