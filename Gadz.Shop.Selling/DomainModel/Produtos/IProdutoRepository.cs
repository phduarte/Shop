using Gadz.Shop.Commom.Model;
using System;

namespace Gadz.Shop.Selling.DomainModel.Produtos {
    internal interface IProdutoRepository : IRepository<IProduto> {
        IProduto FirstOrDefault(Func<IProduto, bool> criterio);
    }
}
