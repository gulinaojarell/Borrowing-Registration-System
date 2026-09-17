namespace BorrowingRegistrationSystem
{
    partial class Form4
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
            btndashboard = new Button();
            btnborrowing = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btndashboard
            // 
            btndashboard.BackColor = Color.Black;
            btndashboard.Font = new Font("Stencil", 12F);
            btndashboard.ForeColor = Color.White;
            btndashboard.Location = new Point(237, 22);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(168, 29);
            btndashboard.TabIndex = 0;
            btndashboard.Text = "DASHBOARD";
            btndashboard.UseVisualStyleBackColor = false;
            // 
            // btnborrowing
            // 
            btnborrowing.BackColor = Color.Black;
            btnborrowing.Font = new Font("Stencil", 12F);
            btnborrowing.ForeColor = Color.White;
            btnborrowing.Location = new Point(546, 22);
            btnborrowing.Name = "btnborrowing";
            btnborrowing.Size = new Size(168, 29);
            btnborrowing.TabIndex = 1;
            btnborrowing.Text = "BORROWING EQUIPMENT";
            btnborrowing.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Stencil", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(861, 22);
            button3.Name = "button3";
            button3.Size = new Size(192, 29);
            button3.TabIndex = 2;
            button3.Text = "MY PREFERENCES";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(218, 135);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 3;
            label1.Text = "STEM-TVL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 166);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "STEM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 280);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 5;
            label3.Text = "TVL";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(128, 255, 255);
            pictureBox1.BackgroundImage = Properties.Resources.bg9;
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1199, 66);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(203, 46);
            label4.TabIndex = 7;
            label4.Text = "STEM - TVL";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.images__1__removebg_preview;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1071, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(444, 317);
            button1.Name = "button1";
            button1.Size = new Size(146, 48);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(729, 317);
            button2.Name = "button2";
            button2.Size = new Size(146, 48);
            button2.TabIndex = 10;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 498);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(btnborrowing);
            Controls.Add(btndashboard);
            Controls.Add(pictureBox1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btndashboard;
        private Button btnborrowing;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label4;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
    }
}