namespace MultiThreadEventApp
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtNumbersResult = new System.Windows.Forms.TextBox();
            this.txtSumResult = new System.Windows.Forms.TextBox();
            this.txtProductResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(101, 78);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // txtNumbersResult
            // 
            this.txtNumbersResult.Location = new System.Drawing.Point(221, 80);
            this.txtNumbersResult.Multiline = true;
            this.txtNumbersResult.Name = "txtNumbersResult";
            this.txtNumbersResult.Size = new System.Drawing.Size(100, 188);
            this.txtNumbersResult.TabIndex = 1;
            // 
            // txtSumResult
            // 
            this.txtSumResult.Location = new System.Drawing.Point(360, 80);
            this.txtSumResult.Multiline = true;
            this.txtSumResult.Name = "txtSumResult";
            this.txtSumResult.Size = new System.Drawing.Size(100, 188);
            this.txtSumResult.TabIndex = 2;
            // 
            // txtProductResult
            // 
            this.txtProductResult.Location = new System.Drawing.Point(495, 78);
            this.txtProductResult.Multiline = true;
            this.txtProductResult.Name = "txtProductResult";
            this.txtProductResult.Size = new System.Drawing.Size(100, 190);
            this.txtProductResult.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Генерация чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Сумма чисел";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Произведение чисел";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductResult);
            this.Controls.Add(this.txtSumResult);
            this.Controls.Add(this.txtNumbersResult);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtNumbersResult;
        private System.Windows.Forms.TextBox txtSumResult;
        private System.Windows.Forms.TextBox txtProductResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

