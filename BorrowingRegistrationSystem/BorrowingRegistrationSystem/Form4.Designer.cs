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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btndashboard
            // 
            btndashboard.BackColor = Color.FromArgb(128, 255, 255);
            btndashboard.Font = new Font("Stencil", 9F);
            btndashboard.Location = new Point(249, 12);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(168, 29);
            btndashboard.TabIndex = 0;
            btndashboard.Text = "DASHBOARD";
            btndashboard.UseVisualStyleBackColor = false;
            // 
            // btnborrowing
            // 
            btnborrowing.BackColor = Color.FromArgb(128, 255, 255);
            btnborrowing.Font = new Font("Stencil", 9F);
            btnborrowing.Location = new Point(558, 12);
            btnborrowing.Name = "btnborrowing";
            btnborrowing.Size = new Size(168, 29);
            btnborrowing.TabIndex = 1;
            btnborrowing.Text = "BORROWING EQUIPMENT";
            btnborrowing.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 255, 255);
            button3.Font = new Font("Stencil", 9F);
            button3.Location = new Point(856, 12);
            button3.Name = "button3";
            button3.Size = new Size(168, 29);
            button3.TabIndex = 2;
            button3.Text = "MY PREFERENCES";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 255);
            label1.Font = new Font("Britannic Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(138, 31);
            label1.TabIndex = 3;
            label1.Text = "STEM_TVL";
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
            pictureBox1.Location = new Point(-3, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1197, 52);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 498);
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
    }
}