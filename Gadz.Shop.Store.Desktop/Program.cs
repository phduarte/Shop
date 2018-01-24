using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gadz.Shop.Store {
    static class Program {
        public static string Name {
            get {
                return "Shop";
            }
        }

        public static Sessao Sessao = new Sessao();
        public static Form frmMain;
        public static Form frmAddVenda;
        public static bool logou;

        [STAThread]
        static void Main() {
            ListenerSession();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        static void ListenerSession() {

            Task.Factory.StartNew(() => {
                while (true) {
                    try {
                        var servico = new Access.Services.AccessServices();
                        var usuario = servico.Primeiro();

                        if (usuario != null) {
                            logou = true;
                            Sessao.Redefinir(usuario);
                        } else {
                            if (logou) {
                                logou = false;
                                Sessao.Deslogar();
                            }
                        }
                    } catch (Exception ex) {
                        Debug.WriteLine(ex.Message);
                    }

                    Thread.Sleep(250);
                }
            });
        }
    }
}