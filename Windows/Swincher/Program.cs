using System;
using System.Windows.Forms;

namespace Swincher
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

            Hooker hooker = new Hooker();
            
            SwincherForm form = new SwincherForm();
            form.FormClosing += (sender, args) => { hooker.UnHook(); };
            hooker.Hook();

            Application.Run(form);
        }
    }
}
