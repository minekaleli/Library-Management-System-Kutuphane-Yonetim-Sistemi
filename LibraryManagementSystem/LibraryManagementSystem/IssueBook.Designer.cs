namespace LibraryManagementSystem
{
    partial class IssueBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStRefresh = new System.Windows.Forms.Button();
            this.btnSearchSt = new System.Windows.Forms.Button();
            this.txtStNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIssueBk = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxBK = new System.Windows.Forms.ComboBox();
            this.txtStEmail = new System.Windows.Forms.TextBox();
            this.txtStContact = new System.Windows.Forms.TextBox();
            this.txtStSemester = new System.Windows.Forms.TextBox();
            this.txtStDepartment = new System.Windows.Forms.TextBox();
            this.txtStName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnStRefresh);
            this.panel1.Controls.Add(this.btnSearchSt);
            this.panel1.Controls.Add(this.txtStNumber);
            this.panel1.Location = new System.Drawing.Point(46, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 353);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(51, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 94);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnStRefresh
            // 
            this.btnStRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStRefresh.Location = new System.Drawing.Point(38, 245);
            this.btnStRefresh.Name = "btnStRefresh";
            this.btnStRefresh.Size = new System.Drawing.Size(129, 29);
            this.btnStRefresh.TabIndex = 2;
            this.btnStRefresh.Text = "Refresh";
            this.btnStRefresh.UseVisualStyleBackColor = false;
            this.btnStRefresh.Click += new System.EventHandler(this.btnStRefresh_Click);
            // 
            // btnSearchSt
            // 
            this.btnSearchSt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearchSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchSt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchSt.Location = new System.Drawing.Point(38, 193);
            this.btnSearchSt.Name = "btnSearchSt";
            this.btnSearchSt.Size = new System.Drawing.Size(129, 29);
            this.btnSearchSt.TabIndex = 1;
            this.btnSearchSt.Text = "Search Student";
            this.btnSearchSt.UseVisualStyleBackColor = false;
            this.btnSearchSt.Click += new System.EventHandler(this.btnSearchSt_Click);
            // 
            // txtStNumber
            // 
            this.txtStNumber.Location = new System.Drawing.Point(38, 144);
            this.txtStNumber.Multiline = true;
            this.txtStNumber.Name = "txtStNumber";
            this.txtStNumber.Size = new System.Drawing.Size(129, 27);
            this.txtStNumber.TabIndex = 1;
            this.txtStNumber.TextChanged += new System.EventHandler(this.txtStNumber_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnIssueBk);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Controls.Add(this.comboBoxBK);
            this.panel2.Controls.Add(this.txtStEmail);
            this.panel2.Controls.Add(this.txtStContact);
            this.panel2.Controls.Add(this.txtStSemester);
            this.panel2.Controls.Add(this.txtStDepartment);
            this.panel2.Controls.Add(this.txtStName);
            this.panel2.Location = new System.Drawing.Point(288, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(423, 353);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(47, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Book Issue Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(47, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(50, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Student Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(47, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(47, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Student Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SF Pro Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student Number";
            // 
            // btnIssueBk
            // 
            this.btnIssueBk.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIssueBk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIssueBk.ForeColor = System.Drawing.SystemColors.Control;
            this.btnIssueBk.Location = new System.Drawing.Point(175, 290);
            this.btnIssueBk.Name = "btnIssueBk";
            this.btnIssueBk.Size = new System.Drawing.Size(172, 36);
            this.btnIssueBk.TabIndex = 7;
            this.btnIssueBk.Text = "Issue Book";
            this.btnIssueBk.UseVisualStyleBackColor = false;
            this.btnIssueBk.Click += new System.EventHandler(this.btnIssueBk_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(175, 254);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // comboBoxBK
            // 
            this.comboBoxBK.FormattingEnabled = true;
            this.comboBoxBK.Location = new System.Drawing.Point(175, 220);
            this.comboBoxBK.Name = "comboBoxBK";
            this.comboBoxBK.Size = new System.Drawing.Size(172, 21);
            this.comboBoxBK.TabIndex = 5;
            // 
            // txtStEmail
            // 
            this.txtStEmail.Location = new System.Drawing.Point(175, 183);
            this.txtStEmail.Name = "txtStEmail";
            this.txtStEmail.Size = new System.Drawing.Size(172, 20);
            this.txtStEmail.TabIndex = 4;
            // 
            // txtStContact
            // 
            this.txtStContact.Location = new System.Drawing.Point(175, 144);
            this.txtStContact.Name = "txtStContact";
            this.txtStContact.Size = new System.Drawing.Size(172, 20);
            this.txtStContact.TabIndex = 3;
            // 
            // txtStSemester
            // 
            this.txtStSemester.Location = new System.Drawing.Point(175, 106);
            this.txtStSemester.Name = "txtStSemester";
            this.txtStSemester.Size = new System.Drawing.Size(172, 20);
            this.txtStSemester.TabIndex = 2;
            // 
            // txtStDepartment
            // 
            this.txtStDepartment.Location = new System.Drawing.Point(175, 67);
            this.txtStDepartment.Name = "txtStDepartment";
            this.txtStDepartment.Size = new System.Drawing.Size(172, 20);
            this.txtStDepartment.TabIndex = 1;
            // 
            // txtStName
            // 
            this.txtStName.Location = new System.Drawing.Point(175, 30);
            this.txtStName.Name = "txtStName";
            this.txtStName.Size = new System.Drawing.Size(172, 20);
            this.txtStName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 41);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssueBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IssueBook";
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.IssueBook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStRefresh;
        private System.Windows.Forms.Button btnSearchSt;
        private System.Windows.Forms.TextBox txtStNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIssueBk;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxBK;
        private System.Windows.Forms.TextBox txtStEmail;
        private System.Windows.Forms.TextBox txtStContact;
        private System.Windows.Forms.TextBox txtStSemester;
        private System.Windows.Forms.TextBox txtStDepartment;
        private System.Windows.Forms.TextBox txtStName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}