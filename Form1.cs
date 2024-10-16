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
using System.Globalization;

namespace LibSystem
{
    public partial class Student : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;
        OleDbDataAdapter adr = null;
        string gender, sex;

        public Student()
        {
            InitializeComponent();
        }
        private void GetData()
        {
            cmd = new OleDbCommand("select * from Student", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
            lbltotoc.Text = dataGridView1.Rows.Count.ToString();

        }
        private void AutoInc()
        {
            int a;
            cmd = new OleDbCommand("select max(Roll_No) from Student", cn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                String val = rdr[0].ToString();
                if (val == "")
                {
                    txtRno.Text = "101";
                }
                else
                {
                    a = Convert.ToInt32(rdr[0]);
                    a = a + 1;
                    txtRno.Text = a.ToString();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_stud_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsadder.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmn.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (gender == "Male")
            { rdoMale.Checked = true; }
            else
            { rdoFemale.Checked = true; }

        }

        private void frmstudent_Load(object sender, EventArgs e)
        {
            cn.Open();
            GetData();
            AutoInc();
        }
        private void clear()
        {
            txtRno.Text = "";
            cmb_stud_name.Text = "";
            txtsadder.Text = "";
            //txtgender.Text = "";
            txtmn.Text = "";
            txtan.Text = "";
            rdoMale.Checked = false;


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtRno.Text == "")
            {
                MessageBox.Show("Enter Roll_No");
                txtRno.Focus();
            }
            else if (cmb_stud_name.Text == "")
            {
                MessageBox.Show("Enter Student_Name");
                cmb_stud_name.Focus();
            }
            else if (txtsadder.Text == "")
            {
                MessageBox.Show("Enter Sadder");
                txtsadder.Focus();
            }
            else if (txtmn.Text == "")
            {
                MessageBox.Show("Enter Mob_no");
                txtmn.Focus();
            }

            else if (txtan.Text == "")
            {
                MessageBox.Show("Enter Aadhar_no");
                txtan.Focus();
            }
            else
            {
                if (rdoMale.Checked == true)
                {
                    gender = rdoMale.Text;
                }
                else if (rdoFemale.Checked == true)
                {
                    gender = rdoFemale.Text;
                }
                cmd = new OleDbCommand("select * from Student where Roll_No=" + txtRno.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Record is Already Exist...Plz Enter Another No");
                    txtRno.Focus();
                }
                else
                {

                    cmd = new OleDbCommand("Insert into Student values(" + txtRno.Text + ",'" + cmb_stud_name.Text + "','" + txtsadder.Text + "','" + gender + "'," + txtmn.Text + ",'" + txtan.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully....");
                    GetData();
                    clear();
                    AutoInc();
                }

            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtRno.Text == "")
            {
                MessageBox.Show("Enter Roll_No");
                txtRno.Focus();
            }
            else if (cmb_stud_name.Text == "")
            {
                MessageBox.Show("Enter Student_Name");
                cmb_stud_name.Focus();
            }
            else if (txtsadder.Text == "")
            {
                MessageBox.Show("Enter Sadder");
                txtsadder.Focus();
            }
            else if (txtmn.Text == "")
            {
                MessageBox.Show("Enter Mob_no");
                txtmn.Focus();
            }
            else if (txtan.Text == "")
            {
                MessageBox.Show("Enter Aadhar_no");
                txtan.Focus();
            }

            if (rdoMale.Checked == true)
            {
                gender = rdoMale.Text;
            }
            else if (rdoFemale.Checked == true)
            {
                gender = rdoFemale.Text;
            }

            //cmd = new OleDbCommand("update Student set Sname='" + txtsname.Text + "', Sadder='" + txtsadder.Text + "', Gender='" + gender + "', Mob_no=" + txtmn.Text + ", Aadhar_no='" + txtan.Text + "', RNo=" + txtRno.Text + " where RNo='" + txtRno.Text + "'", cn);
            cmd = new OleDbCommand("update student set Student_Name='" + cmb_stud_name.Text + "',Gender='" + gender + "',Sadder='" + txtsadder.Text + "',Mob_no=" + txtmn.Text + ",Adhar_no='" + txtan.Text + "' where Roll_No=" + txtRno.Text + "", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("info updated ");
            GetData(); clear();


        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtRno.Text == "")
            {
                MessageBox.Show("plz Enter Roll_No...");
                txtRno.Focus();
            }
            else
            {
                cmd = new OleDbCommand("select * from Student where Roll_No=" + txtRno.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    DialogResult ans;
                    ans = MessageBox.Show("Do you Want Delete this Record....", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {

                        cmd = new OleDbCommand("delete from Student where Roll_No=" + txtRno.Text + "", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("info deleted"); GetData(); clear();
                    }
                }
                else
                {
                    MessageBox.Show("Roll No is Not Found... Plz Enter right Roll No..");
                    txtRno.Enabled = true;
                    txtRno.Focus();
                }
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }


            if (e.KeyChar == 13)
            {
                cmd = new OleDbCommand("select * from Student where Roll_No=" + txtRno.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    cmb_stud_name.Text = rdr["Student_Name"].ToString();
                    txtsadder.Text = rdr["sadder"].ToString();
                    // txtGender.Text = rdr["Gender"].ToString();
                    txtmn.Text = rdr["Mob_no"].ToString();
                    txtan.Text = rdr["Aadhar_no"].ToString();
                }
                else
                {
                    MessageBox.Show("Not Found");
                    clear();
                    GetData();
                }
            }

        }

        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked == true)
            {
                txtRno.Text = "";
                txtRno.Enabled = true;
                txtRno.Focus();
            }
            else
            {
                AutoInc();
                txtRno.Enabled = false;
                cmb_stud_name.Focus();

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from Student where Student_Name like '" + textBox1.Text + "%'", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "Student");
            dataGridView1.DataSource = ds.Tables["Student"].DefaultView;
            lbltotoc.Text = dataGridView1.Rows.Count.ToString();

        }

        private void txtsadder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void txtan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtmn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtsname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtan_Leave(object sender, EventArgs e)
        {
            string number = txtan.Text.ToString();
            if (number.Length < 12)
            {
                MessageBox.Show("Plz Enter 12 digit Aadhar_no Without Space");
                txtan.Focus();
            }
            else
            {
                string z = txtan.Text.Substring(-0, 4);
                string zx = txtan.Text.ToString().Substring(4, 4);
                string zxx = txtan.Text.ToString().Substring(4, 4);
                string zy = txtan.Text.ToString().Substring(4, 4);
                txtan.Text = (z + " " + zx + "  " + zxx).ToString();
                txtan.Text = CultureInfo.CurrentCulture.TextInfo.ToUpper(txtan.Text);
            }
        }

        private void txtan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtRno.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_stud_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsadder.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtmn.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            gender = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (gender == "Male")
            { rdoMale.Checked = true; }
            else
            { rdoFemale.Checked = true; }
        }

        private void Student_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtmn_Leave(object sender, EventArgs e)
        {
            //string number = txtmn.Text.ToString();
            //if (number.Length < 10)
            //{
            //    MessageBox.Show("Plz Enter 10 digit Mob_no Without Space");
            //    txtmn.Focus();
            //}
            //else
            //{
            //    string z = txtmn.Text.Substring(-0, 3);
            //    string zx = txtmn.Text.ToString().Substring(3, 3);
            //    string zxx = txtmn.Text.ToString().Substring(4, 4);
            //    string zy = txtmn.Text.ToString().Substring(3, 4);
            //    txtmn.Text = (z + " " + zx + "  " + zxx).ToString();
            //    txtmn.Text = CultureInfo.CurrentCulture.TextInfo.ToUpper(txtmn.Text);
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtRno.Text = "";
            cmb_stud_name.Text = "";
            txtsadder.Text = "";
            //txtgender.Text = "";
            txtmn.Text = "";
            txtan.Text = "";
            rdoMale.Checked = false;
        }

        private void cmb_stud_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
