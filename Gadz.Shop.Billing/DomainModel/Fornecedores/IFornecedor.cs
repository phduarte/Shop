using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Billing.DomainModel.Fornecedores {
    public interface IFornecedor : IEntity {
        string Nome { get; set; }
    }
}
