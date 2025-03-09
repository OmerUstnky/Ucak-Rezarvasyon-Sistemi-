namespace Ucus_Rezarvasyon_Sistemi
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
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            button1 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 34);
            textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Location = new Point(55, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(455, 261);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(417, 77);
            button2.Name = "button2";
            button2.Size = new Size(38, 37);
            button2.TabIndex = 18;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(189, 204);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(228, 34);
            maskedTextBox1.TabIndex = 10;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(81, 204);
            label4.Name = "label4";
            label4.Size = new Size(70, 27);
            label4.TabIndex = 8;
            label4.Text = "Saat :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 156);
            label3.Name = "label3";
            label3.Size = new Size(81, 27);
            label3.TabIndex = 7;
            label3.Text = "Tarih :";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 111);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 4;
            label2.Text = "Nereye :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 63);
            label1.Name = "label1";
            label1.Size = new Size(112, 27);
            label1.TabIndex = 3;
            label1.Text = "Nereden :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePicker1.Location = new Point(189, 156);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 34);
            dateTimePicker1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Konya", "Samsun" });
            comboBox2.Location = new Point(189, 103);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(228, 35);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ankara", "Bursa", "Adana", "Elazığ", "Konya", "Samsun" });
            comboBox1.Location = new Point(189, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 35);
            comboBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(581, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(464, 261);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(81, 156);
            label7.Name = "label7";
            label7.Size = new Size(101, 27);
            label7.TabIndex = 16;
            label7.Text = "Telefon :";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(194, 204);
            button1.Name = "button1";
            button1.Size = new Size(228, 39);
            button1.TabIndex = 11;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(194, 153);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(228, 34);
            maskedTextBox3.TabIndex = 15;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(194, 108);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(228, 34);
            maskedTextBox2.TabIndex = 13;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 111);
            label6.Name = "label6";
            label6.Size = new Size(90, 27);
            label6.TabIndex = 12;
            label6.Text = "TC No :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 34);
            textBox2.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 63);
            label5.Name = "label5";
            label5.Size = new Size(182, 27);
            label5.TabIndex = 11;
            label5.Text = "Yolcu Ad Soyad :";
            label5.Click += label5_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label8);
            panel1.Location = new Point(55, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(990, 93);
            panel1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Vladimir Script", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(93, 10);
            label8.Name = "label8";
            label8.Size = new Size(793, 73);
            label8.TabIndex = 0;
            label8.Text = "SATÜRN HAVA YOLLARI";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 27;
            listBox1.Location = new Point(55, 409);
            listBox1.MultiColumn = true;
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(990, 85);
            listBox1.TabIndex = 17;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 503);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Font = new Font("Georgia", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            Text = "Ucak Rezarvasyon Sistemi";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Button button1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private Label label6;
        private TextBox textBox2;
        private Panel panel1;
        private Label label8;
        private ListBox listBox1;
        private Label label7;
        private Button button2;
    }
}
