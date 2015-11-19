namespace D2CLumiraPlugin
{
    partial class LoginDDC
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
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtBox_UserId = new System.Windows.Forms.TextBox();
            this.lbl_UserId = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(26, 98);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(240, 20);
            this.txt_Password.TabIndex = 10;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(23, 82);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "Password";
            // 
            // txtBox_UserId
            // 
            this.txtBox_UserId.Location = new System.Drawing.Point(26, 54);
            this.txtBox_UserId.Name = "txtBox_UserId";
            this.txtBox_UserId.Size = new System.Drawing.Size(240, 20);
            this.txtBox_UserId.TabIndex = 8;
            // 
            // lbl_UserId
            // 
            this.lbl_UserId.AutoSize = true;
            this.lbl_UserId.Location = new System.Drawing.Point(23, 37);
            this.lbl_UserId.Name = "lbl_UserId";
            this.lbl_UserId.Size = new System.Drawing.Size(38, 13);
            this.lbl_UserId.TabIndex = 7;
            this.lbl_UserId.Text = "UserId";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(105, 137);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(105, 204);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(75, 23);
            this.btn_Register.TabIndex = 12;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Don\'t have a DataDirect Cloud Account?";
            // 
            // LoginDDC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtBox_UserId);
            this.Controls.Add(this.lbl_UserId);
            this.Name = "LoginDDC";
            this.Text = "DataDirect Cloud Login";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txtBox_UserId;
        private System.Windows.Forms.Label lbl_UserId;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Label label1;
    }
}