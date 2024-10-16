using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Student());
            //Application.Run(new ClassMast());
            //Application.Run(new login());
            //Application.Run(new bookreturn());
            //Application.Run(new BookInfo());
            Application.Run(new MDIParent1());
            //Application.Run(new Book_Fine());
            //Application.Run(new Student1());
            //Application.Run(new Report.Form1());
            //Application.Run(new Report.stud());
            //Application.Run(new Report.BookReturn());
            //Application.Run(new Report.bookissue());
            //Application.Run(new Report.book_fine());


        }
    }
}
