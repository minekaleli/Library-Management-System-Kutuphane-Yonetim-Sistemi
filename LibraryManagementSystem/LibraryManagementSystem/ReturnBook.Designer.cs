namespace LibraryManagementSystem
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStRefresh = new System.Windows.Forms.Button();
            this.btnStSearch = new System.Windows.Forms.Button();
            this.txtStNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.jFlatButton5 = new System.Windows.Forms.Button();
            this.btnbkreturn = new System.Windows.Forms.Button();
            this.txtBkIssueDate = new System.Windows.Forms.TextBox();
            this.txtBkName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnStRefresh);
            this.panel1.Controls.Add(this.btnStSearch);
            this.panel1.Controls.Add(this.txtStNumber);
            this.panel1.Location = new System.Drawing.Point(46, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 342);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(64, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 88);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnStRefresh
            // 
            this.btnStRefresh.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStRefresh.ForeColor = System.Drawing.Color.White;
            this.btnStRefresh.Location = new System.Drawing.Point(40, 237);
            this.btnStRefresh.Name = "btnStRefresh";
            this.btnStRefresh.Size = new System.Drawing.Size(141, 30);
            this.btnStRefresh.TabIndex = 2;
            this.btnStRefresh.Text = "Refresh";
            this.btnStRefresh.UseVisualStyleBackColor = false;
            this.btnStRefresh.Click += new System.EventHandler(this.btnStRefresh_Click);
            // 
            // btnStSearch
            // 
            this.btnStSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStSearch.ForeColor = System.Drawing.Color.White;
            this.btnStSearch.Location = new System.Drawing.Point(40, 189);
            this.btnStSearch.Name = "btnStSearch";
            this.btnStSearch.Size = new System.Drawing.Size(141, 30);
            this.btnStSearch.TabIndex = 1;
            this.btnStSearch.Text = "Search Student";
            this.btnStSearch.UseVisualStyleBackColor = false;
            this.btnStSearch.Click += new System.EventHandler(this.btnStSearch_Click);
            // 
            // txtStNumber
            // 
            this.txtStNumber.Location = new System.Drawing.Point(40, 142);
            this.txtStNumber.Multiline = true;
            this.txtStNumber.Name = "txtStNumber";
            this.txtStNumber.Size = new System.Drawing.Size(141, 23);
            this.txtStNumber.TabIndex = 0;
            this.txtStNumber.TextChanged += new System.EventHandler(this.txtStNumber_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.returnDate);
            this.panel2.Controls.Add(this.jFlatButton5);
            this.panel2.Controls.Add(this.btnbkreturn);
            this.panel2.Controls.Add(this.txtBkIssueDate);
            this.panel2.Controls.Add(this.txtBkName);
            this.panel2.Location = new System.Drawing.Point(295, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 166);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book Return Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Book Issue Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book Name";
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(163, 98);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(200, 20);
            this.returnDate.TabIndex = 5;
            // 
            // jFlatButton5
            // 
            this.jFlatButton5.BackColor = System.Drawing.Color.RoyalBlue;
            this.jFlatButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.jFlatButton5.ForeColor = System.Drawing.Color.White;
            this.jFlatButton5.Location = new System.Drawing.Point(416, 99);
            this.jFlatButton5.Name = "jFlatButton5";
            this.jFlatButton5.Size = new System.Drawing.Size(118, 30);
            this.jFlatButton5.TabIndex = 4;
            this.jFlatButton5.Text = "Cancel";
            this.jFlatButton5.UseVisualStyleBackColor = false;
            this.jFlatButton5.Click += new System.EventHandler(this.jFlatButton5_Click);
            // 
            // btnbkreturn
            // 
            this.btnbkreturn.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnbkreturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbkreturn.ForeColor = System.Drawing.Color.White;
            this.btnbkreturn.Location = new System.Drawing.Point(416, 61);
            this.btnbkreturn.Name = "btnbkreturn";
            this.btnbkreturn.Size = new System.Drawing.Size(118, 30);
            this.btnbkreturn.TabIndex = 3;
            this.btnbkreturn.Text = "Return";
            this.btnbkreturn.UseVisualStyleBackColor = false;
            this.btnbkreturn.Click += new System.EventHandler(this.btnbkreturn_Click);
            // 
            // txtBkIssueDate
            // 
            this.txtBkIssueDate.Location = new System.Drawing.Point(163, 61);
            this.txtBkIssueDate.Name = "txtBkIssueDate";
            this.txtBkIssueDate.Size = new System.Drawing.Size(200, 20);
            this.txtBkIssueDate.TabIndex = 2;
            // 
            // txtBkName
            // 
            this.txtBkName.Location = new System.Drawing.Point(163, 19);
            this.txtBkName.Name = "txtBkName";
            this.txtBkName.Size = new System.Drawing.Size(200, 20);
            this.txtBkName.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 165);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 38);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReturnBook";
            this.Text = "Return Book";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStRefresh;
        private System.Windows.Forms.Button btnStSearch;
        private System.Windows.Forms.TextBox txtStNumber;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.Button jFlatButton5;
        private System.Windows.Forms.Button btnbkreturn;
        private System.Windows.Forms.TextBox txtBkIssueDate;
        private System.Windows.Forms.TextBox txtBkName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}