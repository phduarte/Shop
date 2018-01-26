using Gadz.Shop.Commom.Model;
using Gadz.Shop.Stock.DomainModel.Fabricantes;
using Gadz.Shop.Stock.DomainModel.Fornecedores;
using Gadz.Shop.Stock.DomainModel.Kits;
using System.Collections.Generic;

namespace Gadz.Shop.Stock.DomainModel.Produtos {
    public interface IProduto : IEntity {
        string Nome { get; }
        IFabricante Fabricante { get; }
        IList<IFornecedor> Fornecedores { get; }
        IKit Kit { get; }
    }
}
