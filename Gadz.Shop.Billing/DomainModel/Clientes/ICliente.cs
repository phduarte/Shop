using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Billing.DomainModel.Clientes {
    public interface ICliente : IEntity {
        Nome Nome { get; }
        Cpf Cpf { get; }
    }
}
