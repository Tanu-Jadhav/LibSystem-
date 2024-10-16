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
using Microsoft.Reporting.WinForms;

namespace LibSystem
{
    public partial class MDIParent1 : Form
    {
        OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Tanuu\libsyst\LibSystem\libs.mdb");
        OleDbCommand cmd = null;
        OleDbDataReader rdr = null;
        OleDbDataAdapter adr = null;

        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }    
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void classmastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMast cm = new ClassMast();
            cm.Show();
        }

        private void StudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student frm = new Student();
            frm.Show();
        }

        private void bookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookInfo bi = new BookInfo();
            bi.Show();
        }

        private void bookreturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookreturn br = new bookreturn();
            br.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bookFineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Book_Fine B_Fine = new Book_Fine();
            B_Fine.Show();
        }

        private void bookIssueeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookIssuee B_I = new BookIssuee();
            B_I.Show();
        }

        private void breackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Breackage br = new Breackage();
            br.Show();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void studToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.stud st = new Report.stud();
            st.Show();
        }

       
        private void bookReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.BookReturn br = new Report.BookReturn();
            br.Show();
        }

        private void bookissueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.bookissue bi = new Report.bookissue();
            bi.Show();
        }

        private void bookfineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report.book_fine bf = new Report.book_fine();
            bf.Show();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.Form1 fr = new Report.Form1();
            fr.Show();
        }
    }
}
