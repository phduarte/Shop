using Gadz.Shop.Commom.Model;
using Gadz.Shop.Stock.DomainModel.Produtos;
using System.Collections.Generic;

namespace Gadz.Shop.Stock.DomainModel.Kits {
    public interface IKit : IEntity {
        string Descricao { get; }
        IList<IProduto> Produtos { get; }
        decimal Preco { get; }
    }
}
