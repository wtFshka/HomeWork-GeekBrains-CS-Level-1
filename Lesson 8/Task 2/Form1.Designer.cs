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
            this.nudMain = new System.Windows.Forms.NumericUpDown();
            this.tbMain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMain)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMain
            // 
            this.nudMain.Location = new System.Drawing.Point(66, 77);
            this.nudMain.Name = "nudMain";
            this.nudMain.Size = new System.Drawing.Size(62, 20);
            this.nudMain.TabIndex = 0;
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(66, 12);
            this.tbMain.Name = "tbMain";
            this.tbMain.Size = new System.Drawing.Size(62, 20);
            this.tbMain.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 109);
            this.Controls.Add(this.tbMain);
            this.Controls.Add(this.nudMain);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMain;
        private System.Windows.Forms.TextBox tbMain;
    }
}

