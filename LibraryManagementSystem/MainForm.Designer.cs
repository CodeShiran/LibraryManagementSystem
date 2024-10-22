namespace LibraryManagementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainlo_btn = new System.Windows.Forms.Button();
            this.returnbooks_btn = new System.Windows.Forms.Button();
            this.issuebooks_btn = new System.Windows.Forms.Button();
            this.addbooks_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnBooks1 = new LibraryManagementSystem.ReturnBooks();
            this.issueBooks1 = new LibraryManagementSystem.IssueBooks();
            this.addBooks1 = new LibraryManagementSystem.AddBooks();
            this.dashboard1 = new LibraryManagementSystem.Dashboard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 30);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(981, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Library Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.mainlo_btn);
            this.panel2.Controls.Add(this.returnbooks_btn);
            this.panel2.Controls.Add(this.issuebooks_btn);
            this.panel2.Controls.Add(this.addbooks_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 476);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Display", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Welcome Admin!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Log Out";
            // 
            // mainlo_btn
            // 
            this.mainlo_btn.FlatAppearance.BorderSize = 0;
            this.mainlo_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.mainlo_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.mainlo_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainlo_btn.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainlo_btn.ForeColor = System.Drawing.Color.White;
            this.mainlo_btn.Image = global::LibraryManagementSystem.Properties.Resources.logout__1_;
            this.mainlo_btn.Location = new System.Drawing.Point(14, 429);
            this.mainlo_btn.Name = "mainlo_btn";
            this.mainlo_btn.Size = new System.Drawing.Size(40, 40);
            this.mainlo_btn.TabIndex = 2;
            this.mainlo_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mainlo_btn.UseVisualStyleBackColor = true;
            this.mainlo_btn.Click += new System.EventHandler(this.mainlo_btn_Click);
            // 
            // returnbooks_btn
            // 
            this.returnbooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.returnbooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.returnbooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnbooks_btn.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbooks_btn.ForeColor = System.Drawing.Color.White;
            this.returnbooks_btn.Image = global::LibraryManagementSystem.Properties.Resources._return;
            this.returnbooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnbooks_btn.Location = new System.Drawing.Point(14, 339);
            this.returnbooks_btn.Name = "returnbooks_btn";
            this.returnbooks_btn.Size = new System.Drawing.Size(196, 56);
            this.returnbooks_btn.TabIndex = 2;
            this.returnbooks_btn.Text = "Return Books";
            this.returnbooks_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.returnbooks_btn.UseVisualStyleBackColor = true;
            this.returnbooks_btn.Click += new System.EventHandler(this.returnbooks_btn_Click);
            // 
            // issuebooks_btn
            // 
            this.issuebooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.issuebooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.issuebooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issuebooks_btn.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuebooks_btn.ForeColor = System.Drawing.Color.White;
            this.issuebooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.book_care;
            this.issuebooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.issuebooks_btn.Location = new System.Drawing.Point(14, 274);
            this.issuebooks_btn.Name = "issuebooks_btn";
            this.issuebooks_btn.Size = new System.Drawing.Size(196, 56);
            this.issuebooks_btn.TabIndex = 2;
            this.issuebooks_btn.Text = "Issue Books";
            this.issuebooks_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.issuebooks_btn.UseVisualStyleBackColor = true;
            this.issuebooks_btn.Click += new System.EventHandler(this.issuebooks_btn_Click);
            // 
            // addbooks_btn
            // 
            this.addbooks_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.addbooks_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.addbooks_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbooks_btn.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbooks_btn.ForeColor = System.Drawing.Color.White;
            this.addbooks_btn.Image = global::LibraryManagementSystem.Properties.Resources.add;
            this.addbooks_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addbooks_btn.Location = new System.Drawing.Point(14, 209);
            this.addbooks_btn.Name = "addbooks_btn";
            this.addbooks_btn.Size = new System.Drawing.Size(196, 56);
            this.addbooks_btn.TabIndex = 2;
            this.addbooks_btn.Text = "Add Books";
            this.addbooks_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbooks_btn.UseVisualStyleBackColor = true;
            this.addbooks_btn.Click += new System.EventHandler(this.addbooks_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(235)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(82)))), ((int)(((byte)(255)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("SF Pro Display", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.Image = global::LibraryManagementSystem.Properties.Resources.dashboard;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(14, 144);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(196, 56);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManagementSystem.Properties.Resources.administrator__2_;
            this.pictureBox1.Location = new System.Drawing.Point(64, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // returnBooks1
            // 
            this.returnBooks1.Location = new System.Drawing.Point(233, 29);
            this.returnBooks1.Name = "returnBooks1";
            this.returnBooks1.Size = new System.Drawing.Size(768, 476);
            this.returnBooks1.TabIndex = 2;
            // 
            // issueBooks1
            // 
            this.issueBooks1.Location = new System.Drawing.Point(233, 29);
            this.issueBooks1.Name = "issueBooks1";
            this.issueBooks1.Size = new System.Drawing.Size(768, 476);
            this.issueBooks1.TabIndex = 3;
            // 
            // addBooks1
            // 
            this.addBooks1.Location = new System.Drawing.Point(233, 29);
            this.addBooks1.Name = "addBooks1";
            this.addBooks1.Size = new System.Drawing.Size(768, 476);
            this.addBooks1.TabIndex = 4;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(233, 29);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(768, 476);
            this.dashboard1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 506);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.addBooks1);
            this.Controls.Add(this.issueBooks1);
            this.Controls.Add(this.returnBooks1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addbooks_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button returnbooks_btn;
        private System.Windows.Forms.Button issuebooks_btn;
        private System.Windows.Forms.Button mainlo_btn;
        private System.Windows.Forms.Label label4;
        private ReturnBooks returnBooks1;
        private IssueBooks issueBooks1;
        private AddBooks addBooks1;
        private Dashboard dashboard1;
    }
}