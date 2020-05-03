namespace Mentally
{
    partial class Register
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
            this.lb_Register = new System.Windows.Forms.Label();
            this.btn_Register_Back = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.tb_Nama = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.lb_Nama = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Email = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Register
            // 
            this.lb_Register.AutoSize = true;
            this.lb_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Register.Location = new System.Drawing.Point(229, 27);
            this.lb_Register.Name = "lb_Register";
            this.lb_Register.Size = new System.Drawing.Size(104, 29);
            this.lb_Register.TabIndex = 23;
            this.lb_Register.Text = "Register";
            // 
            // btn_Register_Back
            // 
            this.btn_Register_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register_Back.Location = new System.Drawing.Point(345, 287);
            this.btn_Register_Back.Name = "btn_Register_Back";
            this.btn_Register_Back.Size = new System.Drawing.Size(88, 34);
            this.btn_Register_Back.TabIndex = 22;
            this.btn_Register_Back.Text = "Back";
            this.btn_Register_Back.UseVisualStyleBackColor = true;
            this.btn_Register_Back.Click += new System.EventHandler(this.btn_Register_Back_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(234, 286);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(96, 35);
            this.btn_Register.TabIndex = 21;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // tb_Nama
            // 
            this.tb_Nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nama.Location = new System.Drawing.Point(234, 216);
            this.tb_Nama.Name = "tb_Nama";
            this.tb_Nama.Size = new System.Drawing.Size(199, 26);
            this.tb_Nama.TabIndex = 20;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(234, 178);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(199, 26);
            this.tb_Username.TabIndex = 19;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(234, 142);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(199, 26);
            this.tb_Password.TabIndex = 18;
            this.tb_Password.UseSystemPasswordChar = true;
            // 
            // tb_Email
            // 
            this.tb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(234, 104);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(199, 26);
            this.tb_Email.TabIndex = 17;
            // 
            // lb_Nama
            // 
            this.lb_Nama.AutoSize = true;
            this.lb_Nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nama.Location = new System.Drawing.Point(151, 216);
            this.lb_Nama.Name = "lb_Nama";
            this.lb_Nama.Size = new System.Drawing.Size(59, 20);
            this.lb_Nama.TabIndex = 16;
            this.lb_Nama.Text = "Nama :";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(119, 178);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(91, 20);
            this.lb_Username.TabIndex = 15;
            this.lb_Username.Text = "Username :";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Password.Location = new System.Drawing.Point(124, 142);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(86, 20);
            this.lb_Password.TabIndex = 14;
            this.lb_Password.Text = "Password :";
            // 
            // lb_Email
            // 
            this.lb_Email.AutoSize = true;
            this.lb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Email.Location = new System.Drawing.Point(154, 104);
            this.lb_Email.Name = "lb_Email";
            this.lb_Email.Size = new System.Drawing.Size(56, 20);
            this.lb_Email.TabIndex = 13;
            this.lb_Email.Text = "Email :";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 364);
            this.Controls.Add(this.lb_Register);
            this.Controls.Add(this.btn_Register_Back);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.tb_Nama);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.lb_Nama);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Email);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Register;
        private System.Windows.Forms.Button btn_Register_Back;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.TextBox tb_Nama;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label lb_Nama;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Email;
    }
}