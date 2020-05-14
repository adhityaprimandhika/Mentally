namespace Mentally
{
    partial class Result
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
            this.btn_HasilSolusi = new System.Windows.Forms.Button();
            this.lb_HasilGangguan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_HasilSolusi
            // 
            this.btn_HasilSolusi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_HasilSolusi.AutoSize = true;
            this.btn_HasilSolusi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HasilSolusi.Location = new System.Drawing.Point(482, 382);
            this.btn_HasilSolusi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_HasilSolusi.Name = "btn_HasilSolusi";
            this.btn_HasilSolusi.Size = new System.Drawing.Size(81, 37);
            this.btn_HasilSolusi.TabIndex = 9;
            this.btn_HasilSolusi.Text = "Solusi";
            this.btn_HasilSolusi.UseVisualStyleBackColor = true;
            this.btn_HasilSolusi.Click += new System.EventHandler(this.btn_HasilSolusi_Click);
            // 
            // lb_HasilGangguan
            // 
            this.lb_HasilGangguan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HasilGangguan.AutoSize = true;
            this.lb_HasilGangguan.BackColor = System.Drawing.Color.Transparent;
            this.lb_HasilGangguan.Font = new System.Drawing.Font("Playfair Display", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HasilGangguan.Location = new System.Drawing.Point(494, 204);
            this.lb_HasilGangguan.Name = "lb_HasilGangguan";
            this.lb_HasilGangguan.Size = new System.Drawing.Size(23, 30);
            this.lb_HasilGangguan.TabIndex = 8;
            this.lb_HasilGangguan.Text = "-";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mentally.Properties.Resources.Result;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 515);
            this.Controls.Add(this.btn_HasilSolusi);
            this.Controls.Add(this.lb_HasilGangguan);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Playfair Display", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_HasilSolusi;
        private System.Windows.Forms.Label lb_HasilGangguan;
    }
}