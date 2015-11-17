namespace EloquaDataAccessPlugin
{
    partial class Form1
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
            this.cbTableSelect = new System.Windows.Forms.ComboBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.lbl_entity = new System.Windows.Forms.Label();
            this.lbl_connect = new System.Windows.Forms.Label();
            this.lblDSNName = new System.Windows.Forms.Label();
            this.txt_DSNName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_DDCDSN = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbTableSelect
            // 
            this.cbTableSelect.FormattingEnabled = true;
            this.cbTableSelect.Location = new System.Drawing.Point(33, 191);
            this.cbTableSelect.Name = "cbTableSelect";
            this.cbTableSelect.Size = new System.Drawing.Size(243, 21);
            this.cbTableSelect.TabIndex = 12;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(36, 218);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(198, 218);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(104, 126);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 10;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // lbl_entity
            // 
            this.lbl_entity.AutoSize = true;
            this.lbl_entity.Location = new System.Drawing.Point(30, 175);
            this.lbl_entity.Name = "lbl_entity";
            this.lbl_entity.Size = new System.Drawing.Size(69, 13);
            this.lbl_entity.TabIndex = 8;
            this.lbl_entity.Text = "Select Entity ";
            // 
            // lbl_connect
            // 
            this.lbl_connect.AutoSize = true;
            this.lbl_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_connect.Location = new System.Drawing.Point(101, 152);
            this.lbl_connect.Name = "lbl_connect";
            this.lbl_connect.Size = new System.Drawing.Size(83, 13);
            this.lbl_connect.TabIndex = 9;
            this.lbl_connect.Text = "Connecting...";
            // 
            // lblDSNName
            // 
            this.lblDSNName.AutoSize = true;
            this.lblDSNName.Location = new System.Drawing.Point(30, 22);
            this.lblDSNName.Name = "lblDSNName";
            this.lblDSNName.Size = new System.Drawing.Size(61, 13);
            this.lblDSNName.TabIndex = 10;
            this.lblDSNName.Text = "DSN Name";
            // 
            // txt_DSNName
            // 
            this.txt_DSNName.Location = new System.Drawing.Point(33, 38);
            this.txt_DSNName.Name = "txt_DSNName";
            this.txt_DSNName.Size = new System.Drawing.Size(240, 20);
            this.txt_DSNName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "DDC Data Source Name";
            // 
            // cb_DDCDSN
            // 
            this.cb_DDCDSN.FormattingEnabled = true;
            this.cb_DDCDSN.Location = new System.Drawing.Point(36, 89);
            this.cb_DDCDSN.Name = "cb_DDCDSN";
            this.cb_DDCDSN.Size = new System.Drawing.Size(237, 21);
            this.cb_DDCDSN.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 262);
            this.Controls.Add(this.cb_DDCDSN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DSNName);
            this.Controls.Add(this.lblDSNName);
            this.Controls.Add(this.lbl_connect);
            this.Controls.Add(this.lbl_entity);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.cbTableSelect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configure Connection";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTableSelect;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_entity;
        private System.Windows.Forms.Label lbl_connect;
        private System.Windows.Forms.Label lblDSNName;
        private System.Windows.Forms.TextBox txt_DSNName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_DDCDSN;
    }
}

