namespace Desktop
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label8 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            comboBox2 = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(101, 333);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(355, 54);
            button1.TabIndex = 0;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 71);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 221);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(175, 37);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 74);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(152, 111);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 7;
            label3.Text = "Gender:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(101, 72);
            label4.Name = "label4";
            label4.Size = new Size(154, 23);
            label4.TabIndex = 8;
            label4.Text = "Email/Mob Num:";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            comboBox1.Location = new Point(258, 180);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(163, 28);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(72, 182);
            label5.Name = "label5";
            label5.Size = new Size(180, 23);
            label5.TabIndex = 12;
            label5.Text = "Select Blood Group:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(127, 146);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 13;
            label6.Text = "Date of Birth:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 146);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " dd/mm/yyyy";
            textBox3.Size = new Size(207, 27);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(152, 221);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 15;
            label7.Text = "Username:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(258, 37);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(273, 27);
            textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(258, 255);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 27);
            textBox5.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(154, 259);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 18;
            label8.Text = "Password:";
            // 
            // button2
            // 
            button2.Location = new Point(763, 12);
            button2.Name = "button2";
            button2.Size = new Size(100, 38);
            button2.TabIndex = 19;
            button2.Text = "Cencel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(90, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 394);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "sign up info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-" });
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female", "Others" });
            comboBox2.Location = new Point(258, 111);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(163, 28);
            comboBox2.TabIndex = 20;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 599);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private Button button2;
        private GroupBox groupBox1;
        private ComboBox comboBox2;
    }
}