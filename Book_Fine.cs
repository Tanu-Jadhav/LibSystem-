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
    public partial class Book_Fine : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;
        OleDbDataAdapter adr = null;

        public Book_Fine()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            cmd = new OleDbCommand("select * from Book_Fine", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "Book_Fine");
            dataGridView1.DataSource = ds.Tables["Book_Fine"].DefaultView;
            label2.Text = dataGridView1.Rows.Count.ToString();

        }
        private void AutoInc()
        {
            int a;
            cmd = new OleDbCommand("select max(Fine_Id) from Book_Fine", cn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                String val = rdr[0].ToString();
                if (val == "")
                {
                    txtfine_id.Text = "01";
                }
                else
                {
                    a = Convert.ToInt32(rdr[0]);
                    a = a + 1;
                    txtfine_id.Text = a.ToString();
                }
            }
        }
        private void Clear()
        {
            txtfine_id.Text = "";
            txtBI_id.Text = "";
            txtBretide.Text = "";
            txtRno.Text = "";
            txttotalday.Text = "";
            txtfineamount.Text = "";
        }

        private void lblBookIssue_id_Click(object sender, EventArgs e)
        {

        }

        private void lbltotaldays_Click(object sender, EventArgs e)
        {

        }

        private void lblRNo_Click(object sender, EventArgs e)
        {

        }

        private void lblBRetid_Click(object sender, EventArgs e)
        {

        }

        private void lblfineamount_Click(object sender, EventArgs e)
        {

        }

        private void lblFine_Id_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtfine_id.Text == "")
            {
                MessageBox.Show("Enter Fine_Id");
                txtfine_id.Focus();
            }
            else if (txtBI_id.Text == "")
            {
                MessageBox.Show("Enter Book_Issue_id");
                txtBI_id.Focus();
            }
            else if (txtBretide.Text == "")
            {
                MessageBox.Show("Enter Book_Return_Id");
                txtBretide.Focus();
            }
            else if (txtRno.Text == "")
            {
                MessageBox.Show("Enter RNo");
                txtRno.Focus();
            }
            else if (txttotalday.Text == "") 
            {
                MessageBox.Show("Enter Total_Days");
                txttotalday.Focus();
            }
            else if (txtfineamount.Text == "")
            {
                MessageBox.Show("Enter Fine_Amount");
                txtfineamount.Focus();
            }
            else
            {
                cmd = new OleDbCommand("select * from Book_Fine where Fine_Id=" + txtfine_id.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Record is Already Exist...Plz Enter Another No");
                    txtRno.Focus();
                }
                else
                {
                    cmd = new OleDbCommand("Insert into Book_Fine values(" + txtfine_id.Text + "," + txtBI_id.Text + "," + txtBretide.Text + ",'" + txtRno.Text + "','" + txttotalday.Text + "','" + txtfineamount.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully.....");
                    Clear();
                    GetData();
                    AutoInc();
                }
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtfine_id.Text == "")
            {
                MessageBox.Show("plz Enter Fine_Id...");
                txtfine_id.Focus();
            }
            else
            {
                cmd = new OleDbCommand("select * from Book_Fine where Fine_ID=" + txtfine_id.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    DialogResult ans;
                    ans = MessageBox.Show("Do you Want Delete this Record....", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {

                        cmd = new OleDbCommand("delete from Book_Fine where Fine_Id=" + txtfine_id.Text + "", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("info deleted");
                        GetData(); Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Fine Id is Not Found... Plz Enter right Fine Id..");
                    txtfine_id.Enabled = true;
                    txtfine_id.Focus();
                }
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtfine_id.Text == "")
            {
                MessageBox.Show("Enter Fine_Id");
                txtfine_id.Focus();
            }
            else if (txtBI_id.Text == "")
            {
                MessageBox.Show("Enter Book_Issue_id");
                txtBI_id.Focus();
            }
            else if (txtBretide.Text == "")
            {
                MessageBox.Show("Enter Book_Return_Id");
                txtBretide.Focus();
            }
            else if (txtRno.Text == "")
            {
                MessageBox.Show("Enter RNo");
                txtRno.Focus();
            }
            else if (txttotalday.Text == "") 
            {
                MessageBox.Show("Enter Total_Days");
                txttotalday.Focus();
            }
            else if (txtfineamount.Text == "")
            {
                MessageBox.Show("Enter Fine_Amount");
                txtfineamount.Focus();
            }
            else
            {
                //cmd = new OleDbCommand("update Book_Fine set Fine_Amount='" + txtfineamount.Text + "',Book_Issue_id=" + txtBI_id.Text + ",Book_Return_Id=" + txtBretide.Text + ",RNo=" + txtRno.Text + ",Total_Days='" + txttotalday.Text + "' where Fine_Id=" + txtfine_id.Text + "", cn);
                cmd = new OleDbCommand("update Book_Fine set Fine_Amount='" + txtfineamount.Text + "',Book_Issue_id=" + txtBI_id.Text + ",Book_Return_Id=" + txtBretide.Text + ",RNo=" + txtRno.Text + ",Total_Days='" + txttotalday.Text + "' where Fine_Id=" + txtfine_id.Text + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("info updated ");
                Clear(); GetData();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotalday_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfineamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBretide_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBI_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfine_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //txtfine_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //txtBI_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //txtBretide.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //txtRno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txttotalday.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            //txtfineamount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void pnlfield_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Book_Fine_Load(object sender, EventArgs e)
        {
            cn.Open();
            GetData();
            AutoInc();
        }

        private void txtR_No_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from Book_Fine where RNo like '" + txtR_No.Text + "%'", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "Book_Fine");
            dataGridView1.DataSource = ds.Tables["Book_Fine"].DefaultView;
            label2.Text = dataGridView1.Rows.Count.ToString();
        }

        private void chkSearch_CheckedChanged(object sender, EventArgs e)
        {
             if (chkSearch.Checked == true)
            {
                txtfine_id.Text = "";
                txtfine_id.Enabled = true;
                txtfine_id.Focus();
            }
            else
            {
                AutoInc();
                txtfine_id.Enabled = false;
                txtfine_id.Focus();

            }
        }

        private void txtfine_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBI_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBretide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


            if (e.KeyChar == 13)
            {
                cmd = new OleDbCommand("select * from bookreturn where RNo=" + txtRno.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtfine_id.Text = rdr["Fine_Id"].ToString();
                    txtBI_id.Text = rdr["Book_Issue_id"].ToString();
                    txtBretide.Text = rdr["Book_Return_Id"].ToString();
                    txtRno.Text = rdr["RNo"].ToString();
                    txttotalday.Text = rdr["Total_Days"].ToString();
                    txtfineamount.Text = rdr["Fine_Amount"].ToString();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    Clear();
                    GetData();
                }
            }
        }

        private void txttotalday_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtfineamount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void btnnew_Click(object sender, EventArgs e)
        {
           
        }

        private void lblBRetid_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtfine_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBI_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBretide.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttotalday.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtfineamount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtfine_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtBI_id.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBretide.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRno.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txttotalday.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtfineamount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        
    }
}
