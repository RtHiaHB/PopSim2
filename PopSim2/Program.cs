using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PopSim2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Environment.GetCommandLineArgs().Length<= 1)
            {
                Application.Run(new Form1());
            }
            else
            {
                Form1 f1=new Form1(Environment.GetCommandLineArgs()[1]);
                DialogResult dr = MessageBox.Show(f1, Environment.GetCommandLineArgs()[1], "args", MessageBoxButtons.OK);
                Application.Run(f1);
                
            }
        }
    }
}
