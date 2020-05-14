namespace Mentally
{
    partial class Motivation
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
            this.btn_Motivation = new System.Windows.Forms.Button();
            this.btn_Motivation_Back = new System.Windows.Forms.Button();
            this.lb_Motivation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Motivation
            // 
            this.btn_Motivation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Motivation.AutoSize = true;
            this.btn_Motivation.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Motivation.Location = new System.Drawing.Point(458, 311);
            this.btn_Motivation.Name = "btn_Motivation";
            this.btn_Motivation.Size = new System.Drawing.Size(103, 43);
            this.btn_Motivation.TabIndex = 2;
            this.btn_Motivation.Text = "Random";
            this.btn_Motivation.UseVisualStyleBackColor = true;
            this.btn_Motivation.Click += new System.EventHandler(this.btn_Motivation_Click);
            // 
            // btn_Motivation_Back
            // 
            this.btn_Motivation_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Motivation_Back.AutoSize = true;
            this.btn_Motivation_Back.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Motivation_Back.Location = new System.Drawing.Point(458, 409);
            this.btn_Motivation_Back.Name = "btn_Motivation_Back";
            this.btn_Motivation_Back.Size = new System.Drawing.Size(102, 40);
            this.btn_Motivation_Back.TabIndex = 3;
            this.btn_Motivation_Back.Text = "Back";
            this.btn_Motivation_Back.UseVisualStyleBackColor = true;
            this.btn_Motivation_Back.Click += new System.EventHandler(this.btn_Motivation_Back_Click);
            // 
            // lb_Motivation
            // 
            this.lb_Motivation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Motivation.AutoSize = true;
            this.lb_Motivation.BackColor = System.Drawing.Color.Transparent;
            this.lb_Motivation.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Motivation.Location = new System.Drawing.Point(150, 172);
            this.lb_Motivation.Name = "lb_Motivation";
            this.lb_Motivation.Size = new System.Drawing.Size(23, 30);
            this.lb_Motivation.TabIndex = 1;
            this.lb_Motivation.Text = "-";
            this.lb_Motivation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Motivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mentally.Properties.Resources.Motivasi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 515);
            this.Controls.Add(this.lb_Motivation);
            this.Controls.Add(this.btn_Motivation_Back);
            this.Controls.Add(this.btn_Motivation);
            this.Name = "Motivation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Motivation;
        private System.Windows.Forms.Button btn_Motivation_Back;
        private System.Windows.Forms.Label lb_Motivation;
    }
}