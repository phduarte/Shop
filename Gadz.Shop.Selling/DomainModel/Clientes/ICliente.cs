using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Selling.DomainModel.Clientes {
    public interface ICliente : IEntity {
        Cpf Cpf { get; }
        Nome Nome { get; }
    }
}