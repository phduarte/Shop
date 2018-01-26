using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Stock.DomainModel.Categorias {
    public interface ICategoria : IEntity {
        string Nome { get; }
        bool Ativo { get; }
    }
}
