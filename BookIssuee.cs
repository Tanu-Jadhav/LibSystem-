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
    public partial class BookIssuee : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;
        OleDbDataAdapter adr = null;

        public BookIssuee()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            cmd = new OleDbCommand("select * from BookIssuee", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "BookIssuee");
            dataGridView1.DataSource = ds.Tables["BookIssuee"].DefaultView;
            label2.Text = dataGridView1.Rows.Count.ToString();

        }
        private void StudName()
        {
            cmd = new OleDbCommand("Select *from BookIssuee", cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmb_stud_name.Items.Add(rdr["Student_Name"]);
            }
        }
        private void BookName()
        {
            cmd = new OleDbCommand("Select *from BookIssuee", cn);
            rdr =cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbB_N.Items.Add(rdr["Book_Name"]);           
            }
        }
         private void AutoInc()
         {
             int a;
             cmd = new OleDbCommand("select max(Book_Issue_id) from BookIssuee", cn);
             rdr = cmd.ExecuteReader();
             if (rdr.Read())
             {
                 String val = rdr[0].ToString();
                 if (val == "")
                 {
                     txtBI_id.Text = "11";
                 }
                 else
                 {
                     a = Convert.ToInt32(rdr[0]);
                     a = a + 1;
                     txtBI_id.Text = a.ToString();
                 }
             }
             }

        private void txtSearchB_I_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from BookIssuee where Book_id like '" + txtSearchB_I.Text + "%'", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "BookIssuee");
            dataGridView1.DataSource = ds.Tables["BookIssuee"].DefaultView;
            label2.Text = dataGridView1.Rows.Count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbi_Click(object sender, EventArgs e)
        {

        }

        private void txtRno_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRNo_Click(object sender, EventArgs e)
        {

        }

        private void txtIssue_date_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblissue_date_Click(object sender, EventArgs e)
        {

        }

        private void txtBI_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBookIssue_id_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();

            //cmd = new OleDbCommand("select count(*) as Book_ Intake from BookIssuee where Book_Issue_id=" + txtBI_id.Text + "", cn);
            //rdr = cmd.ExecuteReader();
            //if (rdr.Read())
            //{ 
            //    pbook=Convert.ToInt32(rdr[0
            //}
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtBI_id.Text == "")
            {
                MessageBox.Show("plz Enter Book_Issue_id...");
                txtBI_id.Focus();
            }
            else
            {
                cmd = new OleDbCommand("select * from BookIssuee where Book_Issue_id=" + txtBI_id.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    DialogResult ans;
                    ans = MessageBox.Show("Do you Want Delete this Record....", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {

                        cmd = new OleDbCommand("delete from BookIssuee where Book_Issue_id=" + txtBI_id.Text + "", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("info deleted"); GetData(); clear();
                    }
                }
                else
                {
                    MessageBox.Show("Book Issue id is Not Found... Plz Enter right Book Issue id..");
                    txtBI_id.Enabled = true;
                    txtBI_id.Focus();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (cmb_stud_name.Text == "")
            {
                MessageBox.Show("Enter Student_Name");
                cmb_stud_name.Focus();
            }
            else if (dtp_Issuee_date.Text == "")
            {
                MessageBox.Show("Enter Issue_Date");
                dtp_Issuee_date.Focus();
            }
            else if (cmbB_N.Text == "")
            {
                MessageBox.Show("Enter Book_Name");
                cmbB_N.Focus();
            }
            else if (txtBI_id.Text == "")
            {
                MessageBox.Show("Enter Book_Issue_id");
                txtBI_id.Focus();
            }
            else if (txtIntake.Text == "")
            {
                MessageBox.Show("Enter Intake");
                txtIntake.Focus();
            }
            else
            {
                cmd = new OleDbCommand("update BookIssuee set Issue_Date='" + dtp_Issuee_date.Text + "',Student_Name='"+cmb_stud_name.Text+"',Book_Name='"+cmbB_N.Text+"',Intake='"+txtIntake.Text+"'where Book_Issue_id=" + txtBI_id.Text + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("info updated ");
                clear(); GetData();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtBI_id.Text == "")
             {
                 MessageBox.Show("Enter Book_Issue_id");
                 txtBI_id.Focus();
             }
            else if (dtp_Issuee_date.Text == "")
             {
                 MessageBox.Show("Enter Issue_Date");
                 dtp_Issuee_date.Focus();
             }
            else if (cmb_stud_name.Text =="")
            {
                MessageBox.Show("Enter Student_Name");
                cmb_stud_name.Focus();
            }

            else if (cmbB_N.Text == "")
            {
                MessageBox.Show("Enter Book_Name");
                cmbB_N.Focus();
            }
            else if (txtIntake.Text == "")
            {
                MessageBox.Show("Enter Intake");
                txtIntake.Focus();
            }

            else
            {

                cmd = new OleDbCommand("select * from BookIssuee where Book_Issue_id=" + txtBI_id.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Record is Already Exist...Plz Enter Another No");
                    txtBI_id.Focus();
                }
                else
                {

                    cmd = new OleDbCommand("Insert into BookIssuee values(" + txtBI_id.Text + ",'" + dtp_Issuee_date.Text + "','" + cmb_stud_name.Text + "','" + cmbB_N.Text + "','" + txtIntake.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully.....");
                    clear();
                    GetData();
                    AutoInc();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbltc_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBI_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtp_Issuee_date.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_stud_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbB_N.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtIntake.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBI_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dtp_Issuee_date.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_stud_name.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbB_N.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtIntake.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void chkSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearch.Checked == true)
            {
                txtBI_id.Text = "";
                txtBI_id.Enabled = true;
                txtBI_id.Focus();
            }
            else
            {
                AutoInc();
                txtBI_id.Enabled = false;
                txtBI_id.Focus();

            }
        }

        private void BookIssuee_Load(object sender, EventArgs e)
        {
            cn.Open();
            GetData();
            AutoInc();
            StudName();
            BookName();
        }
         private void clear()
        {
            txtBI_id.Text = "";
            dtp_Issuee_date.Text = "";
            cmbB_N.Text = "";
            cmb_stud_name.Text = "";
            txtIntake.Text = "";
        }

         private void txtBI_id_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                 e.Handled = true;
             }
         }

         private void txtIssue_date_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                 e.Handled = true;
             }
         }

         private void txtbid_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                 e.Handled = true;
             }
         }

         private void cmb_stud_name_SelectedIndexChanged(object sender, EventArgs e)
         {
             cmd = new OleDbCommand("select * from Student where Student_Name='" + cmb_stud_name.Text + "'", cn);
             rdr = cmd.ExecuteReader();
             while (rdr.Read())
             {
                 lblRNo.Text = rdr["Roll_No"].ToString();
             }
             

         }

         private void cmbB_N_SelectedIndexChanged(object sender, EventArgs e)
         {
             cmd = new OleDbCommand("select * from Book_Info where Book_Name='" + cmbB_N.Text + "'", cn);
             rdr = cmd.ExecuteReader();
             cmbB_N.Refresh();
             while (rdr.Read())
             {
                 btnbi.Text = rdr["Book_id"].ToString();
                 lblin.Text = rdr["Intake"].ToString();
             }
         }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {

         }

         private void dtp_Issuee_date_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                 e.Handled = true;
             }
         }

         private void btnnew_Click(object sender, EventArgs e)
         {
             txtBI_id.Text = "";
             dtp_Issuee_date.Text = "";
             cmb_stud_name.Text = "";
             cmbB_N.Text = "";
             txtIntake.Text = "";
         }

         private void dtp_Issuee_date_ValueChanged(object sender, EventArgs e)
         {

         }

         private void panel5_Paint(object sender, PaintEventArgs e)
         {

         }

         private void txtIntake_TextChanged(object sender, EventArgs e)
         {

         }

         private void txtIntake_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                 e.Handled = true;
             }
         }

         private void lblin_Click(object sender, EventArgs e)
         {

         }

         private void lblbntake_Click(object sender, EventArgs e)
         {

         }

         private void lblint_Click(object sender, EventArgs e)
         {

         }     
    }
}
