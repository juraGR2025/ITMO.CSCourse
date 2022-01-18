namespace Lab_5_2
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
            this.GreenpeaceRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreenpeaceRun
            // 
            this.GreenpeaceRun.AutoSize = true;
            this.GreenpeaceRun.Location = new System.Drawing.Point(200, 100);
            this.GreenpeaceRun.Name = "GreenpeaceRun";
            this.GreenpeaceRun.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GreenpeaceRun.Size = new System.Drawing.Size(102, 23);
            this.GreenpeaceRun.TabIndex = 0;
            this.GreenpeaceRun.Text = "showtheRhombus";
            this.GreenpeaceRun.UseVisualStyleBackColor = true;
            this.GreenpeaceRun.Click += new System.EventHandler(this.GreenpeaceRun_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GreenpeaceRun);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GreenpeaceRun;
    }
}