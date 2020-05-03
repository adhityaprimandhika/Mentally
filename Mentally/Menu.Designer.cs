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
            this.lb_Mentally = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Menu_Check
            // 
            this.btn_Menu_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu_Check.Location = new System.Drawing.Point(243, 131);
            this.btn_Menu_Check.Name = "btn_Menu_Check";
            this.btn_Menu_Check.Size = new System.Drawing.Size(100, 40);
            this.btn_Menu_Check.TabIndex = 0;
            this.btn_Menu_Check.Text = "CheckUp";
            this.btn_Menu_Check.UseVisualStyleBackColor = true;
            this.btn_Menu_Check.Click += new System.EventHandler(this.btn_Menu_Check_Click);
            // 
            // btn_Menu_History
            // 
            this.btn_Menu_History.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu_History.Location = new System.Drawing.Point(243, 187);
            this.btn_Menu_History.Name = "btn_Menu_History";
            this.btn_Menu_History.Size = new System.Drawing.Size(100, 40);
            this.btn_Menu_History.TabIndex = 1;
            this.btn_Menu_History.Text = "History";
            this.btn_Menu_History.UseVisualStyleBackColor = true;
            this.btn_Menu_History.Click += new System.EventHandler(this.btn_Menu_History_Click);
            // 
            // btn_Menu_Motivation
            // 
            this.btn_Menu_Motivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu_Motivation.Location = new System.Drawing.Point(243, 244);
            this.btn_Menu_Motivation.Name = "btn_Menu_Motivation";
            this.btn_Menu_Motivation.Size = new System.Drawing.Size(100, 40);
            this.btn_Menu_Motivation.TabIndex = 2;
            this.btn_Menu_Motivation.Text = "Motivation";
            this.btn_Menu_Motivation.UseVisualStyleBackColor = true;
            this.btn_Menu_Motivation.Click += new System.EventHandler(this.btn_Menu_Motivation_Click);
            // 
            // lb_Mentally
            // 
            this.lb_Mentally.AutoSize = true;
            this.lb_Mentally.Font = new System.Drawing.Font("Playfair Display", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Mentally.Location = new System.Drawing.Point(237, 35);
            this.lb_Mentally.Name = "lb_Mentally";
            this.lb_Mentally.Size = new System.Drawing.Size(109, 35);
            this.lb_Mentally.TabIndex = 3;
            this.lb_Mentally.Text = "Mentally";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 337);
            this.Controls.Add(this.lb_Mentally);
            this.Controls.Add(this.btn_Menu_Motivation);
            this.Controls.Add(this.btn_Menu_History);
            this.Controls.Add(this.btn_Menu_Check);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Menu_Check;
        private System.Windows.Forms.Button btn_Menu_History;
        private System.Windows.Forms.Button btn_Menu_Motivation;
        private System.Windows.Forms.Label lb_Mentally;
    }
}