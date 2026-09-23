namespace BorrowingRegistrationSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label2 = new Label();
            label3 = new Label();
            TxtLrn = new TextBox();
            TxtEmailAdd = new TextBox();
            TxtPass = new TextBox();
            BtnReg = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            TxtFullName = new TextBox();
            label8 = new Label();
            TxtCpass = new TextBox();
            label9 = new Label();
            BtnBack = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ChkSame = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(656, 44);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(225, 29);
            label2.TabIndex = 1;
            label2.Text = "Create an Account";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(604, 88);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(332, 18);
            label3.TabIndex = 2;
            label3.Text = "Join our system and start reserving equipmemnts";
            label3.Click += label3_Click;
            // 
            // TxtLrn
            // 
            TxtLrn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            TxtLrn.Location = new Point(645, 190);
            TxtLrn.Margin = new Padding(4, 2, 4, 2);
            TxtLrn.Name = "TxtLrn";
            TxtLrn.Size = new Size(308, 30);
            TxtLrn.TabIndex = 4;
            // 
            // TxtEmailAdd
            // 
            TxtEmailAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            TxtEmailAdd.Location = new Point(645, 235);
            TxtEmailAdd.Margin = new Padding(4, 2, 4, 2);
            TxtEmailAdd.Name = "TxtEmailAdd";
            TxtEmailAdd.Size = new Size(308, 30);
            TxtEmailAdd.TabIndex = 5;
            // 
            // TxtPass
            // 
            TxtPass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            TxtPass.Location = new Point(645, 291);
            TxtPass.Margin = new Padding(4, 2, 4, 2);
            TxtPass.Name = "TxtPass";
            TxtPass.Size = new Size(308, 30);
            TxtPass.TabIndex = 6;
            // 
            // BtnReg
            // 
            BtnReg.BackColor = Color.Navy;
            BtnReg.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReg.ForeColor = Color.White;
            BtnReg.Location = new Point(457, 439);
            BtnReg.Name = "BtnReg";
            BtnReg.Size = new Size(121, 38);
            BtnReg.TabIndex = 10;
            BtnReg.Text = "Register";
            BtnReg.UseVisualStyleBackColor = false;
            BtnReg.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(457, 140);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 12;
            label5.Text = "Full Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(423, 240);
            label6.Name = "label6";
            label6.Size = new Size(136, 25);
            label6.TabIndex = 13;
            label6.Text = "Email Address:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(462, 291);
            label7.Name = "label7";
            label7.Size = new Size(97, 25);
            label7.TabIndex = 14;
            label7.Text = "Password:";
            // 
            // TxtFullName
            // 
            TxtFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            TxtFullName.Location = new Point(645, 140);
            TxtFullName.Margin = new Padding(4, 2, 4, 2);
            TxtFullName.Name = "TxtFullName";
            TxtFullName.Size = new Size(308, 30);
            TxtFullName.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(507, 191);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 17;
            label8.Text = "LRN:";
            // 
            // TxtCpass
            // 
            TxtCpass.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            TxtCpass.Location = new Point(645, 352);
            TxtCpass.Margin = new Padding(4, 2, 4, 2);
            TxtCpass.Name = "TxtCpass";
            TxtCpass.Size = new Size(308, 30);
            TxtCpass.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(389, 352);
            label9.Name = "label9";
            label9.Size = new Size(170, 25);
            label9.TabIndex = 19;
            label9.Text = "Confirm Password:";
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Navy;
            BtnBack.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnBack.ForeColor = Color.White;
            BtnBack.Location = new Point(862, 439);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(121, 38);
            BtnBack.TabIndex = 20;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources._5087607;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(565, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(61, 42);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(565, 223);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(61, 42);
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = Properties.Resources._5087607;
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(565, 179);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 42);
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.BackgroundImage = Properties.Resources._5087607;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(565, 278);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 42);
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.BackgroundImage = Properties.Resources._5087607;
            pictureBox6.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox6.Location = new Point(565, 338);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(61, 42);
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // ChkSame
            // 
            ChkSame.AutoSize = true;
            ChkSame.BackColor = Color.Transparent;
            ChkSame.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChkSame.ForeColor = Color.Blue;
            ChkSame.Location = new Point(722, 326);
            ChkSame.Name = "ChkSame";
            ChkSame.Size = new Size(231, 21);
            ChkSame.TabIndex = 26;
            ChkSame.Text = "Same as your previous password";
            ChkSame.UseVisualStyleBackColor = false;
            ChkSame.CheckedChanged += ChkSame_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 255, 255);
            BackgroundImage = Properties.Resources._818291030_1723079875423712_7099495941803114957_n;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1039, 534);
            Controls.Add(ChkSame);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(BtnBack);
            Controls.Add(label9);
            Controls.Add(TxtCpass);
            Controls.Add(label8);
            Controls.Add(TxtFullName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(BtnReg);
            Controls.Add(TxtPass);
            Controls.Add(TxtEmailAdd);
            Controls.Add(TxtLrn);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            Margin = new Padding(9, 8, 9, 8);
            Name = "Form2";
            Text = "STEM - TVL";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox TxtLrn;
        private TextBox TxtEmailAdd;
        private TextBox TxtPass;
        private Button BtnReg;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox TxtFullName;
        private Label label8;
        private TextBox TxtCpass;
        private Label label9;
        private Button BtnBack;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private CheckBox ChkSame;
    }
}