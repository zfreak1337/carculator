namespace WindowsFormsApp5
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
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiplication.Location = new System.Drawing.Point(24, 74);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(49, 56);
            this.Multiplication.TabIndex = 0;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Division.Location = new System.Drawing.Point(95, 74);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(49, 56);
            this.Division.TabIndex = 1;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.button2_Click);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(190, 74);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(49, 56);
            this.Plus.TabIndex = 2;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.sum_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(261, 74);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(49, 56);
            this.Minus.TabIndex = 3;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.sub_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(24, 46);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(120, 22);
            this.num1.TabIndex = 5;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(190, 46);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(120, 22);
            this.num2.TabIndex = 6;
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(69, 155);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(195, 22);
            this.res.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 393);
            this.Controls.Add(this.res);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox res;
    }
}

