namespace Mentally
{
    partial class Menu
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
            this.btn_Menu_Check = new System.Windows.Forms.Button();
            this.btn_Menu_History = new System.Windows.Forms.Button();
            this.btn_Menu_Motivation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Menu_Check
            // 
            this.btn_Menu_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Menu_Check.AutoSize = true;
            this.btn_Menu_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu_Check.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu_Check.Location = new System.Drawing.Point(454, 184);
            this.btn_Menu_Check.Name = "btn_Menu_Check";
            this.btn_Menu_Check.Size = new System.Drawing.Size(127, 42);
            this.btn_Menu_Check.TabIndex = 0;
            this.btn_Menu_Check.Text = "Check Up";
            this.btn_Menu_Check.UseVisualStyleBackColor = true;
            this.btn_Menu_Check.Click += new System.EventHandler(this.btn_Menu_Check_Click);
            // 
            // btn_Menu_History
            // 
            this.btn_Menu_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Menu_History.AutoSize = true;
            this.btn_Menu_History.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu_History.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu_History.Location = new System.Drawing.Point(454, 280);
            this.btn_Menu_History.Name = "btn_Menu_History";
            this.btn_Menu_History.Size = new System.Drawing.Size(127, 42);
            this.btn_Menu_History.TabIndex = 1;
            this.btn_Menu_History.Text = "History";
            this.btn_Menu_History.UseVisualStyleBackColor = true;
            this.btn_Menu_History.Click += new System.EventHandler(this.btn_Menu_History_Click);
            // 
            // btn_Menu_Motivation
            // 
            this.btn_Menu_Motivation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Menu_Motivation.AutoSize = true;
            this.btn_Menu_Motivation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu_Motivation.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu_Motivation.Location = new System.Drawing.Point(454, 378);
            this.btn_Menu_Motivation.Name = "btn_Menu_Motivation";
            this.btn_Menu_Motivation.Size = new System.Drawing.Size(127, 42);
            this.btn_Menu_Motivation.TabIndex = 2;
            this.btn_Menu_Motivation.Text = "Motivation";
            this.btn_Menu_Motivation.UseVisualStyleBackColor = true;
            this.btn_Menu_Motivation.Click += new System.EventHandler(this.btn_Menu_Motivation_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mentally.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 515);
            this.Controls.Add(this.btn_Menu_Motivation);
            this.Controls.Add(this.btn_Menu_History);
            this.Controls.Add(this.btn_Menu_Check);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Menu_Check;
        private System.Windows.Forms.Button btn_Menu_History;
        private System.Windows.Forms.Button btn_Menu_Motivation;
    }
}