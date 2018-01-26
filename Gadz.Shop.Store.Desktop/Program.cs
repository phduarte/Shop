using Gadz.Shop.Access;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Store {
    static class Program {
        public static string Name {
            get {
                return "Shop";
            }
        }

        public static Session Sessao = Session.Create();

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}