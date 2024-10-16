namespace LibSystem
{
    partial class Book_Fine
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
            this.components = new System.ComponentModel.Container();
            this.lblFine_Id = new System.Windows.Forms.Label();
            this.lblBookIssue_id = new System.Windows.Forms.Label();
            this.lblBRetid = new System.Windows.Forms.Label();
            this.lblRNo = new System.Windows.Forms.Label();
            this.lbltotaldays = new System.Windows.Forms.Label();
            this.lblfineamount = new System.Windows.Forms.Label();
            this.pnlfield = new System.Windows.Forms.Panel();
            this.txtR_No = new System.Windows.Forms.TextBox();
            this.lblsfid = new System.Windows.Forms.Label();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.txtfineamount = new System.Windows.Forms.TextBox();
            this.txttotalday = new System.Windows.Forms.TextBox();
            this.txtRno = new System.Windows.Forms.TextBox();
            this.txtBretide = new System.Windows.Forms.TextBox();
            this.txtBI_id = new System.Windows.Forms.TextBox();
            this.txtfine_id = new System.Windows.Forms.TextBox();
            this.libsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libsDataSet = new LibSystem.libsDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlfield.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libsDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFine_Id
            // 
            this.lblFine_Id.AutoSize = true;
            this.lblFine_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine_Id.Location = new System.Drawing.Point(146, 28);
            this.lblFine_Id.Name = "lblFine_Id";
            this.lblFine_Id.Size = new System.Drawing.Size(70, 20);
            this.lblFine_Id.TabIndex = 0;
            this.lblFine_Id.Text = "Fine_Id";
            this.lblFine_Id.Click += new System.EventHandler(this.lblFine_Id_Click);
            // 
            // lblBookIssue_id
            // 
            this.lblBookIssue_id.AutoSize = true;
            this.lblBookIssue_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIssue_id.Location = new System.Drawing.Point(146, 59);
            this.lblBookIssue_id.Name = "lblBookIssue_id";
            this.lblBookIssue_id.Size = new System.Drawing.Size(128, 20);
            this.lblBookIssue_id.TabIndex = 1;
            this.lblBookIssue_id.Text = "Book_Issue_id";
            this.lblBookIssue_id.Click += new System.EventHandler(this.lblBookIssue_id_Click);
            // 
            // lblBRetid
            // 
            this.lblBRetid.AutoSize = true;
            this.lblBRetid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRetid.Location = new System.Drawing.Point(146, 92);
            this.lblBRetid.Name = "lblBRetid";
            this.lblBRetid.Size = new System.Drawing.Size(141, 20);
            this.lblBRetid.TabIndex = 2;
            this.lblBRetid.Text = "Book_Return_Id";
            this.lblBRetid.Click += new System.EventHandler(this.lblBRetid_Click);
            this.lblBRetid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblBRetid_MouseDoubleClick);
            // 
            // lblRNo
            // 
            this.lblRNo.AutoSize = true;
            this.lblRNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNo.Location = new System.Drawing.Point(146, 127);
            this.lblRNo.Name = "lblRNo";
            this.lblRNo.Size = new System.Drawing.Size(44, 20);
            this.lblRNo.TabIndex = 3;
            this.lblRNo.Text = "RNo";
            this.lblRNo.Click += new System.EventHandler(this.lblRNo_Click);
            // 
            // lbltotaldays
            // 
            this.lbltotaldays.AutoSize = true;
            this.lbltotaldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldays.Location = new System.Drawing.Point(146, 159);
            this.lbltotaldays.Name = "lbltotaldays";
            this.lbltotaldays.Size = new System.Drawing.Size(99, 20);
            this.lbltotaldays.TabIndex = 4;
            this.lbltotaldays.Text = "Total_Days";
            this.lbltotaldays.Click += new System.EventHandler(this.lbltotaldays_Click);
            // 
            // lblfineamount
            // 
            this.lblfineamount.AutoSize = true;
            this.lblfineamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfineamount.Location = new System.Drawing.Point(146, 194);
            this.lblfineamount.Name = "lblfineamount";
            this.lblfineamount.Size = new System.Drawing.Size(116, 20);
            this.lblfineamount.TabIndex = 5;
            this.lblfineamount.Text = "Fine_Amount";
            this.lblfineamount.Click += new System.EventHandler(this.lblfineamount_Click);
            // 
            // pnlfield
            // 
            this.pnlfield.BackColor = System.Drawing.Color.LightCoral;
            this.pnlfield.Controls.Add(this.txtR_No);
            this.pnlfield.Controls.Add(this.lblsfid);
            this.pnlfield.Controls.Add(this.chkSearch);
            this.pnlfield.Controls.Add(this.txtfineamount);
            this.pnlfield.Controls.Add(this.txttotalday);
            this.pnlfield.Controls.Add(this.txtRno);
            this.pnlfield.Controls.Add(this.txtBretide);
            this.pnlfield.Controls.Add(this.txtBI_id);
            this.pnlfield.Controls.Add(this.txtfine_id);
            this.pnlfield.Controls.Add(this.lblBookIssue_id);
            this.pnlfield.Controls.Add(this.lblfineamount);
            this.pnlfield.Controls.Add(this.lblFine_Id);
            this.pnlfield.Controls.Add(this.lbltotaldays);
            this.pnlfield.Controls.Add(this.lblBRetid);
            this.pnlfield.Controls.Add(this.lblRNo);
            this.pnlfield.Location = new System.Drawing.Point(12, 12);
            this.pnlfield.Name = "pnlfield";
            this.pnlfield.Size = new System.Drawing.Size(647, 270);
            this.pnlfield.TabIndex = 6;
            this.pnlfield.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlfield_Paint);
            // 
            // txtR_No
            // 
            this.txtR_No.Location = new System.Drawing.Point(305, 236);
            this.txtR_No.Name = "txtR_No";
            this.txtR_No.Size = new System.Drawing.Size(100, 20);
            this.txtR_No.TabIndex = 21;
            this.txtR_No.TextChanged += new System.EventHandler(this.txtR_No_TextChanged);
            // 
            // lblsfid
            // 
            this.lblsfid.AutoSize = true;
            this.lblsfid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsfid.Location = new System.Drawing.Point(133, 236);
            this.lblsfid.Name = "lblsfid";
            this.lblsfid.Size = new System.Drawing.Size(111, 20);
            this.lblsfid.TabIndex = 20;
            this.lblsfid.Text = "Search_RNo";
            // 
            // chkSearch
            // 
            this.chkSearch.AutoSize = true;
            this.chkSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearch.Location = new System.Drawing.Point(531, 28);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(85, 24);
            this.chkSearch.TabIndex = 19;
            this.chkSearch.Text = "Search";
            this.chkSearch.UseVisualStyleBackColor = true;
            this.chkSearch.CheckedChanged += new System.EventHandler(this.chkSearch_CheckedChanged);
            // 
            // txtfineamount
            // 
            this.txtfineamount.Location = new System.Drawing.Point(305, 196);
            this.txtfineamount.Name = "txtfineamount";
            this.txtfineamount.Size = new System.Drawing.Size(100, 20);
            this.txtfineamount.TabIndex = 18;
            this.txtfineamount.TextChanged += new System.EventHandler(this.txtfineamount_TextChanged);
            this.txtfineamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfineamount_KeyPress);
            // 
            // txttotalday
            // 
            this.txttotalday.Location = new System.Drawing.Point(305, 161);
            this.txttotalday.Name = "txttotalday";
            this.txttotalday.Size = new System.Drawing.Size(100, 20);
            this.txttotalday.TabIndex = 17;
            this.txttotalday.TextChanged += new System.EventHandler(this.txttotalday_TextChanged);
            this.txttotalday.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotalday_KeyPress);
            // 
            // txtRno
            // 
            this.txtRno.Location = new System.Drawing.Point(305, 129);
            this.txtRno.Name = "txtRno";
            this.txtRno.Size = new System.Drawing.Size(100, 20);
            this.txtRno.TabIndex = 16;
            this.txtRno.TextChanged += new System.EventHandler(this.txtRno_TextChanged);
            this.txtRno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRno_KeyPress);
            // 
            // txtBretide
            // 
            this.txtBretide.Location = new System.Drawing.Point(305, 92);
            this.txtBretide.Name = "txtBretide";
            this.txtBretide.Size = new System.Drawing.Size(100, 20);
            this.txtBretide.TabIndex = 15;
            this.txtBretide.TextChanged += new System.EventHandler(this.txtBretide_TextChanged);
            this.txtBretide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBretide_KeyPress);
            // 
            // txtBI_id
            // 
            this.txtBI_id.Location = new System.Drawing.Point(305, 59);
            this.txtBI_id.Name = "txtBI_id";
            this.txtBI_id.Size = new System.Drawing.Size(100, 20);
            this.txtBI_id.TabIndex = 14;
            this.txtBI_id.TextChanged += new System.EventHandler(this.txtBI_id_TextChanged);
            this.txtBI_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBI_id_KeyPress);
            // 
            // txtfine_id
            // 
            this.txtfine_id.Location = new System.Drawing.Point(305, 28);
            this.txtfine_id.Name = "txtfine_id";
            this.txtfine_id.Size = new System.Drawing.Size(100, 20);
            this.txtfine_id.TabIndex = 13;
            this.txtfine_id.TextChanged += new System.EventHandler(this.txtfine_id_TextChanged);
            this.txtfine_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfine_id_KeyPress);
            // 
            // libsDataSetBindingSource
            // 
            this.libsDataSetBindingSource.DataSource = this.libsDataSet;
            this.libsDataSetBindingSource.Position = 0;
            // 
            // libsDataSet
            // 
            this.libsDataSet.DataSetName = "libsDataSet";
            this.libsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btndel);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Location = new System.Drawing.Point(12, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 61);
            this.panel1.TabIndex = 8;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.IndianRed;
            this.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(40, 13);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(88, 31);
            this.btnnew.TabIndex = 24;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.IndianRed;
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(522, 16);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(93, 31);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.IndianRed;
            this.btndel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(402, 16);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(93, 31);
            this.btndel.TabIndex = 22;
            this.btndel.Text = "Delete";
            this.btndel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.IndianRed;
            this.btnedit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(279, 15);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(93, 31);
            this.btnedit.TabIndex = 21;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.IndianRed;
            this.btnsave.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(152, 13);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 31);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbltc);
            this.panel2.Location = new System.Drawing.Point(12, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 43);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "TotoCount";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.BackColor = System.Drawing.Color.Transparent;
            this.lbltc.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltc.Location = new System.Drawing.Point(227, 13);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(104, 19);
            this.lbltc.TabIndex = 24;
            this.lbltc.Text = "TotalCount:-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 404);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 163);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Book_Fine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlfield);
            this.Name = "Book_Fine";
            this.Text = "Book_Fine";
            this.Load += new System.EventHandler(this.Book_Fine_Load);
            this.pnlfield.ResumeLayout(false);
            this.pnlfield.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libsDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFine_Id;
        private System.Windows.Forms.Label lblBookIssue_id;
        private System.Windows.Forms.Label lblBRetid;
        private System.Windows.Forms.Label lblRNo;
        private System.Windows.Forms.Label lbltotaldays;
        private System.Windows.Forms.Label lblfineamount;
        private System.Windows.Forms.Panel pnlfield;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtfineamount;
        private System.Windows.Forms.TextBox txttotalday;
        private System.Windows.Forms.TextBox txtRno;
        private System.Windows.Forms.TextBox txtBretide;
        private System.Windows.Forms.TextBox txtBI_id;
        private System.Windows.Forms.TextBox txtfine_id;
        private System.Windows.Forms.CheckBox chkSearch;
        private System.Windows.Forms.TextBox txtR_No;
        private System.Windows.Forms.Label lblsfid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.BindingSource libsDataSetBindingSource;
        private libsDataSet libsDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}