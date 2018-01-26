using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Stock.DomainModel.Fabricantes {
    public interface IFabricante : IEntity {
        string Nome { get; }
        string Logo { get; }
    }
}
