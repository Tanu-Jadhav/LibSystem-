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
    public partial class Breackage : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;
        OleDbDataAdapter adr = null;

        public Breackage()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            cmd = new OleDbCommand("select * from Breackage", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "Breackage");
            dataGridView1.DataSource = ds.Tables["Breackage"].DefaultView;
            label2.Text = dataGridView1.Rows.Count.ToString();

        }
        private void clear()
        {
            txtbrid.Text = "";
            cmbB_N.Text = "";
            cmb_stud_name.Text = "";
            txtbi.Text = "";
            txtremark.Text = "";
            
        }
        private void StudName()
        {
            cmd = new OleDbCommand("Select *from Breackage", cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmb_stud_name.Items.Add(rdr["Student_Name"]);
            }
        }
        private void BookName()
        {
            cmd = new OleDbCommand("Select *from Breackage", cn);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbB_N.Items.Add(rdr["Book_Name"]);
            }
        }
        private void AutoInc()
        {
            int a;
            cmd = new OleDbCommand("select max(Breackage_Id) from Breackage", cn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                String val = rdr[0].ToString();
                if (val == "")
                {
                    txtbrid.Text = "1";
                }
                else
                {
                    a = Convert.ToInt32(rdr[0]);
                    a = a + 1;
                    txtbrid.Text = a.ToString();
                }
            }
        }

        private void lblrno_Click(object sender, EventArgs e)
        {

        }


        private void lblbrid_Click(object sender, EventArgs e)
        {

        }

        private void lblbid_Click(object sender, EventArgs e)
        {

        }

        private void txtbi_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblbi_Click(object sender, EventArgs e)
        {

        }

        private void lblremark_Click(object sender, EventArgs e)
        {

        }

        private void txtbrid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtbrid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_stud_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmbB_N.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtbi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtremark.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void txtbi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
                cmbB_N.Text = rdr["Book_id"].ToString();
                //lblin.Text = rdr["Intake"].ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from Breackage where Breackage_Id like '" + txtsbid.Text + "%'", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "Breackage");
            dataGridView1.DataSource = ds.Tables["Breackage"].DefaultView;
            label2.Text = dataGridView1.Rows.Count.ToString();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtbrid.Text == "")
            {
                MessageBox.Show("plz Enter Breackage_Id...");
                txtbrid.Focus();
            }
            else
            {
                cmd = new OleDbCommand("select * from Breackage where Breackage_Id=" + txtbrid.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    DialogResult ans;
                    ans = MessageBox.Show("Do you Want Delete this Record....", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {

                        cmd = new OleDbCommand("delete from Breackage where Roll_No=" + txtbrid.Text + "", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("info deleted"); GetData(); clear();
                    }
                }
                else
                {
                    MessageBox.Show("Breackage Id is Not Found... Plz Enter right Breackage Id..");
                    txtbrid.Enabled = true;
                    txtbrid.Focus();
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbrid.Text == "")
             {
                 MessageBox.Show("Enter Breackage_Id");
                 txtbrid.Focus();
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
            else if (txtbi.Text == "")
            {
                MessageBox.Show("Enter Breackage_Amount");
                txtbi.Focus();
            }
            else if (txtremark.Text == "")
            {
                MessageBox.Show("Enter Remark");
                txtremark.Focus();
            }
            
            else
            {

                cmd = new OleDbCommand("select * from Breackage where Breackage_Id=" + txtbrid.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Record is Already Exist...Plz Enter Another No");
                    txtbrid.Focus();
                }
                else
                {

                    cmd = new OleDbCommand("Insert into Breackage values(" + txtbrid.Text + ",'" + cmb_stud_name.Text + "','" + cmbB_N.Text + "','" + txtbi.Text + "','" + txtremark.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully.....");
                    clear();
                    GetData();
                    AutoInc();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtbrid.Text == "")
            {
                MessageBox.Show("Enter Breackage_Id");
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
            else if (txtbi.Text == "")
            {
                MessageBox.Show("Enter Breackage_Amount");
                txtbi.Focus();
            }
            else if (txtremark.Text == "")
            {
                MessageBox.Show("Enter Remark");
                txtremark.Focus();
            }
            else
            {
                cmd = new OleDbCommand("update Breackage set  Remark='" + txtremark.Text + "', Student_Name='" + cmb_stud_name.Text + "',Book_Name='" + cmbB_N.Text + "', Breackage_Amount='" + txtbi.Text + "' where Breackage_Id=" + txtbrid.Text + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("info updated ");
                clear(); GetData();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtbrid.Text = "";
            cmbB_N.Text = "";
            cmb_stud_name.Text = "";
            txtbi.Text = "";
            txtremark.Text = "";
        }

        private void Breackage_Load(object sender, EventArgs e)
        {
            cn.Open();
            GetData();
            AutoInc();
            StudName();
            BookName();
            clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void lblStud_name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Book_Name_Click(object sender, EventArgs e)
        {

        }
    }
}
