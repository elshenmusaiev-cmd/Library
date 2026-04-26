namespace Regestration
{
    partial class Form2
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(292, 102);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Name";
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(292, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 1;
            textBox2.Text = "Surname";
            // 
            // textBox3
            // 
            textBox3.ForeColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(292, 215);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(193, 27);
            textBox3.TabIndex = 2;
            textBox3.Text = "Email";
            // 
            // textBox4
            // 
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(292, 279);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(193, 27);
            textBox4.TabIndex = 3;
            textBox4.Text = "UserName";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.ForeColor = SystemColors.ScrollBar;
            textBox5.Location = new Point(292, 339);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(193, 27);
            textBox5.TabIndex = 4;
            textBox5.Text = "Password";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 105);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 162);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 6;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 222);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 282);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 8;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 346);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(292, 394);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(202, 27);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2005, 10, 20, 15, 34, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 399);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "BirthDate";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = UserInterface.Properties.Resources.geo;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
    }
}