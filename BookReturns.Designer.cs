namespace LibSystem
{
    partial class bookreturn
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
            this.lblbri = new System.Windows.Forms.Label();
            this.txtbrid = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtstudname = new System.Windows.Forms.TextBox();
            this.lblstud = new System.Windows.Forms.Label();
            this.lbltoc = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btndelet = new System.Windows.Forms.Button();
            this.chksearch = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpr = new System.Windows.Forms.DateTimePicker();
            this.lblret_date = new System.Windows.Forms.Label();
            this.cmb_stud_name = new System.Windows.Forms.ComboBox();
            this.lblStud_name = new System.Windows.Forms.Label();
            this.cmbB_N = new System.Windows.Forms.ComboBox();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.lblrn = new System.Windows.Forms.Label();
            this.lblb = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_New = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtpdate = new System.Windows.Forms.DateTimePicker();
            this.lblidate = new System.Windows.Forms.Label();
            this.btnfine = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtfine = new System.Windows.Forms.TextBox();
            this.lblfine = new System.Windows.Forms.Label();
            this.lblbrn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblbri
            // 
            this.lblbri.AutoSize = true;
            this.lblbri.BackColor = System.Drawing.Color.Transparent;
            this.lblbri.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbri.Location = new System.Drawing.Point(86, 14);
            this.lblbri.Name = "lblbri";
            this.lblbri.Size = new System.Drawing.Size(96, 22);
            this.lblbri.TabIndex = 0;
            this.lblbri.Text = "BookRetid";
            // 
            // txtbrid
            // 
            this.txtbrid.Location = new System.Drawing.Point(254, 17);
            this.txtbrid.Name = "txtbrid";
            this.txtbrid.Size = new System.Drawing.Size(112, 20);
            this.txtbrid.TabIndex = 4;
            this.txtbrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbrid_KeyPress);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(123, 7);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 36);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(240, 10);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(92, 36);
            this.btnedit.TabIndex = 9;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(479, 10);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(89, 33);
            this.btnexit.TabIndex = 11;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtstudname
            // 
            this.txtstudname.Location = new System.Drawing.Point(324, 8);
            this.txtstudname.Name = "txtstudname";
            this.txtstudname.Size = new System.Drawing.Size(110, 20);
            this.txtstudname.TabIndex = 14;
            this.txtstudname.TextChanged += new System.EventHandler(this.txtsrno_TextChanged);
            // 
            // lblstud
            // 
            this.lblstud.AutoSize = true;
            this.lblstud.BackColor = System.Drawing.Color.Transparent;
            this.lblstud.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstud.Location = new System.Drawing.Point(124, 8);
            this.lblstud.Name = "lblstud";
            this.lblstud.Size = new System.Drawing.Size(189, 22);
            this.lblstud.TabIndex = 13;
            this.lblstud.Text = "Search_Student_Name";
            // 
            // lbltoc
            // 
            this.lbltoc.AutoSize = true;
            this.lbltoc.BackColor = System.Drawing.Color.Transparent;
            this.lbltoc.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoc.Location = new System.Drawing.Point(179, 50);
            this.lbltoc.Name = "lbltoc";
            this.lbltoc.Size = new System.Drawing.Size(118, 22);
            this.lbltoc.TabIndex = 15;
            this.lbltoc.Text = "TotalCount :-";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.BackColor = System.Drawing.Color.Transparent;
            this.lblTc.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTc.Location = new System.Drawing.Point(308, 50);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(90, 19);
            this.lblTc.TabIndex = 16;
            this.lblTc.Text = "TotoCount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 398);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(582, 123);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btndelet
            // 
            this.btndelet.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelet.Location = new System.Drawing.Point(354, 10);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(99, 36);
            this.btndelet.TabIndex = 18;
            this.btndelet.Text = "Delete";
            this.btndelet.UseVisualStyleBackColor = true;
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // chksearch
            // 
            this.chksearch.AutoSize = true;
            this.chksearch.BackColor = System.Drawing.Color.Transparent;
            this.chksearch.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksearch.Location = new System.Drawing.Point(497, 15);
            this.chksearch.Name = "chksearch";
            this.chksearch.Size = new System.Drawing.Size(71, 25);
            this.chksearch.TabIndex = 19;
            this.chksearch.Text = "Search";
            this.chksearch.UseVisualStyleBackColor = false;
            this.chksearch.CheckedChanged += new System.EventHandler(this.chksearch_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Controls.Add(this.dtpr);
            this.panel1.Controls.Add(this.lblret_date);
            this.panel1.Controls.Add(this.cmb_stud_name);
            this.panel1.Controls.Add(this.lblStud_name);
            this.panel1.Controls.Add(this.cmbB_N);
            this.panel1.Controls.Add(this.lbl_Book_Name);
            this.panel1.Controls.Add(this.lblrn);
            this.panel1.Controls.Add(this.lblb);
            this.panel1.Controls.Add(this.lblbri);
            this.panel1.Controls.Add(this.chksearch);
            this.panel1.Controls.Add(this.txtbrid);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 164);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtpr
            // 
            this.dtpr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpr.Location = new System.Drawing.Point(255, 131);
            this.dtpr.Name = "dtpr";
            this.dtpr.Size = new System.Drawing.Size(102, 20);
            this.dtpr.TabIndex = 44;
            this.dtpr.ValueChanged += new System.EventHandler(this.dtpr_ValueChanged);
            // 
            // lblret_date
            // 
            this.lblret_date.AutoSize = true;
            this.lblret_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblret_date.Location = new System.Drawing.Point(87, 132);
            this.lblret_date.Name = "lblret_date";
            this.lblret_date.Size = new System.Drawing.Size(113, 20);
            this.lblret_date.TabIndex = 43;
            this.lblret_date.Text = "Return_Date";
            // 
            // cmb_stud_name
            // 
            this.cmb_stud_name.FormattingEnabled = true;
            this.cmb_stud_name.Location = new System.Drawing.Point(255, 54);
            this.cmb_stud_name.Name = "cmb_stud_name";
            this.cmb_stud_name.Size = new System.Drawing.Size(139, 21);
            this.cmb_stud_name.TabIndex = 42;
            this.cmb_stud_name.SelectedIndexChanged += new System.EventHandler(this.cmb_stud_name_SelectedIndexChanged);
            // 
            // lblStud_name
            // 
            this.lblStud_name.AutoSize = true;
            this.lblStud_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStud_name.Location = new System.Drawing.Point(85, 55);
            this.lblStud_name.Name = "lblStud_name";
            this.lblStud_name.Size = new System.Drawing.Size(129, 20);
            this.lblStud_name.TabIndex = 41;
            this.lblStud_name.Text = "Student_Name";
            // 
            // cmbB_N
            // 
            this.cmbB_N.FormattingEnabled = true;
            this.cmbB_N.Location = new System.Drawing.Point(254, 93);
            this.cmbB_N.Name = "cmbB_N";
            this.cmbB_N.Size = new System.Drawing.Size(139, 21);
            this.cmbB_N.TabIndex = 40;
            this.cmbB_N.SelectedIndexChanged += new System.EventHandler(this.cmbB_N_SelectedIndexChanged);
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.Location = new System.Drawing.Point(85, 96);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(106, 20);
            this.lbl_Book_Name.TabIndex = 39;
            this.lbl_Book_Name.Text = "Book_Name";
            // 
            // lblrn
            // 
            this.lblrn.AutoSize = true;
            this.lblrn.BackColor = System.Drawing.Color.Transparent;
            this.lblrn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrn.Location = new System.Drawing.Point(406, 55);
            this.lblrn.Name = "lblrn";
            this.lblrn.Size = new System.Drawing.Size(74, 22);
            this.lblrn.TabIndex = 38;
            this.lblrn.Text = "Roll_No";
            // 
            // lblb
            // 
            this.lblb.AutoSize = true;
            this.lblb.BackColor = System.Drawing.Color.Transparent;
            this.lblb.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb.Location = new System.Drawing.Point(404, 90);
            this.lblb.Name = "lblb";
            this.lblb.Size = new System.Drawing.Size(76, 22);
            this.lblb.TabIndex = 37;
            this.lblb.Text = "Book_Id";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btn_New);
            this.panel2.Controls.Add(this.btndelet);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.lblTc);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.lbltoc);
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 80);
            this.panel2.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(582, 81);
            this.panel4.TabIndex = 23;
            // 
            // btn_New
            // 
            this.btn_New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(12, 10);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(93, 33);
            this.btn_New.TabIndex = 19;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Sienna;
            this.panel3.Controls.Add(this.txtstudname);
            this.panel3.Controls.Add(this.lblstud);
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(582, 40);
            this.panel3.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Chocolate;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.btnfine);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(0, 295);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(582, 67);
            this.panel5.TabIndex = 23;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PeachPuff;
            this.panel7.Controls.Add(this.dtpdate);
            this.panel7.Controls.Add(this.lblidate);
            this.panel7.Location = new System.Drawing.Point(14, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(235, 41);
            this.panel7.TabIndex = 49;
            // 
            // dtpdate
            // 
            this.dtpdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdate.Location = new System.Drawing.Point(125, 13);
            this.dtpdate.Name = "dtpdate";
            this.dtpdate.Size = new System.Drawing.Size(102, 20);
            this.dtpdate.TabIndex = 46;
            // 
            // lblidate
            // 
            this.lblidate.AutoSize = true;
            this.lblidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidate.Location = new System.Drawing.Point(6, 13);
            this.lblidate.Name = "lblidate";
            this.lblidate.Size = new System.Drawing.Size(102, 20);
            this.lblidate.TabIndex = 45;
            this.lblidate.Text = "Issue_Date";
            // 
            // btnfine
            // 
            this.btnfine.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfine.Location = new System.Drawing.Point(263, 12);
            this.btnfine.Name = "btnfine";
            this.btnfine.Size = new System.Drawing.Size(96, 31);
            this.btnfine.TabIndex = 48;
            this.btnfine.Text = "Fine";
            this.btnfine.UseVisualStyleBackColor = true;
            this.btnfine.Click += new System.EventHandler(this.btnfine_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PeachPuff;
            this.panel6.Controls.Add(this.txtfine);
            this.panel6.Controls.Add(this.lblfine);
            this.panel6.Location = new System.Drawing.Point(374, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 40);
            this.panel6.TabIndex = 47;
            // 
            // txtfine
            // 
            this.txtfine.Location = new System.Drawing.Point(66, 10);
            this.txtfine.Name = "txtfine";
            this.txtfine.Size = new System.Drawing.Size(89, 20);
            this.txtfine.TabIndex = 1;
            // 
            // lblfine
            // 
            this.lblfine.AutoSize = true;
            this.lblfine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfine.Location = new System.Drawing.Point(15, 10);
            this.lblfine.Name = "lblfine";
            this.lblfine.Size = new System.Drawing.Size(44, 20);
            this.lblfine.TabIndex = 0;
            this.lblfine.Text = "Fine";
            // 
            // lblbrn
            // 
            this.lblbrn.AutoSize = true;
            this.lblbrn.Font = new System.Drawing.Font("Segoe Marker", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbrn.Location = new System.Drawing.Point(179, 368);
            this.lblbrn.Name = "lblbrn";
            this.lblbrn.Size = new System.Drawing.Size(193, 24);
            this.lblbrn.TabIndex = 25;
            this.lblbrn.Text = "Book_Return_Detail:-";
            // 
            // bookreturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(586, 530);
            this.Controls.Add(this.lblbrn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "bookreturn";
            this.Text = "BookReturns";
            this.Load += new System.EventHandler(this.BookReturns_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbri;
        private System.Windows.Forms.TextBox txtbrid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtstudname;
        private System.Windows.Forms.Label lblstud;
        private System.Windows.Forms.Label lbltoc;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btndelet;
        private System.Windows.Forms.CheckBox chksearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.ComboBox cmb_stud_name;
        private System.Windows.Forms.Label lblStud_name;
        private System.Windows.Forms.ComboBox cmbB_N;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Label lblrn;
        private System.Windows.Forms.Label lblb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpr;
        private System.Windows.Forms.Label lblret_date;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnfine;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtfine;
        private System.Windows.Forms.Label lblfine;
        private System.Windows.Forms.DateTimePicker dtpdate;
        private System.Windows.Forms.Label lblidate;
        private System.Windows.Forms.Label lblbrn;
    }
}