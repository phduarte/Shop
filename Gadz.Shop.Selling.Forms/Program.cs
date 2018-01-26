using Gadz.Shop.Access;
using Gadz.Shop.Selling.Forms.Vendas;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Selling.Forms {
    static class Program {

        public static Session Sessao = Session.Create();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Nova());
        }
    }
}
