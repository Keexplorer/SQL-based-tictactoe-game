namespace _152120201021_Abdulkerim_Pekince_lab5
{
    partial class GameDifficulty
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
            this.btn_easy = new System.Windows.Forms.Button();
            this.btn_medium = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_easy
            // 
            this.btn_easy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_easy.Location = new System.Drawing.Point(95, 168);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(147, 77);
            this.btn_easy.TabIndex = 0;
            this.btn_easy.Text = "Easy";
            this.btn_easy.UseVisualStyleBackColor = false;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            // 
            // btn_medium
            // 
            this.btn_medium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_medium.Location = new System.Drawing.Point(318, 168);
            this.btn_medium.Name = "btn_medium";
            this.btn_medium.Size = new System.Drawing.Size(147, 77);
            this.btn_medium.TabIndex = 1;
            this.btn_medium.Text = "Medium";
            this.btn_medium.UseVisualStyleBackColor = true;
            this.btn_medium.Click += new System.EventHandler(this.btn_medium_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hard.Location = new System.Drawing.Point(543, 168);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(147, 77);
            this.btn_hard.TabIndex = 2;
            this.btn_hard.Text = "Hard";
            this.btn_hard.UseVisualStyleBackColor = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            // 
            // GameDifficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_medium);
            this.Controls.Add(this.btn_easy);
            this.Name = "GameDifficulty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameDifficulty";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Button btn_medium;
        private System.Windows.Forms.Button btn_hard;
    }
}