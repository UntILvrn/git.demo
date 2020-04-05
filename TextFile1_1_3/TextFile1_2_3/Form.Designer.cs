namespace TextFile1_2_3
{
    partial class Form
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 237);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(157, 12);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(115, 23);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Загрузить файл";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(157, 41);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(115, 23);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Подсчитать";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(157, 71);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(63, 13);
            this.Label.TabIndex = 3;
            this.Label.Text = "Элементов";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(220, 71);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultLabel.TabIndex = 4;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label ResultLabel;
    }
}

