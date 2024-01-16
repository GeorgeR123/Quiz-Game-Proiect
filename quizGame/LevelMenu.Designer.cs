namespace quizGame
{
    partial class LevelMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelMenu));
            this.CTButton1 = new System.Windows.Forms.Button();
            this.MButton1 = new System.Windows.Forms.Button();
            this.CTButton2 = new System.Windows.Forms.Button();
            this.CTButton3 = new System.Windows.Forms.Button();
            this.MButton2 = new System.Windows.Forms.Button();
            this.MButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CTButton1
            // 
            this.CTButton1.Location = new System.Drawing.Point(136, 112);
            this.CTButton1.Name = "CTButton1";
            this.CTButton1.Size = new System.Drawing.Size(90, 38);
            this.CTButton1.TabIndex = 0;
            this.CTButton1.Text = "NIVEL 1";
            this.CTButton1.UseVisualStyleBackColor = true;
            this.CTButton1.Click += new System.EventHandler(this.LoadCTButton1);
            // 
            // MButton1
            // 
            this.MButton1.Location = new System.Drawing.Point(136, 248);
            this.MButton1.Name = "MButton1";
            this.MButton1.Size = new System.Drawing.Size(90, 38);
            this.MButton1.TabIndex = 1;
            this.MButton1.Text = "NIVEL 1";
            this.MButton1.UseVisualStyleBackColor = true;
            this.MButton1.Click += new System.EventHandler(this.LoadMButton1);
            // 
            // CTButton2
            // 
            this.CTButton2.Location = new System.Drawing.Point(272, 112);
            this.CTButton2.Name = "CTButton2";
            this.CTButton2.Size = new System.Drawing.Size(90, 38);
            this.CTButton2.TabIndex = 2;
            this.CTButton2.Text = "NIVEL 2";
            this.CTButton2.UseVisualStyleBackColor = true;
            this.CTButton2.Click += new System.EventHandler(this.LoadCTButton2);
            // 
            // CTButton3
            // 
            this.CTButton3.Location = new System.Drawing.Point(408, 112);
            this.CTButton3.Name = "CTButton3";
            this.CTButton3.Size = new System.Drawing.Size(90, 38);
            this.CTButton3.TabIndex = 3;
            this.CTButton3.Text = "NIVEL 3";
            this.CTButton3.UseVisualStyleBackColor = true;
            this.CTButton3.Click += new System.EventHandler(this.LoadCTButton2);
            // 
            // MButton2
            // 
            this.MButton2.Location = new System.Drawing.Point(272, 248);
            this.MButton2.Name = "MButton2";
            this.MButton2.Size = new System.Drawing.Size(90, 38);
            this.MButton2.TabIndex = 6;
            this.MButton2.Text = "NIVEL 2";
            this.MButton2.UseVisualStyleBackColor = true;
            // 
            // MButton3
            // 
            this.MButton3.Location = new System.Drawing.Point(408, 248);
            this.MButton3.Name = "MButton3";
            this.MButton3.Size = new System.Drawing.Size(90, 38);
            this.MButton3.TabIndex = 7;
            this.MButton3.Text = "NIVEL 3";
            this.MButton3.UseVisualStyleBackColor = true;
            // 
            // LevelMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(797, 594);
            this.Controls.Add(this.MButton3);
            this.Controls.Add(this.MButton2);
            this.Controls.Add(this.CTButton3);
            this.Controls.Add(this.CTButton2);
            this.Controls.Add(this.MButton1);
            this.Controls.Add(this.CTButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LevelMenu";
            this.Text = "LevelMenu";
            this.Load += new System.EventHandler(this.LevelMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CTButton1;
        private System.Windows.Forms.Button MButton1;
        private System.Windows.Forms.Button CTButton2;
        private System.Windows.Forms.Button CTButton3;
        private System.Windows.Forms.Button MButton2;
        private System.Windows.Forms.Button MButton3;
    }
}