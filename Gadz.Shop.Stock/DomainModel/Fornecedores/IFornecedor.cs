using Gadz.Shop.Commom.Model;
using Gadz.Shop.Stock.DomainModel.Produtos;
using System.Collections.Generic;

namespace Gadz.Shop.Stock.DomainModel.Fornecedores {
    public interface IFornecedor : IEntity {
        Nome Nome { get; }
        string Cnpj { get; }
        IList<IProduto> Produtos { get; }
    }
}
