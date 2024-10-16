namespace LibSystem
{
    partial class ClassMast
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
            this.lblci = new System.Windows.Forms.Label();
            this.lblcn = new System.Windows.Forms.Label();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtCN = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.lbltotc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblci
            // 
            this.lblci.AutoSize = true;
            this.lblci.BackColor = System.Drawing.Color.Transparent;
            this.lblci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblci.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblci.Location = new System.Drawing.Point(80, 30);
            this.lblci.Name = "lblci";
            this.lblci.Size = new System.Drawing.Size(70, 21);
            this.lblci.TabIndex = 0;
            this.lblci.Text = "Class_Id";
            this.lblci.Click += new System.EventHandler(this.lblci_Click);
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.BackColor = System.Drawing.Color.Transparent;
            this.lblcn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcn.Location = new System.Drawing.Point(80, 70);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(101, 21);
            this.lblcn.TabIndex = 1;
            this.lblcn.Text = "Class_Name";
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(194, 33);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(102, 20);
            this.txtCI.TabIndex = 2;
            this.txtCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCI_KeyPress);
            // 
            // txtCN
            // 
            this.txtCN.Location = new System.Drawing.Point(194, 70);
            this.txtCN.Name = "txtCN";
            this.txtCN.Size = new System.Drawing.Size(146, 20);
            this.txtCN.TabIndex = 3;
            this.txtCN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCN_KeyPress);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LightCoral;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Location = new System.Drawing.Point(108, 18);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 27);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.LightCoral;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnedit.Location = new System.Drawing.Point(211, 18);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(93, 27);
            this.btnedit.TabIndex = 5;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            this.btnedit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnedit_KeyPress);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightCoral;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndelete.Location = new System.Drawing.Point(319, 18);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(93, 27);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.Location = new System.Drawing.Point(432, 18);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(95, 27);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            this.btnexit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnexit_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Crimson;
            this.textBox1.Location = new System.Drawing.Point(213, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search_Class_Name";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.BackColor = System.Drawing.Color.Transparent;
            this.lbltc.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltc.Location = new System.Drawing.Point(159, 61);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(105, 22);
            this.lbltc.TabIndex = 10;
            this.lbltc.Text = "TotalCount:-";
            // 
            // lbltotc
            // 
            this.lbltotc.AutoSize = true;
            this.lbltotc.BackColor = System.Drawing.Color.Transparent;
            this.lbltotc.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotc.Location = new System.Drawing.Point(268, 62);
            this.lbltotc.Name = "lbltotc";
            this.lbltotc.Size = new System.Drawing.Size(90, 19);
            this.lbltotc.TabIndex = 11;
            this.lbltotc.Text = "TotoCount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 164);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // chkSearch
            // 
            this.chkSearch.AutoSize = true;
            this.chkSearch.BackColor = System.Drawing.Color.Transparent;
            this.chkSearch.Font = new System.Drawing.Font("Sitka Display", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSearch.Location = new System.Drawing.Point(452, 12);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(75, 27);
            this.chkSearch.TabIndex = 13;
            this.chkSearch.Text = "Search";
            this.chkSearch.UseVisualStyleBackColor = false;
            this.chkSearch.CheckedChanged += new System.EventHandler(this.chkSearch_CheckedChanged);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.LightCoral;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnnew.Location = new System.Drawing.Point(3, 18);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(90, 27);
            this.btnnew.TabIndex = 14;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCN);
            this.panel1.Controls.Add(this.lblci);
            this.panel1.Controls.Add(this.lblcn);
            this.panel1.Controls.Add(this.chkSearch);
            this.panel1.Controls.Add(this.txtCI);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 182);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnnew);
            this.panel2.Controls.Add(this.btnsave);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btndelete);
            this.panel2.Controls.Add(this.lbltotc);
            this.panel2.Controls.Add(this.btnexit);
            this.panel2.Controls.Add(this.lbltc);
            this.panel2.Location = new System.Drawing.Point(0, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 92);
            this.panel2.TabIndex = 16;
            // 
            // ClassMast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(535, 451);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClassMast";
            this.Text = "ClassMast";
            this.Load += new System.EventHandler(this.Class_Mast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblci;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtCN;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lbltotc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkSearch;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}