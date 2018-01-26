using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Selling.DomainModel.Precos {
    public interface IPreco : IEntity {
        decimal Valor { get; }
    }
}
