
namespace BusyBeezApplication
{
    partial class frmLogin
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
            lblBusyBeezFront = new Label();
            lblInvalid = new Label();
            txtUsername = new TextBox();
            txtPasscode = new TextBox();
            btnLogIn = new Button();
            lnkForgotPassword = new LinkLabel();
            lnkSignUp = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblBusyBeezFront
            // 
            lblBusyBeezFront.AutoSize = true;
            lblBusyBeezFront.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBusyBeezFront.Location = new Point(128, 175);
            lblBusyBeezFront.Name = "lblBusyBeezFront";
            lblBusyBeezFront.Size = new Size(133, 23);
            lblBusyBeezFront.TabIndex = 3;
            lblBusyBeezFront.Text = "BusyBeez Portal";
            // 
            // lblInvalid
            // 
            lblInvalid.AutoSize = true;
            lblInvalid.Location = new Point(157, 276);
            lblInvalid.Name = "lblInvalid";
            lblInvalid.Size = new Size(79, 15);
            lblInvalid.TabIndex = 4;
            lblInvalid.Text = "User is invalid";
            lblInvalid.Visible = false;
            lblInvalid.Click += lblInvalid_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(77, 216);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(238, 23);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPasscode
            // 
            txtPasscode.Location = new Point(77, 243);
            txtPasscode.Margin = new Padding(3, 2, 3, 2);
            txtPasscode.Name = "txtPasscode";
            txtPasscode.PasswordChar = 'X';
            txtPasscode.PlaceholderText = "Passcode";
            txtPasscode.Size = new Size(238, 23);
            txtPasscode.TabIndex = 2;
            txtPasscode.KeyPress += txtPasscode_KeyPress;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(88, 303);
            btnLogIn.Margin = new Padding(3, 2, 3, 2);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(215, 28);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log in";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Location = new Point(145, 345);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(100, 15);
            lnkForgotPassword.TabIndex = 4;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.LinkClicked += lnkForgotPassword_LinkClicked;
            // 
            // lnkSignUp
            // 
            lnkSignUp.AutoSize = true;
            lnkSignUp.Location = new Point(169, 360);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(47, 15);
            lnkSignUp.TabIndex = 4;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Sign up";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 161);
            label1.Name = "label1";
            label1.Size = new Size(72, 14);
            label1.TabIndex = 5;
            label1.Text = "Welcome to";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(396, 576);
            Controls.Add(label1);
            Controls.Add(lnkSignUp);
            Controls.Add(lnkForgotPassword);
            Controls.Add(btnLogIn);
            Controls.Add(txtPasscode);
            Controls.Add(txtUsername);
            Controls.Add(lblInvalid);
            Controls.Add(lblBusyBeezFront);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        private void NewMethod()
        {
            lnkSignUp.LinkClicked += this.lnkSignUp_LinkClicked;
        }

        private void lnkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Label lblBusyBeezFront;
        private Label lblInvalid;
        private TextBox txtUsername;
        private TextBox txtPasscode;
        private Button btnLogIn;
        private LinkLabel lnkForgotPassword;
        private LinkLabel lnkSignUp;
        private Label label1;

        public LinkLabelLinkClickedEventHandler lnkSignUp_LinkClicked { get; private set; }
    }
}