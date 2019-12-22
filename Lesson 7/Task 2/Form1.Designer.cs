namespace Task_2
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
            this.lblGameDecripton = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGameDecripton
            // 
            this.lblGameDecripton.AutoSize = true;
            this.lblGameDecripton.Location = new System.Drawing.Point(12, 32);
            this.lblGameDecripton.Name = "lblGameDecripton";
            this.lblGameDecripton.Size = new System.Drawing.Size(360, 17);
            this.lblGameDecripton.TabIndex = 0;
            this.lblGameDecripton.Text = "Я загадал число от  1 до 100, попробуте его угадать!";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(118, 77);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(127, 40);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Мне повезёт!";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 142);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblGameDecripton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угодай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameDecripton;
        private System.Windows.Forms.Button btnNext;
    }
}

