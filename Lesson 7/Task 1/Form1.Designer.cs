namespace Task_1
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
            this.lblValue = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.игратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValue.Location = new System.Drawing.Point(82, 78);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(36, 39);
            this.lblValue.TabIndex = 0;
            this.lblValue.Text = "0";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(210, 30);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(85, 32);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+1";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(210, 78);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(85, 27);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "x2";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(210, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 31);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Сброс";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(210, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отменить";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(318, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // игратьToolStripMenuItem
            // 
            this.игратьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewGame,
            this.tsmiExit});
            this.игратьToolStripMenuItem.Name = "игратьToolStripMenuItem";
            this.игратьToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.игратьToolStripMenuItem.Text = "Меню";
            // 
            // tsmiNewGame
            // 
            this.tsmiNewGame.Name = "tsmiNewGame";
            this.tsmiNewGame.Size = new System.Drawing.Size(140, 26);
            this.tsmiNewGame.Text = "Играть";
            this.tsmiNewGame.Click += new System.EventHandler(this.tsmiNewGame_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(140, 26);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(13, 176);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(70, 17);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "Попытка:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 218);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewGame;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Label lblCount;
    }
}

