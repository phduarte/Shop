using Gadz.Shop.Access;
using System;
using System.Windows.Forms;

namespace Gadz.Shop.Delivery.Forms {
    static class Program {

        public static Session Sessao = new Session();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            DeliveryServices services = DeliveryServices.Instance;


            var cliente = services.CriarCliente("Paulo Henrique Fernandes Duarte", "Rua Claudino Pinto, 100 - São Paulo - SP, 03040-040", "(11) 97741-4542");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
