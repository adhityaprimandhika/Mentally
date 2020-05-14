namespace Mentally
{
    partial class ShowHistory
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
            this.btn_Back_History = new System.Windows.Forms.Button();
            this.btn_showHistory = new System.Windows.Forms.Button();
            this.dtgView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back_History
            // 
            this.btn_Back_History.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back_History.AutoSize = true;
            this.btn_Back_History.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back_History.Location = new System.Drawing.Point(472, 424);
            this.btn_Back_History.Name = "btn_Back_History";
            this.btn_Back_History.Size = new System.Drawing.Size(85, 34);
            this.btn_Back_History.TabIndex = 5;
            this.btn_Back_History.Text = "Back";
            this.btn_Back_History.UseVisualStyleBackColor = true;
            this.btn_Back_History.Click += new System.EventHandler(this.btn_Back_History_Click);
            // 
            // btn_showHistory
            // 
            this.btn_showHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_showHistory.AutoSize = true;
            this.btn_showHistory.Font = new System.Drawing.Font("Playfair Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_showHistory.Location = new System.Drawing.Point(472, 370);
            this.btn_showHistory.Name = "btn_showHistory";
            this.btn_showHistory.Size = new System.Drawing.Size(85, 34);
            this.btn_showHistory.TabIndex = 4;
            this.btn_showHistory.Text = "History";
            this.btn_showHistory.UseVisualStyleBackColor = true;
            this.btn_showHistory.Click += new System.EventHandler(this.btn_showHistory_Click);
            // 
            // dtgView
            // 
            this.dtgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Location = new System.Drawing.Point(82, 128);
            this.dtgView.Name = "dtgView";
            this.dtgView.Size = new System.Drawing.Size(841, 236);
            this.dtgView.TabIndex = 3;
            // 
            // ShowHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mentally.Properties.Resources.History;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 515);
            this.Controls.Add(this.btn_Back_History);
            this.Controls.Add(this.btn_showHistory);
            this.Controls.Add(this.dtgView);
            this.DoubleBuffered = true;
            this.Name = "ShowHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back_History;
        private System.Windows.Forms.Button btn_showHistory;
        private System.Windows.Forms.DataGridView dtgView;
    }
}