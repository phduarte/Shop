using Gadz.Shop.Access;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.HR.Forms {
    static class Program {
        public static Session Sessao = Session.Create();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
