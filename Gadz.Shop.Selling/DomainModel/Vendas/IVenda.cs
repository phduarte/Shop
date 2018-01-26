using System.Collections.Generic;
using Gadz.Shop.Commom.Model;
using Gadz.Shop.Selling.DomainModel.Clientes;
using Gadz.Shop.Selling.DomainModel.Produtos;

namespace Gadz.Shop.Selling.DomainModel.Vendas {
    public interface IVenda : IEntity {
        ICliente Cliente { get; }
        IList<IProduto> Produtos { get; }
        StatusVenda Status { get; }
        decimal TotalPago { get; }
        decimal Troco { get; }
        decimal ValorTotal { get; }

        void Add(IProduto produto);
        void AlterarCliente(ICliente cliente);
        void Estornar(decimal valor);
        void Finalizar();
        void Pagar(decimal valor);
        void Remove(Identity id);
    }
}