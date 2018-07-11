namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Multiply = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Substraction = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.Logarithm = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.Squaring = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.SquaringTwoArguments = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Arcsinus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Arctangent = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Arccosinus = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.TwoSquaringArgument = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 27);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 375);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(16, 75);
            this.Multiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(59, 54);
            this.Multiply.TabIndex = 3;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.button1_Click);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(83, 76);
            this.Division.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(61, 54);
            this.Division.TabIndex = 4;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(152, 76);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(65, 54);
            this.Add.TabIndex = 5;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Substraction
            // 
            this.Substraction.Location = new System.Drawing.Point(225, 76);
            this.Substraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Substraction.Name = "Substraction";
            this.Substraction.Size = new System.Drawing.Size(64, 54);
            this.Substraction.TabIndex = 6;
            this.Substraction.Text = "-";
            this.Substraction.UseVisualStyleBackColor = true;
            this.Substraction.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "first digit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "second digit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "answer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            this.eventLog1.EntryWritten += new System.Diagnostics.EntryWrittenEventHandler(this.eventLog1_EntryWritten);
            // 
            // Logarithm
            // 
            this.Logarithm.Location = new System.Drawing.Point(16, 137);
            this.Logarithm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(59, 53);
            this.Logarithm.TabIndex = 10;
            this.Logarithm.Text = "ln";
            this.Logarithm.UseVisualStyleBackColor = true;
            this.Logarithm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(99, 137);
            this.Sinus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(61, 53);
            this.Sinus.TabIndex = 11;
            this.Sinus.Text = "sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Squaring
            // 
            this.Squaring.Location = new System.Drawing.Point(184, 137);
            this.Squaring.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Squaring.Name = "Squaring";
            this.Squaring.Size = new System.Drawing.Size(65, 53);
            this.Squaring.TabIndex = 12;
            this.Squaring.Text = "x^2";
            this.Squaring.UseVisualStyleBackColor = true;
            this.Squaring.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(272, 138);
            this.Module.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(64, 52);
            this.Module.TabIndex = 13;
            this.Module.Text = "|x|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SquaringTwoArguments
            // 
            this.SquaringTwoArguments.Location = new System.Drawing.Point(297, 75);
            this.SquaringTwoArguments.Margin = new System.Windows.Forms.Padding(4);
            this.SquaringTwoArguments.Name = "SquaringTwoArguments";
            this.SquaringTwoArguments.Size = new System.Drawing.Size(64, 54);
            this.SquaringTwoArguments.TabIndex = 14;
            this.SquaringTwoArguments.Text = "x^y";
            this.SquaringTwoArguments.UseVisualStyleBackColor = true;
            this.SquaringTwoArguments.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(437, 100);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 54);
            this.button4.TabIndex = 17;
            this.button4.Text = "tan";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Arcsinus
            // 
            this.Arcsinus.Location = new System.Drawing.Point(509, 100);
            this.Arcsinus.Margin = new System.Windows.Forms.Padding(4);
            this.Arcsinus.Name = "Arcsinus";
            this.Arcsinus.Size = new System.Drawing.Size(64, 54);
            this.Arcsinus.TabIndex = 18;
            this.Arcsinus.Text = "arcsin";
            this.Arcsinus.UseVisualStyleBackColor = true;
            this.Arcsinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(416, 200);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(64, 54);
            this.button6.TabIndex = 19;
            this.button6.Text = "log2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 198);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 54);
            this.button7.TabIndex = 20;
            this.button7.Text = "ctan";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Arctangent
            // 
            this.Arctangent.Location = new System.Drawing.Point(666, 100);
            this.Arctangent.Margin = new System.Windows.Forms.Padding(4);
            this.Arctangent.Name = "Arctangent";
            this.Arctangent.Size = new System.Drawing.Size(61, 54);
            this.Arctangent.TabIndex = 21;
            this.Arctangent.Text = "arctan";
            this.Arctangent.UseVisualStyleBackColor = true;
            this.Arctangent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(185, 198);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(64, 54);
            this.button9.TabIndex = 22;
            this.button9.Text = "1/x";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Arccosinus
            // 
            this.Arccosinus.Location = new System.Drawing.Point(581, 100);
            this.Arccosinus.Margin = new System.Windows.Forms.Padding(4);
            this.Arccosinus.Name = "Arccosinus";
            this.Arccosinus.Size = new System.Drawing.Size(64, 54);
            this.Arccosinus.TabIndex = 25;
            this.Arccosinus.Text = "arccos";
            this.Arccosinus.UseVisualStyleBackColor = true;
            this.Arccosinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(488, 200);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(64, 54);
            this.button13.TabIndex = 26;
            this.button13.Text = "log10";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // TwoSquaringArgument
            // 
            this.TwoSquaringArgument.Location = new System.Drawing.Point(344, 261);
            this.TwoSquaringArgument.Margin = new System.Windows.Forms.Padding(4);
            this.TwoSquaringArgument.Name = "TwoSquaringArgument";
            this.TwoSquaringArgument.Size = new System.Drawing.Size(64, 54);
            this.TwoSquaringArgument.TabIndex = 27;
            this.TwoSquaringArgument.Text = "2^x";
            this.TwoSquaringArgument.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(416, 261);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(64, 54);
            this.button15.TabIndex = 28;
            this.button15.Text = "10^x";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(488, 261);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(64, 54);
            this.button16.TabIndex = 29;
            this.button16.Text = "-x";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 463);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.TwoSquaringArgument);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.Arccosinus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.Arctangent);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Arcsinus);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.SquaringTwoArguments);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Squaring);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.Logarithm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Substraction);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Substraction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Squaring;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Logarithm;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button TwoSquaringArgument;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button Arccosinus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Arctangent;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Arcsinus;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SquaringTwoArguments;
    }
}

