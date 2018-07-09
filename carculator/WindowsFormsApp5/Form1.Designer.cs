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
            this.Mult = new System.Windows.Forms.Button();
            this.Div = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Mult
            // 
            this.Mult.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mult.Location = new System.Drawing.Point(24, 74);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(49, 56);
            this.Mult.TabIndex = 0;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            this.Mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // Div
            // 
            this.Div.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Div.Location = new System.Drawing.Point(95, 74);
            this.Div.Name = "Div";
            this.Div.Size = new System.Drawing.Size(49, 56);
            this.Div.TabIndex = 1;
            this.Div.Text = "/";
            this.Div.UseVisualStyleBackColor = true;
            this.Div.Click += new System.EventHandler(this.button2_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sum.Location = new System.Drawing.Point(190, 74);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(49, 56);
            this.sum.TabIndex = 2;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sub.Location = new System.Drawing.Point(261, 74);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(49, 56);
            this.sub.TabIndex = 3;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
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
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.Mult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Mult;
        private System.Windows.Forms.Button Div;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.TextBox res;
    }
}

