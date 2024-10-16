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
    public partial class ClassMast : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;
        OleDbDataAdapter adr = null;

        public ClassMast()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            cmd = new OleDbCommand("select * from ClassMast", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "ClassMast");
            dataGridView1.DataSource = ds.Tables["ClassMast"].DefaultView;
            int totocount = dataGridView1.Rows.Count;
            lbltotc.Text = totocount.ToString();
        }
        private void Clear()
        {
            txtCI.Text = "";
            txtCN.Text = ""; 
        }
        private void AutoInc()
        {
            int a;
            cmd = new OleDbCommand("select max(Class_Id) from ClassMast", cn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                String val = rdr[0].ToString();
                if (val == "")
                {
                    txtCI.Text = "";
                }
                else
                {
                    a = Convert.ToInt32(rdr[0]);
                    a = a + 1;
                    txtCI.Text = a.ToString();
                }
            }
        }

        
         

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtCI.Text == "")
            {
                MessageBox.Show("Enter Class_Id");
                txtCI.Focus();

            }
            else if (txtCN.Text == "")
            {
                MessageBox.Show("Enter Class_Name");
                txtCN.Focus();
            }
            else
            {

                cmd = new OleDbCommand("select * from ClassMast where Class_Id=" + txtCI.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Record is Already Exist....Plz Enter Another No");
                    txtCI.Focus();
                }
                else
                {

                    cmd = new OleDbCommand("Insert into ClassMast values(" + txtCI.Text + ",'" + txtCN.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Saved Successfully.....");
                    Clear();
                    GetData();
                    AutoInc();
                }
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtCI.Text == "")
            {
                MessageBox.Show("Enter Class_Id");
                txtCI.Focus();

            }
            else if (txtCN.Text == "")
            {
                MessageBox.Show("Enter Class_Name");
                txtCN.Focus();
            }
            else
            {
                cmd = new OleDbCommand("update ClassMast set Class_Id='" + txtCI.Text + "', Class_Name='" + txtCN.Text + "' where Class_Id=" + txtCI.Text + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("info updated "); Clear(); GetData();
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtCI.Text == "")
            {
                MessageBox.Show("plz Enter Class_Id...");
                txtCI.Focus();
            }

            cmd = new OleDbCommand("select * from ClassMast where Class_Id=" + txtCI.Text + "", cn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                DialogResult ans;
                ans = MessageBox.Show("Do you Want Delete this Record....", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ans == DialogResult.Yes)
                {

                    cmd = new OleDbCommand("delete from ClassMast where Class_Id=" + txtCI.Text + "", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("info deleted"); 
                    GetData(); Clear();
                    txtCI.Text = ""; txtCI.Focus();
                }
            }
            else
            {
                MessageBox.Show("Class Code is Not Found... Plz Enter right Class Code..");
                txtCI.Enabled = true;
                txtCI.Focus();
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            AutoInc();
        }

        private void btnedit_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnexit_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

                cmd = new OleDbCommand("select * from ClassMast where Class_Id=" + txtCI.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    txtCI.Text = rdr["Class_Id"].ToString();
                    txtCN.Text = rdr["Class_Name"].ToString();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    Clear(); txtCI.Text = ""; txtCI.Focus();
                }
            }

        }

        private void txtCN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCI.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCN.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from ClassMast where Class_Name like'" + textBox1.Text + "%'", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "ClassMast");
            dataGridView1.DataSource = ds.Tables["ClassMast"].DefaultView;
            int totocount = dataGridView1.Rows.Count;
            lbltotc.Text = totocount.ToString();


        }

        private void Class_Mast_Load(object sender, EventArgs e)
        {
            cn.Open();
            AutoInc();
            GetData();
            
        }

        private void chkSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearch.Checked == true)
            {
                txtCI.Text = "";
                txtCI.Enabled = true;
                txtCI.Focus();
            }
            else
            {
                AutoInc();
                txtCI.Enabled = false;
                txtCN.Text = "";
                txtCN.Focus();

            }

        }

        private void lblci_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtCI.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCN.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtCI.Text = "";
            txtCN.Text = ""; 
        }
    }
}
