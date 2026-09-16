namespace BorrowingRegistrationSystem
{
    partial class Form3
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
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            textBox3 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(342, 297);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(233, 194);
            label3.Name = "label3";
            label3.Size = new Size(90, 23);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(195, 162);
            label6.Name = "label6";
            label6.Size = new Size(128, 23);
            label6.TabIndex = 5;
            label6.Text = "Username/Lrn:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Location = new Point(354, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(219, 27);
            textBox2.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(354, 232);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 21);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password:";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(354, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 27);
            textBox3.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(382, 75);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 12;
            label1.Text = "Welcome Back!";
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(264, 308);
            button3.Name = "button3";
            button3.Size = new Size(121, 38);
            button3.TabIndex = 13;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(469, 308);
            button4.Name = "button4";
            button4.Size = new Size(121, 38);
            button4.TabIndex = 21;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(354, 98);
            label2.Name = "label2";
            label2.Size = new Size(185, 23);
            label2.TabIndex = 22;
            label2.Text = "Login to your account";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(184, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(447, 314);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private TextBox textBox3;
        private Label label1;
        private Button button3;
        private Button button4;
        private Label label2;
        private GroupBox groupBox1;
    }
}