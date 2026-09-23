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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            BtnBack = new Button();
            BtnLog = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 342);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(198, 26);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 29);
            label2.TabIndex = 4;
            label2.Text = "Welcome Back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(171, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 29);
            label1.TabIndex = 5;
            label1.Text = "Login to your account";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(16, 196);
            label8.Name = "label8";
            label8.Size = new Size(97, 25);
            label8.TabIndex = 19;
            label8.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(6, 136);
            label5.Name = "label5";
            label5.Size = new Size(137, 25);
            label5.TabIndex = 18;
            label5.Text = "Full Name/Lrn:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 191);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 30);
            textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 30);
            textBox2.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(BtnBack);
            groupBox1.Controls.Add(BtnLog);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(257, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 389);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Navy;
            BtnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBack.ForeColor = Color.White;
            BtnBack.Location = new Point(324, 279);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(121, 38);
            BtnBack.TabIndex = 25;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += button2_Click;
            // 
            // BtnLog
            // 
            BtnLog.BackColor = Color.Navy;
            BtnLog.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLog.ForeColor = Color.White;
            BtnLog.Location = new Point(50, 279);
            BtnLog.Name = "BtnLog";
            BtnLog.Size = new Size(121, 38);
            BtnLog.TabIndex = 24;
            BtnLog.Text = "Login";
            BtnLog.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(149, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 41);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources._5087607;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(149, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 41);
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            BackgroundImage = Properties.Resources._816123254_1070533205751118_4491962060484800000_n__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 518);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form3";
            Text = "Form3";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button BtnBack;
        private Button BtnLog;
    }
}