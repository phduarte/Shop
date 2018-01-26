using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Billing.DomainModel.Clientes {
    public interface ICliente : IEntity {
        string Nome { get; }
    }
}
