using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace LibSystem
{
    public partial class bookreturn : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;
        OleDbDataAdapter adr = null;

        int totdays, fineamount;

        public bookreturn()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            cmd = new OleDbCommand("select * from bookreturn", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "bookreturn");
            dataGridView1.DataSource = ds.Tables["bookreturn"].DefaultView;
            lblTc.Text = dataGridView1.Rows.Count.ToString();

        }
        private void StudName()
        {
            cmd = new OleDbCommand("Select *from bookreturn", cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmb_stud_name.Items.Add(rdr["Student_Name"]);
            }
        }
        private void BookName()
        {
            cmd = new OleDbCommand("Select *from bookreturn", cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbB_N.Items.Add(rdr["Book_Name"]);
            }
        }
        private void AutoInc()
        {
            int a;
            cmd = new OleDbCommand("select max(BookRetid) from bookreturn", cn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                String val = rdr[0].ToString();
                if (val == "")
                {
                    txtbrid.Text = "1001";
                }
                else
                {
                    a = Convert.ToInt32(rdr[0]);
                    a = a + 1;
                    txtbrid.Text = a.ToString();
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbrid.Text == "")
            {
                MessageBox.Show("Enter BookRetid");
                txtbrid.Focus();
            }
            else if (cmb_stud_name.Text == "")
            {
                MessageBox.Show("Enter Student_Name");
                cmb_stud_name.Focus();
            }
            else if (cmbB_N.Text == "")
            {
                MessageBox.Show("Enter Book_Name");
                cmbB_N.Focus();
            }
            else if (dtpr.Text == "")
            {
                MessageBox.Show("Enter Return_Date");
                dtpr.Focus();
            }

            else
            {

                cmd = new OleDbCommand("select * from bookreturn where BookRetid=" + txtbrid.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Record is Already Exist...Plz Enter Another No");
                    cmb_stud_name.Focus();
                }
                else
                {

                    cmd = new OleDbCommand("Insert into bookreturn values(" + txtbrid.Text + ",'" + cmb_stud_name.Text + "','" + cmbB_N.Text + "','" + dtpr .Text+ "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully.....");
                    clear();
                    GetData();
                    AutoInc();
                }
            }
        }


        private void BookReturns_Load(object sender, EventArgs e)
        {
            cn.Open();
            GetData();
            AutoInc();
            StudName();
            BookName();
        }
        private void clear()
        {
            txtbrid.Text = "";
            cmb_stud_name.Text = "";
            cmbB_N.Text = "";
       }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (cmb_stud_name.Text == "")
            {
                MessageBox.Show("Enter Student_Name");
                cmb_stud_name.Focus();
            }
            else if (cmbB_N.Text == "")
            {
                MessageBox.Show("Enter Book_Name");
                cmbB_N.Focus();
            }
            else if (dtpr.Text == "")
            {
                MessageBox.Show("Enter Return_Date");
                dtpr.Focus();
            }
            else if (txtbrid.Text == "")
            {
                MessageBox.Show("Enter BookRetid");
                txtbrid.Focus();
            }
            
            else
            {
                cmd = new OleDbCommand("update bookreturn set Student_Name='" + cmb_stud_name.Text + "', Book_Name='" + cmbB_N.Text + "', Return_Date='" + dtpr.Text + "' where BookRetid=" + txtbrid.Text + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("info updated ");
                clear(); GetData();
            }
        }





        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            AutoInc();
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            if (cmb_stud_name.Text == "")
            {
                MessageBox.Show("plz Enter Student_Name...");
                cmb_stud_name.Focus();
            }
            else
            {
                cmd = new OleDbCommand("select * from bookreturn where Student_Name=" + cmb_stud_name.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    DialogResult ans;
                    ans = MessageBox.Show("Do you Want Delete this Record....", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {

                        cmd = new OleDbCommand("delete from bookreturn where Student_Name=" + cmb_stud_name.Text + "", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("info deleted"); GetData(); clear();
                    }
                }
                else
                {
                    MessageBox.Show("Student Name is Not Found... Plz Enter right Student Name..");
                    cmb_stud_name.Enabled = true;
                    cmb_stud_name.Focus();
                }
            }
        }

        //private void txtrno_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }


        //    if (e.KeyChar == 13)
        //    {
        //        cmd = new OleDbCommand("select * from bookreturn where RNo=" + txtrno.Text + "", cn);
        //        rdr = cmd.ExecuteReader();
        //        if (rdr.Read())
        //        {
        //            txtbrid.Text = rdr["BookRetid"].ToString();
        //            cmb_stud_name.Text = rdr["Bissue_id"].ToString();
        //            txtrno.Text = rdr["RNo"].ToString();
        //            txtbi.Text = rdr["Book_id"].ToString();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Not Found");
        //            clear();
        //            GetData();
        //        }
        //    }
        //}



        private void txtsrno_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from bookreturn where Student_Name like '" + txtstudname.Text + "%'", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "bookreturn");
            dataGridView1.DataSource = ds.Tables["bookreturn"].DefaultView;
            lblTc.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbrid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_stud_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbB_N.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked == true)
            {
                txtbrid.Text = "";
                txtbrid.Enabled = true;
                txtbrid.Focus();
            }
            else
            {
                AutoInc();
                txtbrid.Enabled = false;
                txtbrid.Focus();

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtbrid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_stud_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbB_N.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtbrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbiid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txtbrid.Text = "";
            cmb_stud_name.Text = "";
            cmbB_N.Text = "";
            
        }

        private void cmb_stud_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from Student where Student_Name='" + cmb_stud_name.Text + "'", cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                lblrn.Text = rdr["Roll_No"].ToString();
            }
            //cmd = new OleDbCommand("select * from BookIssuee where Student_Name='" + cmb_stud_name.Text + "'", cn);
            //rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{
            //    lblrn.Text = rdr["Roll_No"].ToString();
            //}
        }

        private void cmbB_N_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from Book_Info where Book_Name='" + cmbB_N.Text + "'", cn);
            rdr = cmd.ExecuteReader();
            cmbB_N.Refresh();
            while (rdr.Read())
            {
                lblb.Text = rdr["Book_id"].ToString();
                //lblin.Text = rdr["Intake"].ToString();
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnfine_Click(object sender, EventArgs e)
        {
            dtpdate.Value = DateTime.Now;
            int daysDiff = ((TimeSpan)(dtpdate.Value.Date - dtpr.Value.Date)).Days;
            if (daysDiff >= 7)
            {
                totdays = daysDiff - 7;
                fineamount = totdays * 5;
                txtfine.Text = fineamount.ToString();
            }
            else
            {
                txtfine.Text = "0;";
            }
            btnfine.Refresh();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //    cmd = new OleDbCommand("select * from BookIssuee where dataGridView2 , cn);
            //    rdr = cmd.ExecuteReader();
            //    while (rdr.Read())
            //    {
            //        cmb_stud_name.Text = rdr["Student_Name"].ToString();
            //    }

            //    txtBI_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //    dtp_Issuee_date.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //    cmb_stud_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //    txtRno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //    cmbB_N.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //    txtbid.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            //}

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpr_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
