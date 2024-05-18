namespace LibraryManageSystem
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            SIgninBtn = new Button();
            passBox = new TextBox();
            secondNameBox = new TextBox();
            Passwordlb = new Label();
            secondNamelb = new Label();
            adminRadiobtn = new RadioButton();
            studentRadiobtn = new RadioButton();
            firstNameBox = new TextBox();
            frstNamelb = new Label();
            userNameBox = new TextBox();
            userNamelb = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Aqua;
            label1.Location = new Point(333, 9);
            label1.Name = "label1";
            label1.Size = new Size(439, 89);
            label1.TabIndex = 1;
            label1.Text = "Welcome in DigitalDewey";
            // 
            // SIgninBtn
            // 
            SIgninBtn.Anchor = AnchorStyles.None;
            SIgninBtn.BackColor = Color.Aqua;
            SIgninBtn.FlatAppearance.BorderSize = 0;
            SIgninBtn.FlatStyle = FlatStyle.Flat;
            SIgninBtn.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            SIgninBtn.Location = new Point(150, 592);
            SIgninBtn.Name = "SIgninBtn";
            SIgninBtn.Size = new Size(726, 57);
            SIgninBtn.TabIndex = 11;
            SIgninBtn.Text = "SignUp";
            SIgninBtn.UseVisualStyleBackColor = false;
            SIgninBtn.Click += SIgninBtn_Click;
            // 
            // passBox
            // 
            passBox.Anchor = AnchorStyles.None;
            passBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            passBox.Location = new Point(389, 376);
            passBox.Name = "passBox";
            passBox.Size = new Size(487, 51);
            passBox.TabIndex = 10;
            // 
            // secondNameBox
            // 
            secondNameBox.Anchor = AnchorStyles.None;
            secondNameBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            secondNameBox.Location = new Point(389, 299);
            secondNameBox.Name = "secondNameBox";
            secondNameBox.Size = new Size(487, 51);
            secondNameBox.TabIndex = 9;
            // 
            // Passwordlb
            // 
            Passwordlb.Anchor = AnchorStyles.None;
            Passwordlb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Passwordlb.ForeColor = Color.Aqua;
            Passwordlb.Location = new Point(154, 382);
            Passwordlb.Name = "Passwordlb";
            Passwordlb.Size = new Size(225, 51);
            Passwordlb.TabIndex = 8;
            Passwordlb.Text = "Password:";
            // 
            // secondNamelb
            // 
            secondNamelb.Anchor = AnchorStyles.None;
            secondNamelb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            secondNamelb.ForeColor = Color.Aqua;
            secondNamelb.Location = new Point(158, 299);
            secondNamelb.Name = "secondNamelb";
            secondNamelb.Size = new Size(225, 51);
            secondNamelb.TabIndex = 7;
            secondNamelb.Text = "Second Name :";
            // 
            // adminRadiobtn
            // 
            adminRadiobtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            adminRadiobtn.ForeColor = Color.White;
            adminRadiobtn.Location = new Point(301, 455);
            adminRadiobtn.Name = "adminRadiobtn";
            adminRadiobtn.Size = new Size(157, 45);
            adminRadiobtn.TabIndex = 12;
            adminRadiobtn.TabStop = true;
            adminRadiobtn.Text = "Admin";
            adminRadiobtn.UseVisualStyleBackColor = true;
            adminRadiobtn.CheckedChanged += Radiobtn_CheckedChanged;
            // 
            // studentRadiobtn
            // 
            studentRadiobtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            studentRadiobtn.ForeColor = Color.White;
            studentRadiobtn.Location = new Point(603, 455);
            studentRadiobtn.Name = "studentRadiobtn";
            studentRadiobtn.Size = new Size(157, 45);
            studentRadiobtn.TabIndex = 13;
            studentRadiobtn.TabStop = true;
            studentRadiobtn.Text = "Student";
            studentRadiobtn.UseVisualStyleBackColor = true;
            studentRadiobtn.CheckedChanged += Radiobtn_CheckedChanged;
            // 
            // firstNameBox
            // 
            firstNameBox.Anchor = AnchorStyles.None;
            firstNameBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameBox.Location = new Point(389, 220);
            firstNameBox.Name = "firstNameBox";
            firstNameBox.Size = new Size(487, 51);
            firstNameBox.TabIndex = 15;
            // 
            // frstNamelb
            // 
            frstNamelb.Anchor = AnchorStyles.None;
            frstNamelb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            frstNamelb.ForeColor = Color.Aqua;
            frstNamelb.Location = new Point(158, 220);
            frstNamelb.Name = "frstNamelb";
            frstNamelb.Size = new Size(233, 51);
            frstNamelb.TabIndex = 14;
            frstNamelb.Text = "First Name :";
            // 
            // userNameBox
            // 
            userNameBox.Anchor = AnchorStyles.None;
            userNameBox.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            userNameBox.Location = new Point(389, 136);
            userNameBox.Name = "userNameBox";
            userNameBox.Size = new Size(487, 51);
            userNameBox.TabIndex = 17;
            // 
            // userNamelb
            // 
            userNamelb.Anchor = AnchorStyles.None;
            userNamelb.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userNamelb.ForeColor = Color.Aqua;
            userNamelb.Location = new Point(158, 142);
            userNamelb.Name = "userNamelb";
            userNamelb.Size = new Size(233, 51);
            userNamelb.TabIndex = 16;
            userNamelb.Text = "Username :";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1027, 720);
            Controls.Add(userNameBox);
            Controls.Add(userNamelb);
            Controls.Add(firstNameBox);
            Controls.Add(frstNamelb);
            Controls.Add(studentRadiobtn);
            Controls.Add(adminRadiobtn);
            Controls.Add(SIgninBtn);
            Controls.Add(passBox);
            Controls.Add(secondNameBox);
            Controls.Add(Passwordlb);
            Controls.Add(secondNamelb);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SIgninBtn;
        private TextBox passBox;
        private TextBox secondNameBox;
        private Label Passwordlb;
        private Label secondNamelb;
        private RadioButton adminRadiobtn;
        private RadioButton studentRadiobtn;
        private TextBox firstNameBox;
        private Label frstNamelb;
        private TextBox userNameBox;
        private Label userNamelb;
    }
}