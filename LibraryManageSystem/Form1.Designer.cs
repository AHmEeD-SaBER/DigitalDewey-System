namespace LibraryManageSystem
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
            label1 = new Label();
            Usernamelb = new Label();
            Passwordlb = new Label();
            userBox = new TextBox();
            passBox = new TextBox();
            signUpBtn = new Button();
            loginBtn = new Button();
            showPassBtn1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(380, 9);
            label1.Name = "label1";
            label1.Size = new Size(367, 89);
            label1.TabIndex = 0;
            label1.Text = "Login to DigitalDewey";
            // 
            // Usernamelb
            // 
            Usernamelb.Anchor = AnchorStyles.None;
            Usernamelb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Usernamelb.ForeColor = Color.Aqua;
            Usernamelb.Location = new Point(230, 233);
            Usernamelb.Name = "Usernamelb";
            Usernamelb.Size = new Size(173, 51);
            Usernamelb.TabIndex = 1;
            Usernamelb.Text = "Username:";
            // 
            // Passwordlb
            // 
            Passwordlb.Anchor = AnchorStyles.None;
            Passwordlb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Passwordlb.ForeColor = Color.Aqua;
            Passwordlb.Location = new Point(238, 341);
            Passwordlb.Name = "Passwordlb";
            Passwordlb.Size = new Size(165, 51);
            Passwordlb.TabIndex = 2;
            Passwordlb.Text = "Password:";
            // 
            // userBox
            // 
            userBox.Anchor = AnchorStyles.None;
            userBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            userBox.Location = new Point(409, 233);
            userBox.Name = "userBox";
            userBox.Size = new Size(487, 51);
            userBox.TabIndex = 3;
            // 
            // passBox
            // 
            passBox.Anchor = AnchorStyles.None;
            passBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            passBox.Location = new Point(409, 341);
            passBox.Name = "passBox";
            passBox.PasswordChar = '*';
            passBox.Size = new Size(487, 51);
            passBox.TabIndex = 4;
            passBox.TextChanged += textBox_Changed;
            // 
            // signUpBtn
            // 
            signUpBtn.Anchor = AnchorStyles.None;
            signUpBtn.BackColor = Color.Transparent;
            signUpBtn.FlatStyle = FlatStyle.Flat;
            signUpBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            signUpBtn.ForeColor = Color.Aqua;
            signUpBtn.Location = new Point(480, 520);
            signUpBtn.Name = "signUpBtn";
            signUpBtn.Size = new Size(124, 60);
            signUpBtn.TabIndex = 5;
            signUpBtn.Text = "SignUp";
            signUpBtn.UseVisualStyleBackColor = false;
            signUpBtn.Click += signUpBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.Anchor = AnchorStyles.None;
            loginBtn.BackColor = Color.Aqua;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn.Location = new Point(230, 436);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(666, 57);
            loginBtn.TabIndex = 6;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // showPassBtn1
            // 
            showPassBtn1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            showPassBtn1.Location = new Point(902, 363);
            showPassBtn1.Name = "showPassBtn1";
            showPassBtn1.Size = new Size(94, 29);
            showPassBtn1.TabIndex = 7;
            showPassBtn1.Text = "show";
            showPassBtn1.UseVisualStyleBackColor = true;
            showPassBtn1.Click += showPassBtn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1126, 724);
            Controls.Add(showPassBtn1);
            Controls.Add(loginBtn);
            Controls.Add(signUpBtn);
            Controls.Add(passBox);
            Controls.Add(userBox);
            Controls.Add(Passwordlb);
            Controls.Add(Usernamelb);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "DigitalDewey";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Usernamelb;
        private Label Passwordlb;
        private TextBox userBox;
        private TextBox passBox;
        private Button signUpBtn;
        private Button loginBtn;
        private Button showPassBtn1;
    }
}
