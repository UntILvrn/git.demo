namespace TextFile1_1_3
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.Delete1strButton = new System.Windows.Forms.Button();
            this.DeletelastButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeleteNumber = new System.Windows.Forms.Button();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(71, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(119, 23);
            this.LoadButton.TabIndex = 0;
            this.LoadButton.Text = "Загрузить файл";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Delete1strButton
            // 
            this.Delete1strButton.Location = new System.Drawing.Point(136, 41);
            this.Delete1strButton.Name = "Delete1strButton";
            this.Delete1strButton.Size = new System.Drawing.Size(119, 23);
            this.Delete1strButton.TabIndex = 2;
            this.Delete1strButton.Text = "Удалить первую строку";
            this.Delete1strButton.UseVisualStyleBackColor = true;
            this.Delete1strButton.Click += new System.EventHandler(this.Delete1strButton_Click);
            // 
            // DeletelastButton
            // 
            this.DeletelastButton.Location = new System.Drawing.Point(12, 41);
            this.DeletelastButton.Name = "DeletelastButton";
            this.DeletelastButton.Size = new System.Drawing.Size(119, 23);
            this.DeletelastButton.TabIndex = 3;
            this.DeletelastButton.Text = "Удалить последнюю";
            this.DeletelastButton.UseVisualStyleBackColor = true;
            this.DeletelastButton.Click += new System.EventHandler(this.DeletelastButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(11, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 175);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DeleteNumber
            // 
            this.DeleteNumber.Location = new System.Drawing.Point(12, 70);
            this.DeleteNumber.Name = "DeleteNumber";
            this.DeleteNumber.Size = new System.Drawing.Size(119, 23);
            this.DeleteNumber.TabIndex = 6;
            this.DeleteNumber.Text = "Удалить строку";
            this.DeleteNumber.UseVisualStyleBackColor = true;
            this.DeleteNumber.Click += new System.EventHandler(this.DeleteNumber_Click);
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(138, 71);
            this.DeleteTextBox.Multiline = true;
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(52, 22);
            this.DeleteTextBox.TabIndex = 7;
            this.DeleteTextBox.Text = "0";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(136, 99);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(119, 175);
            this.OutputTextBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 279);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.DeleteTextBox);
            this.Controls.Add(this.DeleteNumber);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeletelastButton);
            this.Controls.Add(this.Delete1strButton);
            this.Controls.Add(this.LoadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button Delete1strButton;
        private System.Windows.Forms.Button DeletelastButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeleteNumber;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
    }
}

