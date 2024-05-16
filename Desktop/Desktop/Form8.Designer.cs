namespace Desktop
{
    partial class Form8
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
            checkBox1 = new CheckBox();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Font = new Font("Sitka Subheading", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(283, 433);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(372, 53);
            button1.TabIndex = 52;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(295, 387);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 51;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(319, 387);
            label2.Name = "label2";
            label2.Size = new Size(216, 19);
            label2.TabIndex = 36;
            label2.Text = "Are You sure to remove this person";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Sitka Subheading", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(403, 44);
            label1.Name = "label1";
            label1.Size = new Size(177, 35);
            label1.TabIndex = 35;
            label1.Text = "Remove Donor";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(385, 105);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = " Search";
            textBox3.Size = new Size(218, 27);
            textBox3.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(344, 111);
            label4.Name = "label4";
            label4.Size = new Size(38, 24);
            label4.TabIndex = 53;
            label4.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(217, 164);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(585, 195);
            dataGridView1.TabIndex = 54;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form8";
            Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label label4;
        private DataGridView dataGridView1;
    }
}