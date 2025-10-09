namespace Tickect_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            listBox1 = new ListBox();
            button4 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            maskedTextBox3 = new MaskedTextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 64, 0);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(307, 35);
            label1.Name = "label1";
            label1.Size = new Size(221, 33);
            label1.TabIndex = 1;
            label1.Text = "TRAVEL TİCKET";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(43, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 192, 192);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 373);
            panel2.Name = "panel2";
            panel2.Size = new Size(713, 148);
            panel2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(43, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(641, 79);
            listBox1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(529, 104);
            button4.Name = "button4";
            button4.Size = new Size(155, 32);
            button4.TabIndex = 1;
            button4.Text = "Proqramdan çıxış";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(43, 104);
            button3.Name = "button3";
            button3.Size = new Size(155, 32);
            button3.TabIndex = 0;
            button3.Text = "Siyahıdan sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(43, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(312, 248);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Tag = "";
            groupBox1.Text = " Marşurut";
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(264, 28);
            button2.Name = "button2";
            button2.Size = new Size(28, 73);
            button2.TabIndex = 10;
            button2.Text = "<\r\n>\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 209);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(114, 170);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(161, 23);
            maskedTextBox2.TabIndex = 8;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(114, 128);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(161, 23);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bakı", "İstanbul", "Tehran", "Praqa", "Pekin" });
            comboBox2.Location = new Point(114, 78);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(142, 23);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bakı", "İstanbul", "Tehran", "Praqa", "Pekin" });
            comboBox1.Location = new Point(114, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 212);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 4;
            label6.Text = "Yer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 170);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 3;
            label5.Text = "Saat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 131);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Tarix:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 78);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 1;
            label3.Text = "Haraya:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 31);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(397, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 248);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sərnişin məlumatları";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(132, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 10;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(132, 131);
            maskedTextBox3.Mask = "(+994) 00-000-00-00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(137, 23);
            maskedTextBox3.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(132, 86);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(137, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(161, 209);
            button1.Name = "button1";
            button1.Size = new Size(108, 30);
            button1.TabIndex = 4;
            button1.Text = "Bilet al";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 170);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 3;
            label10.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 131);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 2;
            label9.Text = "Telefon:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 86);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 1;
            label8.Text = "FİN:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 41);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 0;
            label7.Text = "Ad və soyad:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(713, 521);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Travel ticket";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ListBox listBox1;
        private Button button4;
        private Button button3;
    }
}
