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
    public partial class login : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;


        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            cn.Open();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            cmd = new OleDbCommand("select * from Login where User_Name='" + txtun.Text + "' and PassWord='" + txtpw.Text + "'", cn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MDIParent1 md = new MDIParent1();
                md.Show();
            }
            else
            {
                MessageBox.Show("Invalid User_Name and PassWord");           
                txtun.Focus();
                DialogResult ans;
                ans = MessageBox.Show("Do you Want Register this user....", "Reg", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (txtun.Text == "")
                {
                    MessageBox.Show("Plz Enter User_Name...");
                    txtun.Focus();
                }
                else if (txtpw.Text == "")
                {
                    MessageBox.Show("Plz Enter PassWord...");
                    txtpw.Focus();
                }
                else
                {

                }
                if (ans == DialogResult.Yes)
                {
                    cmd = new OleDbCommand("insert into Login values('" + txtun.Text + "','" + txtpw.Text + "')", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Registered Successfully...");
                    txtun.Focus();
                }
            }


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            cmd=new OleDbCommand ("Select *from Login where User_Name='"+txtun.Text+"'",cn);
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                MessageBox.Show("User Name Already Exist....Plz Enter Another Name");
                txtun.Text = ""; txtpw.Text = "";
                txtun.Focus();
            }
            else
            {  
                    cmd =new OleDbCommand ("Insert into Login values('"+txtun.Text+"','"+txtpw.Text+"')",cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfully....Plz Login");
                txtun.Focus();
            }
        }
    }
}
