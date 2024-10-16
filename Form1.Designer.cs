namespace LibSystem
{
    partial class Student
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
            this.lblRNo = new System.Windows.Forms.Label();
            this.lblsname = new System.Windows.Forms.Label();
            this.lblsadder = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblmn = new System.Windows.Forms.Label();
            this.lbladhar = new System.Windows.Forms.Label();
            this.txtRno = new System.Windows.Forms.TextBox();
            this.txtsadder = new System.Windows.Forms.TextBox();
            this.txtmn = new System.Windows.Forms.TextBox();
            this.txtan = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbltc = new System.Windows.Forms.Label();
            this.lbltotoc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chksearch = new System.Windows.Forms.CheckBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_stud_name = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRNo
            // 
            this.lblRNo.AutoSize = true;
            this.lblRNo.BackColor = System.Drawing.Color.Transparent;
            this.lblRNo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRNo.Location = new System.Drawing.Point(139, 25);
            this.lblRNo.Name = "lblRNo";
            this.lblRNo.Size = new System.Drawing.Size(73, 19);
            this.lblRNo.TabIndex = 1;
            this.lblRNo.Text = "Roll_No";
            // 
            // lblsname
            // 
            this.lblsname.AutoSize = true;
            this.lblsname.BackColor = System.Drawing.Color.Transparent;
            this.lblsname.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsname.Location = new System.Drawing.Point(139, 54);
            this.lblsname.Name = "lblsname";
            this.lblsname.Size = new System.Drawing.Size(133, 19);
            this.lblsname.TabIndex = 2;
            this.lblsname.Text = "Student_Name";
            // 
            // lblsadder
            // 
            this.lblsadder.AutoSize = true;
            this.lblsadder.BackColor = System.Drawing.Color.Transparent;
            this.lblsadder.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsadder.Location = new System.Drawing.Point(139, 86);
            this.lblsadder.Name = "lblsadder";
            this.lblsadder.Size = new System.Drawing.Size(67, 19);
            this.lblsadder.TabIndex = 3;
            this.lblsadder.Text = "Sadder";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(139, 119);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(69, 19);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Gender";
            // 
            // lblmn
            // 
            this.lblmn.AutoSize = true;
            this.lblmn.BackColor = System.Drawing.Color.Transparent;
            this.lblmn.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmn.Location = new System.Drawing.Point(139, 152);
            this.lblmn.Name = "lblmn";
            this.lblmn.Size = new System.Drawing.Size(76, 19);
            this.lblmn.TabIndex = 5;
            this.lblmn.Text = "Mob_no";
            // 
            // lbladhar
            // 
            this.lbladhar.AutoSize = true;
            this.lbladhar.BackColor = System.Drawing.Color.Transparent;
            this.lbladhar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladhar.Location = new System.Drawing.Point(139, 185);
            this.lbladhar.Name = "lbladhar";
            this.lbladhar.Size = new System.Drawing.Size(99, 19);
            this.lbladhar.TabIndex = 6;
            this.lbladhar.Text = "Aadhar_no";
            // 
            // txtRno
            // 
            this.txtRno.Location = new System.Drawing.Point(282, 23);
            this.txtRno.Name = "txtRno";
            this.txtRno.Size = new System.Drawing.Size(100, 20);
            this.txtRno.TabIndex = 7;
            this.txtRno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRno_KeyPress);
            // 
            // txtsadder
            // 
            this.txtsadder.Location = new System.Drawing.Point(282, 84);
            this.txtsadder.Name = "txtsadder";
            this.txtsadder.Size = new System.Drawing.Size(206, 20);
            this.txtsadder.TabIndex = 9;
            this.txtsadder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsadder_KeyPress);
            // 
            // txtmn
            // 
            this.txtmn.Location = new System.Drawing.Point(282, 147);
            this.txtmn.Name = "txtmn";
            this.txtmn.Size = new System.Drawing.Size(151, 20);
            this.txtmn.TabIndex = 11;
            this.txtmn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmn_KeyPress);
            this.txtmn.Leave += new System.EventHandler(this.txtmn_Leave);
            // 
            // txtan
            // 
            this.txtan.Location = new System.Drawing.Point(282, 180);
            this.txtan.Name = "txtan";
            this.txtan.Size = new System.Drawing.Size(185, 20);
            this.txtan.TabIndex = 12;
            this.txtan.TextChanged += new System.EventHandler(this.txtan_TextChanged);
            this.txtan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtan_KeyPress);
            this.txtan.Leave += new System.EventHandler(this.txtan_Leave);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnsave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(128, 20);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 30);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnedit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(238, 20);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(93, 30);
            this.btnedit.TabIndex = 14;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndel.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(356, 20);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(93, 30);
            this.btndel.TabIndex = 15;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnexit.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(475, 20);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(93, 30);
            this.btnexit.TabIndex = 16;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lavender;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(572, 166);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.BackColor = System.Drawing.Color.Transparent;
            this.lbltc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltc.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltc.Location = new System.Drawing.Point(181, 65);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(103, 18);
            this.lbltc.TabIndex = 18;
            this.lbltc.Text = "TotalCount:-";
            // 
            // lbltotoc
            // 
            this.lbltotoc.AutoSize = true;
            this.lbltotoc.BackColor = System.Drawing.Color.Transparent;
            this.lbltotoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbltotoc.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotoc.Location = new System.Drawing.Point(288, 62);
            this.lbltotoc.Name = "lbltotoc";
            this.lbltotoc.Size = new System.Drawing.Size(86, 21);
            this.lbltotoc.TabIndex = 19;
            this.lbltotoc.Text = "TotoCount";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(244, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 21;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search_Sname";
            // 
            // chksearch
            // 
            this.chksearch.AutoSize = true;
            this.chksearch.BackColor = System.Drawing.Color.Transparent;
            this.chksearch.Font = new System.Drawing.Font("Sitka Display", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chksearch.ForeColor = System.Drawing.Color.DodgerBlue;
            this.chksearch.Location = new System.Drawing.Point(489, 10);
            this.chksearch.Name = "chksearch";
            this.chksearch.Size = new System.Drawing.Size(71, 25);
            this.chksearch.TabIndex = 22;
            this.chksearch.Text = "Search";
            this.chksearch.UseVisualStyleBackColor = false;
            this.chksearch.CheckedChanged += new System.EventHandler(this.chksearch_CheckedChanged);
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.Transparent;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.ForeColor = System.Drawing.Color.Black;
            this.rdoMale.Location = new System.Drawing.Point(285, 116);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(67, 26);
            this.rdoMale.TabIndex = 23;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.ForeColor = System.Drawing.Color.Black;
            this.rdoFemale.Location = new System.Drawing.Point(367, 116);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(85, 26);
            this.rdoFemale.TabIndex = 24;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = false;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmb_stud_name);
            this.panel1.Controls.Add(this.rdoFemale);
            this.panel1.Controls.Add(this.lblRNo);
            this.panel1.Controls.Add(this.rdoMale);
            this.panel1.Controls.Add(this.lblsname);
            this.panel1.Controls.Add(this.chksearch);
            this.panel1.Controls.Add(this.lblsadder);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lblgender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblmn);
            this.panel1.Controls.Add(this.lbladhar);
            this.panel1.Controls.Add(this.txtRno);
            this.panel1.Controls.Add(this.txtsadder);
            this.panel1.Controls.Add(this.txtmn);
            this.panel1.Controls.Add(this.txtan);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 258);
            this.panel1.TabIndex = 25;
            // 
            // cmb_stud_name
            // 
            this.cmb_stud_name.FormattingEnabled = true;
            this.cmb_stud_name.Location = new System.Drawing.Point(282, 54);
            this.cmb_stud_name.Name = "cmb_stud_name";
            this.cmb_stud_name.Size = new System.Drawing.Size(139, 21);
            this.cmb_stud_name.TabIndex = 37;
            this.cmb_stud_name.SelectedIndexChanged += new System.EventHandler(this.cmb_stud_name_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.btndel);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.lbltotoc);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.lbltc);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Location = new System.Drawing.Point(2, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 102);
            this.panel2.TabIndex = 26;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnnew.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(24, 20);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(84, 27);
            this.btnnew.TabIndex = 20;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(576, 538);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmstudent_Load);
            this.Leave += new System.EventHandler(this.Student_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRNo;
        private System.Windows.Forms.Label lblsname;
        private System.Windows.Forms.Label lblsadder;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblmn;
        private System.Windows.Forms.Label lbladhar;
        private System.Windows.Forms.TextBox txtRno;
        private System.Windows.Forms.TextBox txtsadder;
        private System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.TextBox txtan;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lbltotoc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chksearch;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.ComboBox cmb_stud_name;
    }
}

