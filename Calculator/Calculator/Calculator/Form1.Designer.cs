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
            this.Tangent = new System.Windows.Forms.Button();
            this.Arcsinus = new System.Windows.Forms.Button();
            this.TwoLogarithmArgument = new System.Windows.Forms.Button();
            this.Ctangent = new System.Windows.Forms.Button();
            this.Arctangent = new System.Windows.Forms.Button();
            this.OneDivisionArgument = new System.Windows.Forms.Button();
            this.Arccosinus = new System.Windows.Forms.Button();
            this.TenLogarithmArgument = new System.Windows.Forms.Button();
            this.TwoSquaringArgument = new System.Windows.Forms.Button();
            this.TenSquaringArgument = new System.Windows.Forms.Button();
            this.NegativeArgument = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.LogarithmTwoArgument = new System.Windows.Forms.Button();
            this.SquaringDivisionTwoArguments = new System.Windows.Forms.Button();
            this.SquareDifference = new System.Windows.Forms.Button();
            this.negativeDegree = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.SquareSum = new System.Windows.Forms.Button();
            this.SquareAdd = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(209, 27);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 375);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(319, 22);
            this.textBox3.TabIndex = 2;
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(16, 75);
            this.Multiply.Margin = new System.Windows.Forms.Padding(4);
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
            this.Division.Margin = new System.Windows.Forms.Padding(4);
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
            this.Add.Margin = new System.Windows.Forms.Padding(4);
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
            this.Substraction.Margin = new System.Windows.Forms.Padding(4);
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
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // Logarithm
            // 
            this.Logarithm.Location = new System.Drawing.Point(16, 137);
            this.Logarithm.Margin = new System.Windows.Forms.Padding(4);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(59, 53);
            this.Logarithm.TabIndex = 10;
            this.Logarithm.Text = "ln";
            this.Logarithm.UseVisualStyleBackColor = true;
            this.Logarithm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Sinus
            // 
            this.Sinus.Location = new System.Drawing.Point(368, 75);
            this.Sinus.Margin = new System.Windows.Forms.Padding(4);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(61, 53);
            this.Sinus.TabIndex = 11;
            this.Sinus.Text = "sin";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Squaring
            // 
            this.Squaring.Location = new System.Drawing.Point(83, 137);
            this.Squaring.Margin = new System.Windows.Forms.Padding(4);
            this.Squaring.Name = "Squaring";
            this.Squaring.Size = new System.Drawing.Size(65, 53);
            this.Squaring.TabIndex = 12;
            this.Squaring.Text = "x^2";
            this.Squaring.UseVisualStyleBackColor = true;
            this.Squaring.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(156, 138);
            this.Module.Margin = new System.Windows.Forms.Padding(4);
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
            // Tangent
            // 
            this.Tangent.Location = new System.Drawing.Point(437, 76);
            this.Tangent.Margin = new System.Windows.Forms.Padding(4);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(64, 54);
            this.Tangent.TabIndex = 17;
            this.Tangent.Text = "tan";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Arcsinus
            // 
            this.Arcsinus.Location = new System.Drawing.Point(509, 76);
            this.Arcsinus.Margin = new System.Windows.Forms.Padding(4);
            this.Arcsinus.Name = "Arcsinus";
            this.Arcsinus.Size = new System.Drawing.Size(64, 54);
            this.Arcsinus.TabIndex = 18;
            this.Arcsinus.Text = "arcsin";
            this.Arcsinus.UseVisualStyleBackColor = true;
            this.Arcsinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TwoLogarithmArgument
            // 
            this.TwoLogarithmArgument.Location = new System.Drawing.Point(368, 136);
            this.TwoLogarithmArgument.Margin = new System.Windows.Forms.Padding(4);
            this.TwoLogarithmArgument.Name = "TwoLogarithmArgument";
            this.TwoLogarithmArgument.Size = new System.Drawing.Size(64, 54);
            this.TwoLogarithmArgument.TabIndex = 19;
            this.TwoLogarithmArgument.Text = "log2(x)";
            this.TwoLogarithmArgument.UseVisualStyleBackColor = true;
            this.TwoLogarithmArgument.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Ctangent
            // 
            this.Ctangent.Location = new System.Drawing.Point(722, 76);
            this.Ctangent.Margin = new System.Windows.Forms.Padding(4);
            this.Ctangent.Name = "Ctangent";
            this.Ctangent.Size = new System.Drawing.Size(59, 54);
            this.Ctangent.TabIndex = 20;
            this.Ctangent.Text = "ctan";
            this.Ctangent.UseVisualStyleBackColor = true;
            this.Ctangent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Arctangent
            // 
            this.Arctangent.Location = new System.Drawing.Point(653, 76);
            this.Arctangent.Margin = new System.Windows.Forms.Padding(4);
            this.Arctangent.Name = "Arctangent";
            this.Arctangent.Size = new System.Drawing.Size(61, 54);
            this.Arctangent.TabIndex = 21;
            this.Arctangent.Text = "arctan";
            this.Arctangent.UseVisualStyleBackColor = true;
            this.Arctangent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OneDivisionArgument
            // 
            this.OneDivisionArgument.Location = new System.Drawing.Point(228, 138);
            this.OneDivisionArgument.Margin = new System.Windows.Forms.Padding(4);
            this.OneDivisionArgument.Name = "OneDivisionArgument";
            this.OneDivisionArgument.Size = new System.Drawing.Size(64, 54);
            this.OneDivisionArgument.TabIndex = 22;
            this.OneDivisionArgument.Text = "1/x";
            this.OneDivisionArgument.UseVisualStyleBackColor = true;
            this.OneDivisionArgument.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Arccosinus
            // 
            this.Arccosinus.Location = new System.Drawing.Point(581, 76);
            this.Arccosinus.Margin = new System.Windows.Forms.Padding(4);
            this.Arccosinus.Name = "Arccosinus";
            this.Arccosinus.Size = new System.Drawing.Size(64, 54);
            this.Arccosinus.TabIndex = 25;
            this.Arccosinus.Text = "arccos";
            this.Arccosinus.UseVisualStyleBackColor = true;
            this.Arccosinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TenLogarithmArgument
            // 
            this.TenLogarithmArgument.Location = new System.Drawing.Point(440, 136);
            this.TenLogarithmArgument.Margin = new System.Windows.Forms.Padding(4);
            this.TenLogarithmArgument.Name = "TenLogarithmArgument";
            this.TenLogarithmArgument.Size = new System.Drawing.Size(72, 54);
            this.TenLogarithmArgument.TabIndex = 26;
            this.TenLogarithmArgument.Text = "log10(x)";
            this.TenLogarithmArgument.UseVisualStyleBackColor = true;
            // 
            // TwoSquaringArgument
            // 
            this.TwoSquaringArgument.Location = new System.Drawing.Point(664, 137);
            this.TwoSquaringArgument.Margin = new System.Windows.Forms.Padding(4);
            this.TwoSquaringArgument.Name = "TwoSquaringArgument";
            this.TwoSquaringArgument.Size = new System.Drawing.Size(64, 54);
            this.TwoSquaringArgument.TabIndex = 27;
            this.TwoSquaringArgument.Text = "2^x";
            this.TwoSquaringArgument.UseVisualStyleBackColor = true;
            this.TwoSquaringArgument.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TenSquaringArgument
            // 
            this.TenSquaringArgument.Location = new System.Drawing.Point(736, 136);
            this.TenSquaringArgument.Margin = new System.Windows.Forms.Padding(4);
            this.TenSquaringArgument.Name = "TenSquaringArgument";
            this.TenSquaringArgument.Size = new System.Drawing.Size(64, 54);
            this.TenSquaringArgument.TabIndex = 28;
            this.TenSquaringArgument.Text = "10^x";
            this.TenSquaringArgument.UseVisualStyleBackColor = true;
            this.TenSquaringArgument.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // NegativeArgument
            // 
            this.NegativeArgument.Location = new System.Drawing.Point(520, 136);
            this.NegativeArgument.Margin = new System.Windows.Forms.Padding(4);
            this.NegativeArgument.Name = "NegativeArgument";
            this.NegativeArgument.Size = new System.Drawing.Size(64, 54);
            this.NegativeArgument.TabIndex = 29;
            this.NegativeArgument.Text = "-x";
            this.NegativeArgument.UseVisualStyleBackColor = true;
            this.NegativeArgument.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Exponent
            // 
            this.Exponent.Location = new System.Drawing.Point(592, 136);
            this.Exponent.Margin = new System.Windows.Forms.Padding(4);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(64, 54);
            this.Exponent.TabIndex = 30;
            this.Exponent.Text = "e^x";
            this.Exponent.UseVisualStyleBackColor = true;
            this.Exponent.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cosinus
            // 
            this.Cosinus.Location = new System.Drawing.Point(789, 77);
            this.Cosinus.Margin = new System.Windows.Forms.Padding(4);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(61, 53);
            this.Cosinus.TabIndex = 31;
            this.Cosinus.Text = "cos";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LogarithmTwoArgument
            // 
            this.LogarithmTwoArgument.Location = new System.Drawing.Point(300, 138);
            this.LogarithmTwoArgument.Margin = new System.Windows.Forms.Padding(4);
            this.LogarithmTwoArgument.Name = "LogarithmTwoArgument";
            this.LogarithmTwoArgument.Size = new System.Drawing.Size(64, 54);
            this.LogarithmTwoArgument.TabIndex = 32;
            this.LogarithmTwoArgument.Text = "logy(x)";
            this.LogarithmTwoArgument.UseVisualStyleBackColor = true;
            this.LogarithmTwoArgument.Click += new System.EventHandler(this.button1_Click);
            // 
            // SquaringDivisionTwoArguments
            // 
            this.SquaringDivisionTwoArguments.Location = new System.Drawing.Point(808, 136);
            this.SquaringDivisionTwoArguments.Margin = new System.Windows.Forms.Padding(4);
            this.SquaringDivisionTwoArguments.Name = "SquaringDivisionTwoArguments";
            this.SquaringDivisionTwoArguments.Size = new System.Drawing.Size(64, 54);
            this.SquaringDivisionTwoArguments.TabIndex = 33;
            this.SquaringDivisionTwoArguments.Text = "x^(1/y)";
            this.SquaringDivisionTwoArguments.UseVisualStyleBackColor = true;
            this.SquaringDivisionTwoArguments.Click += new System.EventHandler(this.button1_Click);
            // 
            // SquareDifference
            // 
            this.SquareDifference.Location = new System.Drawing.Point(808, 262);
            this.SquareDifference.Margin = new System.Windows.Forms.Padding(4);
            this.SquareDifference.Name = "SquareDifference";
            this.SquareDifference.Size = new System.Drawing.Size(59, 53);
            this.SquareDifference.TabIndex = 43;
            this.SquareDifference.Text = "x^2-y^2";
            this.SquareDifference.UseVisualStyleBackColor = true;
            this.SquareDifference.Click += new System.EventHandler(this.button1_Click);
            // 
            // negativeDegree
            // 
            this.negativeDegree.Location = new System.Drawing.Point(669, 262);
            this.negativeDegree.Margin = new System.Windows.Forms.Padding(4);
            this.negativeDegree.Name = "negativeDegree";
            this.negativeDegree.Size = new System.Drawing.Size(59, 53);
            this.negativeDegree.TabIndex = 42;
            this.negativeDegree.Text = "x^(-y)";
            this.negativeDegree.UseVisualStyleBackColor = true;
            this.negativeDegree.Click += new System.EventHandler(this.button1_Click);
            // 
            // percent
            // 
            this.percent.Location = new System.Drawing.Point(586, 261);
            this.percent.Margin = new System.Windows.Forms.Padding(4);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(59, 53);
            this.percent.TabIndex = 41;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.button1_Click);
            // 
            // SquareSum
            // 
            this.SquareSum.Location = new System.Drawing.Point(440, 261);
            this.SquareSum.Margin = new System.Windows.Forms.Padding(4);
            this.SquareSum.Name = "SquareSum";
            this.SquareSum.Size = new System.Drawing.Size(59, 53);
            this.SquareSum.TabIndex = 40;
            this.SquareSum.Text = "(x+y)^2";
            this.SquareSum.UseVisualStyleBackColor = true;
            this.SquareSum.Click += new System.EventHandler(this.button1_Click);
            // 
            // SquareAdd
            // 
            this.SquareAdd.Location = new System.Drawing.Point(514, 261);
            this.SquareAdd.Margin = new System.Windows.Forms.Padding(4);
            this.SquareAdd.Name = "SquareAdd";
            this.SquareAdd.Size = new System.Drawing.Size(59, 53);
            this.SquareAdd.TabIndex = 39;
            this.SquareAdd.Text = "x^2+y^2";
            this.SquareAdd.UseVisualStyleBackColor = true;
            this.SquareAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(741, 262);
            this.Negative.Margin = new System.Windows.Forms.Padding(4);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(59, 53);
            this.Negative.TabIndex = 38;
            this.Negative.Text = "x*-1";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(373, 260);
            this.Root.Margin = new System.Windows.Forms.Padding(4);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(59, 53);
            this.Root.TabIndex = 37;
            this.Root.Text = "Root";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 463);
            this.Controls.Add(this.SquareDifference);
            this.Controls.Add(this.negativeDegree);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.SquareSum);
            this.Controls.Add(this.SquareAdd);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.SquaringDivisionTwoArguments);
            this.Controls.Add(this.LogarithmTwoArgument);
            this.Controls.Add(this.Cosinus);
            this.Controls.Add(this.Exponent);
            this.Controls.Add(this.NegativeArgument);
            this.Controls.Add(this.TenSquaringArgument);
            this.Controls.Add(this.TwoSquaringArgument);
            this.Controls.Add(this.TenLogarithmArgument);
            this.Controls.Add(this.Arccosinus);
            this.Controls.Add(this.OneDivisionArgument);
            this.Controls.Add(this.Arctangent);
            this.Controls.Add(this.Ctangent);
            this.Controls.Add(this.TwoLogarithmArgument);
            this.Controls.Add(this.Arcsinus);
            this.Controls.Add(this.Tangent);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button NegativeArgument;
        private System.Windows.Forms.Button TenSquaringArgument;
        private System.Windows.Forms.Button TwoSquaringArgument;
        private System.Windows.Forms.Button TenLogarithmArgument;
        private System.Windows.Forms.Button Arccosinus;
        private System.Windows.Forms.Button OneDivisionArgument;
        private System.Windows.Forms.Button Arctangent;
        private System.Windows.Forms.Button Ctangent;
        private System.Windows.Forms.Button TwoLogarithmArgument;
        private System.Windows.Forms.Button Arcsinus;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button SquaringTwoArguments;
        private System.Windows.Forms.Button Exponent;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button LogarithmTwoArgument;
        private System.Windows.Forms.Button SquaringDivisionTwoArguments;
        private System.Windows.Forms.Button SquareDifference;
        private System.Windows.Forms.Button negativeDegree;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button SquareSum;
        private System.Windows.Forms.Button SquareAdd;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button Root;
    }
}

