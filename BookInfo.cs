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
    public partial class BookInfo : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;
        OleDbDataAdapter adr = null;

        public BookInfo()
        {
            InitializeComponent();
        }
          private void GetData()
        {
            cmd = new OleDbCommand("select * from Book_Info", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "Book_Info");
            dataGridView1.DataSource = ds.Tables["Book_Info"].DefaultView;
            label2.Text = dataGridView1.Rows.Count.ToString();

        }
          private void AutoInc()
          {
              int a;
              cmd = new OleDbCommand("select max(Book_id) from Book_Info", cn);
              rdr = cmd.ExecuteReader();
              if (rdr.Read())
              {
                  String val = rdr[0].ToString();
                  if (val == "")
                  {
                      txtbid.Text = "1";
                  }
                  else
                  {
                      a = Convert.ToInt32(rdr[0]);
                      a = a + 1;
                      txtbid.Text = a.ToString();
                  }
              }
          }
          private void Clear()
          {
              txtbid.Text = "";
              cmbB_N.Text = "";
              txtauther.Text ="";
              txtpublication.Text = "";
              txtisbn.Text = "";
              txtpages.Text = "";
              txtprice.Text = "";
              txtintake.Text = "";
          }

        private void lblsbn_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtbid.Text == "")
            {
                MessageBox.Show("Enter Book_id");
                txtbid.Focus();
            }
            else if (cmbB_N.Text == "")
            {
                MessageBox.Show("Enter Book_Name");
                cmbB_N.Focus();
            }
            else if (txtauther.Text == "")
            {
                MessageBox.Show("Enter Auther");
                txtauther.Focus();
            }

            else if (txtpublication.Text == "")
            {
                MessageBox.Show("Enter Publication");
                txtpublication.Focus();
            }
            else if (txtisbn.Text== "")
            {
                MessageBox.Show("Enter ISBN_no");
                txtisbn.Focus();
            }
            else if (txtpages.Text == "")
            {
                MessageBox.Show("Enter No_Pages");
                txtpages.Focus();
            }

            else if (txtprice.Text == "")
            {
                MessageBox.Show("Enter Price");
                txtprice.Focus();
            }
            else if (txtintake.Text == "")
            {
                MessageBox.Show("Enter Intake");
                txtintake.Focus();
            }
            else
            {

                cmd = new OleDbCommand("select * from Book_Info where Book_id=" + txtbid.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    MessageBox.Show("Record is Already Exist...Plz Enter Another No");
                    txtbid.Focus();
                }
                else
                {

                    cmd = new OleDbCommand("Insert into Book_Info values(" + txtbid.Text + ",'" + cmbB_N.Text + "','" + txtauther.Text + "','" + txtpublication.Text + "','" + txtisbn.Text + "','" + txtpages.Text + "','" + txtprice.Text + "'," + txtintake.Text + ")", cn);
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
            if (txtbid.Text == "")
            {
                MessageBox.Show("Enter Book_id");
                txtbid.Focus();
            }
            else if (cmbB_N.Text == "")
            {
                MessageBox.Show("Enter Book_Name");
                cmbB_N.Focus();
            }
            else if (txtauther.Text == "")
            {
                MessageBox.Show("Enter Auther");
                txtauther.Focus();
            }

            else if (txtpublication.Text == "")
            {
                MessageBox.Show("Enter Publication");
                txtpublication.Focus();
            }
            else if (txtisbn.Text == "")
            {
                MessageBox.Show("Enter ISBN_no");
                txtisbn.Focus();
            }
            else if (txtpages.Text == "")
            {
                MessageBox.Show("Enter No_Pages");
                txtpages.Focus();
            }

            else if (txtprice.Text == "")
            {
                MessageBox.Show("Enter Price");
                txtprice.Focus();
            }
            else if (txtintake.Text == "")
            {
                MessageBox.Show("Enter Intake");
                txtintake.Focus();
            }

            cmd = new OleDbCommand("update Book_Info set Book_Name='" + cmbB_N.Text + "', Author='" + txtauther.Text + "',Publication='" + txtpublication.Text + "',ISBN_no='" + txtisbn.Text + "',No_Pages='" + txtpages.Text + "',Price='" + txtprice.Text + "',Intake=" + txtintake.Text + " where Book_id=" + txtbid.Text + "", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("info updated ");
                Clear(); GetData();
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //cmd = new OleDbCommand("Select count(*) as totocount from BookInfo where Book_id=" + lblbi.Text + "", cn);
            //rdr = cmd.ExecuteReader();
            //while (rdr.Read())
            //{ 
            //    lbltc.Text=rdr["totocount"].ToString();
            //}
            //Book_id = Convert.ToInt32(lblbi.Text);
            //totocount = Convert.ToInt32(lbltc.Text);
            //rem = Book_id - totocount;
            //if (rem <= 0)
            //{
            //    MessageBox.Show("Book is Full Not a found...");
            //    btnsave.Enabled = false;
            //}
            //else
            //{
            //    lbltc.Text = rem.ToString();
            //    btnsave.Enabled = true;
            //}
            this.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtbid.Text == "")
            {
                MessageBox.Show("plz Enter Book_id...");
                txtbid.Focus();
            }
            else
            {
                cmd = new OleDbCommand("select * from Book_Info where Book_id=" + txtbid.Text + "", cn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    DialogResult ans;
                    ans = MessageBox.Show("Do you Want Delete this Record....", "Deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                    {

                        cmd = new OleDbCommand("delete from Book_Info where Book_id=" + txtbid.Text + "", cn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("info deleted");
                        GetData(); Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Book Id is Not Found... Plz Enter right Book Id..");
                    txtbid.Enabled = true;
                    txtbid.Focus();
                }
            }
        }

        private void BookInfo_Load(object sender, EventArgs e)
        {
            cn.Open();
            GetData();
            AutoInc();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbB_N.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtauther.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtpublication.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtisbn.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtpages.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtintake.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void txtSBN_TextChanged(object sender, EventArgs e)
        {
            cmd = new OleDbCommand("select * from Book_Info where Book_Name like '" + txtSBN.Text + "%'", cn);
            adr = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adr.Fill(ds, "Book_Info");
            dataGridView1.DataSource = ds.Tables["Book_Info"].DefaultView;
            label2.Text = dataGridView1.Rows.Count.ToString();
        }

        private void chksearch_CheckedChanged(object sender, EventArgs e)
        {
            if (chksearch.Checked == true)
            {
                txtbid.Text = "";
                txtbid.Enabled = true;
                txtbid.Focus();
            }
            else
            {
                AutoInc();
                txtbid.Enabled = false;
                txtbid.Focus();

            }
        }

        private void txtbname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtauther_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void txtpublication_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) != true && char.IsNumber(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtbid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbB_N.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtauther.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtpublication.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtisbn.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtpages.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtprice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtintake.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void txtpublication_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltc_Click(object sender, EventArgs e)
        {

        }

        private void txtbid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtpages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtisbn_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtbid.Text = "";
            cmbB_N.Text = "";
            txtauther.Text = "";
            txtpublication.Text = "";
            txtisbn.Text = "";
            txtpages.Text = "";
            txtprice.Text = "";
            txtintake.Text = "";
        }

        private void txtintake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtintake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmbB_N_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
