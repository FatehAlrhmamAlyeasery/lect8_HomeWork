using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_in_c_sharp
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
            //Form2 f2 = new Form2("add", "insert item");
            //MessageBox.Show(f2.getbtntxt());
            //f2.design();
            //f2.visual();
            Application.Run(new Form3());
        }
    }
}
