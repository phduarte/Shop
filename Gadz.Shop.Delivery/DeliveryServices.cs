using Gadz.Shop.Commom.Model;
using Gadz.Shop.Delivery.DomainModel.Clientes;

namespace Gadz.Shop.Delivery {
    public class DeliveryServices : Singleton<DeliveryServices> {

        public ICliente CriarCliente(string nome, string endereco, string telefone) {

            var cliente = new Cliente(nome, endereco, telefone);

            return cliente;
        }
    }
}
