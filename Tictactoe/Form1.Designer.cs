namespace _152120201021_Abdulkerim_Pekince_lab5
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.lbl_uyarı = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.chbox_remember = new System.Windows.Forms.CheckBox();
            this.chbox_showpass = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(496, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_username.Location = new System.Drawing.Point(370, 109);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(136, 27);
            this.txtbox_username.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(244, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: ";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbox_password.Location = new System.Drawing.Point(370, 151);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(136, 27);
            this.txtbox_password.TabIndex = 4;
            this.txtbox_password.UseSystemPasswordChar = true;
            // 
            // lbl_uyarı
            // 
            this.lbl_uyarı.AutoSize = true;
            this.lbl_uyarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_uyarı.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_uyarı.Location = new System.Drawing.Point(214, 357);
            this.lbl_uyarı.Name = "lbl_uyarı";
            this.lbl_uyarı.Size = new System.Drawing.Size(0, 22);
            this.lbl_uyarı.TabIndex = 5;
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Register.Location = new System.Drawing.Point(175, 277);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(136, 50);
            this.btn_Register.TabIndex = 6;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // chbox_remember
            // 
            this.chbox_remember.AutoSize = true;
            this.chbox_remember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbox_remember.Location = new System.Drawing.Point(355, 238);
            this.chbox_remember.Name = "chbox_remember";
            this.chbox_remember.Size = new System.Drawing.Size(141, 24);
            this.chbox_remember.TabIndex = 7;
            this.chbox_remember.Text = "Remember me";
            this.chbox_remember.UseVisualStyleBackColor = true;
            this.chbox_remember.CheckedChanged += new System.EventHandler(this.chbox_remember_CheckedChanged);
            // 
            // chbox_showpass
            // 
            this.chbox_showpass.AutoSize = true;
            this.chbox_showpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbox_showpass.Location = new System.Drawing.Point(355, 199);
            this.chbox_showpass.Name = "chbox_showpass";
            this.chbox_showpass.Size = new System.Drawing.Size(151, 24);
            this.chbox_showpass.TabIndex = 8;
            this.chbox_showpass.Text = "Show Password";
            this.chbox_showpass.UseVisualStyleBackColor = true;
            this.chbox_showpass.CheckedChanged += new System.EventHandler(this.chbox_showpass_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(381, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "If you want to operate with SQL, click SQL button:";
            // 
            // btn_SQL
            // 
            this.btn_SQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_SQL.Location = new System.Drawing.Point(515, 383);
            this.btn_SQL.Name = "btn_SQL";
            this.btn_SQL.Size = new System.Drawing.Size(136, 50);
            this.btn_SQL.TabIndex = 10;
            this.btn_SQL.Text = "SQL";
            this.btn_SQL.UseVisualStyleBackColor = true;
            this.btn_SQL.Click += new System.EventHandler(this.btn_SQL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SQL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbox_showpass);
            this.Controls.Add(this.chbox_remember);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.lbl_uyarı);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App-8";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Label lbl_uyarı;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.CheckBox chbox_remember;
        private System.Windows.Forms.CheckBox chbox_showpass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SQL;
    }
}

