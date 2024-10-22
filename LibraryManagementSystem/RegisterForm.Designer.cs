namespace LibraryManagementSystem
{
    partial class RegisterForm
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
            this.registersp_cb = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.signin_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.registerpass_txt = new System.Windows.Forms.TextBox();
            this.registeremail_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registername_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registersp_cb
            // 
            this.registersp_cb.AutoSize = true;
            this.registersp_cb.Font = new System.Drawing.Font("SF Pro Display", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registersp_cb.Location = new System.Drawing.Point(313, 469);
            this.registersp_cb.Name = "registersp_cb";
            this.registersp_cb.Size = new System.Drawing.Size(116, 20);
            this.registersp_cb.TabIndex = 19;
            this.registersp_cb.Text = "Show Password";
            this.registersp_cb.UseVisualStyleBackColor = true;
            this.registersp_cb.CheckedChanged += new System.EventHandler(this.registersp_cb_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Register Account";
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.signin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signin_btn.FlatAppearance.BorderSize = 0;
            this.signin_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.signin_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.signin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin_btn.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin_btn.ForeColor = System.Drawing.Color.White;
            this.signin_btn.Location = new System.Drawing.Point(149, 575);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(107, 37);
            this.signin_btn.TabIndex = 16;
            this.signin_btn.Text = "Sign In";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(135, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 50);
            this.button1.TabIndex = 17;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerpass_txt
            // 
            this.registerpass_txt.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerpass_txt.Location = new System.Drawing.Point(17, 438);
            this.registerpass_txt.Multiline = true;
            this.registerpass_txt.Name = "registerpass_txt";
            this.registerpass_txt.PasswordChar = '*';
            this.registerpass_txt.Size = new System.Drawing.Size(412, 25);
            this.registerpass_txt.TabIndex = 14;
            this.registerpass_txt.TextChanged += new System.EventHandler(this.registerpass_txt_TextChanged);
            // 
            // registeremail_txt
            // 
            this.registeremail_txt.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeremail_txt.Location = new System.Drawing.Point(17, 328);
            this.registeremail_txt.Multiline = true;
            this.registeremail_txt.Name = "registeremail_txt";
            this.registeremail_txt.Size = new System.Drawing.Size(412, 25);
            this.registeremail_txt.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Registration Form";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 30);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(417, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "User Name";
            // 
            // registername_txt
            // 
            this.registername_txt.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registername_txt.Location = new System.Drawing.Point(17, 383);
            this.registername_txt.Multiline = true;
            this.registername_txt.Name = "registername_txt";
            this.registername_txt.Size = new System.Drawing.Size(412, 25);
            this.registername_txt.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(89, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 625);
            this.Controls.Add(this.registersp_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registerpass_txt);
            this.Controls.Add(this.registername_txt);
            this.Controls.Add(this.registeremail_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox registersp_cb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox registerpass_txt;
        private System.Windows.Forms.TextBox registeremail_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox registername_txt;
    }
}