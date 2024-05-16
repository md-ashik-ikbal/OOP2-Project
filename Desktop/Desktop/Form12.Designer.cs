namespace Desktop
{
    partial class Form12
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(433, 63);
            button3.Name = "button3";
            button3.Size = new Size(306, 103);
            button3.TabIndex = 2;
            button3.Text = "Check Blood Stock";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(433, 208);
            button4.Name = "button4";
            button4.Size = new Size(306, 113);
            button4.TabIndex = 3;
            button4.Text = "Search Blood Donar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(530, 380);
            button5.Name = "button5";
            button5.Size = new Size(120, 38);
            button5.TabIndex = 4;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 559);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button4;
        private Button button5;
    }
}