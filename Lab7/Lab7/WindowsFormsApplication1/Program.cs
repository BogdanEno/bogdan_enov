using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Reflection;

namespace WindowsFormsApplication1
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
            Process pr = RI();
            if (pr != null)
            {
                var result = MessageBox.Show("Мы нашли шпиона. Убрать его?", "Шпиион",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    Application.Run(new Form1());
                }
                else if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Шпион уничтожен!");
                }
            }
            else
                Application.Run(new Form1());
        }
        public static Process RI()
        {
            Process current = Process.GetCurrentProcess();
            Process[] pr = Process.GetProcessesByName(current.ProcessName);
            foreach (Process i in pr)
            {
                if (i.Id != current.Id)
                {
                    if (Assembly.GetExecutingAssembly().Location.Replace("/", "\\") == current.MainModule.FileName)
                    {
                        return i;
                    }
                }
            }
            return null;
        }
    }
}
