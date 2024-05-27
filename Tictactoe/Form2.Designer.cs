namespace _152120201021_Abdulkerim_Pekince_lab5
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
            this.btn_difficult = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_newgame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_difficult
            // 
            this.btn_difficult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_difficult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_difficult.Location = new System.Drawing.Point(85, 170);
            this.btn_difficult.Name = "btn_difficult";
            this.btn_difficult.Size = new System.Drawing.Size(161, 70);
            this.btn_difficult.TabIndex = 0;
            this.btn_difficult.Text = "Difficulty Level";
            this.btn_difficult.UseVisualStyleBackColor = false;
            this.btn_difficult.Click += new System.EventHandler(this.btn_difficult_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_admin.Location = new System.Drawing.Point(315, 170);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(161, 70);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "Admin Panel";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_newgame
            // 
            this.btn_newgame.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_newgame.Location = new System.Drawing.Point(541, 170);
            this.btn_newgame.Name = "btn_newgame";
            this.btn_newgame.Size = new System.Drawing.Size(161, 70);
            this.btn_newgame.TabIndex = 2;
            this.btn_newgame.Text = "New Game";
            this.btn_newgame.UseVisualStyleBackColor = false;
            this.btn_newgame.Click += new System.EventHandler(this.btn_newgame_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_newgame);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_difficult);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App-8";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_difficult;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_newgame;
    }
}