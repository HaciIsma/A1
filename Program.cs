using A1.Presenter;
using A1.View;
using System;
using System.Windows.Forms;

namespace A1
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
            var view = new MainView();
            var presenter = new MainPresenter(view);
            Application.Run(view);
        }
    }
}
