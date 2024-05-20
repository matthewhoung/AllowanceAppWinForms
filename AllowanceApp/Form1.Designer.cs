namespace AllowanceApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            this.outsideCateringCheckBox = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 350);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(370, 12);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 350);
            textBox2.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(610, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(504, 368);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "加總";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SumButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 368);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "清除";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ClearButton_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 368);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "計算";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CalculateButton_Click;
            // 
            // checkBox1
            // 
            this.outsideCateringCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // outsideCateringCheckBox
            // 
            this.outsideCateringCheckBox.Location = new System.Drawing.Point(12, 412);
            this.outsideCateringCheckBox.Name = "outsideCateringCheckBox";
            this.outsideCateringCheckBox.Size = new System.Drawing.Size(104, 24);
            this.outsideCateringCheckBox.TabIndex = 6;
            this.outsideCateringCheckBox.Text = "Outside Catering";
            this.outsideCateringCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 438);
            Controls.Add(outsideCateringCheckBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Allowance App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox outsideCateringCheckBox;
    }
}
