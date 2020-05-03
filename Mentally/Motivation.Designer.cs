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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Motivation = new System.Windows.Forms.Button();
            this.btn_Motivation_Back = new System.Windows.Forms.Button();
            this.lb_Motivation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Motivation";
            // 
            // btn_Motivation
            // 
            this.btn_Motivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Motivation.Location = new System.Drawing.Point(240, 166);
            this.btn_Motivation.Name = "btn_Motivation";
            this.btn_Motivation.Size = new System.Drawing.Size(88, 43);
            this.btn_Motivation.TabIndex = 2;
            this.btn_Motivation.Text = "Random";
            this.btn_Motivation.UseVisualStyleBackColor = true;
            this.btn_Motivation.Click += new System.EventHandler(this.btn_Motivation_Click);
            // 
            // btn_Motivation_Back
            // 
            this.btn_Motivation_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Motivation_Back.Location = new System.Drawing.Point(240, 226);
            this.btn_Motivation_Back.Name = "btn_Motivation_Back";
            this.btn_Motivation_Back.Size = new System.Drawing.Size(88, 36);
            this.btn_Motivation_Back.TabIndex = 3;
            this.btn_Motivation_Back.Text = "Back";
            this.btn_Motivation_Back.UseVisualStyleBackColor = true;
            this.btn_Motivation_Back.Click += new System.EventHandler(this.btn_Motivation_Back_Click);
            // 
            // lb_Motivation
            // 
            this.lb_Motivation.AutoSize = true;
            this.lb_Motivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Motivation.Location = new System.Drawing.Point(15, 9);
            this.lb_Motivation.Name = "lb_Motivation";
            this.lb_Motivation.Size = new System.Drawing.Size(14, 20);
            this.lb_Motivation.TabIndex = 1;
            this.lb_Motivation.Text = "-";
            this.lb_Motivation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_Motivation);
            this.panel1.Location = new System.Drawing.Point(74, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 38);
            this.panel1.TabIndex = 4;
            // 
            // Motivation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Motivation_Back);
            this.Controls.Add(this.btn_Motivation);
            this.Controls.Add(this.label1);
            this.Name = "Motivation";
            this.Text = "Motivation";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Motivation;
        private System.Windows.Forms.Button btn_Motivation_Back;
        private System.Windows.Forms.Label lb_Motivation;
        private System.Windows.Forms.Panel panel1;
    }
}