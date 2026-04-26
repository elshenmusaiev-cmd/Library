namespace UserInterface
{
    partial class MainWindow
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
            panelHeader = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtSearch = new Button();
            pictureBox1 = new PictureBox();
            btnMenu = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveCaptionText;
            panelHeader.Controls.Add(button3);
            panelHeader.Controls.Add(button2);
            panelHeader.Controls.Add(button1);
            panelHeader.Controls.Add(txtSearch);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(btnMenu);
            panelHeader.Location = new Point(4, 3);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(694, 36);
            panelHeader.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(620, 4);
            button3.Name = "button3";
            button3.Size = new Size(66, 27);
            button3.TabIndex = 5;
            button3.Text = "Sign In";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(576, 5);
            button2.Name = "button2";
            button2.Size = new Size(39, 26);
            button2.TabIndex = 4;
            button2.Text = "\U0001f6d2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(532, 4);
            button1.Name = "button1";
            button1.Size = new Size(25, 29);
            button1.TabIndex = 3;
            button1.Text = "👤";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ActiveCaptionText;
            txtSearch.FlatStyle = FlatStyle.Flat;
            txtSearch.ForeColor = SystemColors.ButtonFace;
            txtSearch.Location = new Point(164, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(321, 25);
            txtSearch.TabIndex = 2;
            txtSearch.Text = "Search🔍";
            txtSearch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(46, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 36);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.ForeColor = SystemColors.Control;
            btnMenu.Location = new Point(0, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(27, 33);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(panelHeader);
            Name = "MainWindow";
            Text = "Library";
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

