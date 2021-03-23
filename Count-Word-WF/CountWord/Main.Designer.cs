namespace CountWord
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btnopen = new System.Windows.Forms.Button();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btncount = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.RichTextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnin = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgvresult = new System.Windows.Forms.DataGridView();
            this.Word = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input : ";
            // 
            // btnopen
            // 
            this.btnopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopen.Location = new System.Drawing.Point(437, 26);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(45, 34);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "...";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // txtinput
            // 
            this.txtinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinput.Location = new System.Drawing.Point(87, 20);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(319, 26);
            this.txtinput.TabIndex = 2;
            // 
            // btncount
            // 
            this.btncount.Enabled = false;
            this.btncount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncount.Location = new System.Drawing.Point(190, 96);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(102, 38);
            this.btncount.TabIndex = 3;
            this.btncount.Text = "Count";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresult.Location = new System.Drawing.Point(17, 151);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(465, 413);
            this.txtresult.TabIndex = 4;
            this.txtresult.Text = "";
            // 
            // btnsave
            // 
            this.btnsave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsave.Enabled = false;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(429, 92);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(53, 42);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnin
            // 
            this.btnin.Enabled = false;
            this.btnin.Location = new System.Drawing.Point(12, 125);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(38, 20);
            this.btnin.TabIndex = 6;
            this.btnin.Text = "IN";
            this.btnin.UseVisualStyleBackColor = true;
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // btnout
            // 
            this.btnout.Enabled = false;
            this.btnout.Location = new System.Drawing.Point(56, 125);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(38, 20);
            this.btnout.TabIndex = 6;
            this.btnout.Text = "OUT";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Code By Truong Minh Phuoc DUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount :";
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(87, 59);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(319, 26);
            this.txtamount.TabIndex = 2;
            this.txtamount.Text = "100";
            this.txtamount.TextChanged += new System.EventHandler(this.textamount_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CountWord.Properties.Resources.Logo_dhbkdn;
            this.pictureBox1.Location = new System.Drawing.Point(357, 571);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CountWord.Properties.Resources.tải_xuống;
            this.pictureBox2.Location = new System.Drawing.Point(87, 571);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // dgvresult
            // 
            this.dgvresult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvresult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvresult.ColumnHeadersHeight = 30;
            this.dgvresult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Word,
            this.Count});
            this.dgvresult.GridColor = System.Drawing.SystemColors.Control;
            this.dgvresult.Location = new System.Drawing.Point(75, 157);
            this.dgvresult.Name = "dgvresult";
            this.dgvresult.ReadOnly = true;
            this.dgvresult.RowHeadersVisible = false;
            this.dgvresult.RowHeadersWidth = 15;
            this.dgvresult.Size = new System.Drawing.Size(349, 414);
            this.dgvresult.TabIndex = 10;
            // 
            // Word
            // 
            this.Word.HeaderText = "                       WORD";
            this.Word.Name = "Word";
            this.Word.ReadOnly = true;
            this.Word.Width = 190;
            // 
            // Count
            // 
            this.Count.HeaderText = "             COUNT";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 140;
            // 
            // Main
            // 
            this.AcceptButton = this.btncount;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnsave;
            this.ClientSize = new System.Drawing.Size(504, 601);
            this.Controls.Add(this.dgvresult);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Word Count";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.RichTextBox txtresult;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnin;
        private System.Windows.Forms.Button btnout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvresult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Word;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}

