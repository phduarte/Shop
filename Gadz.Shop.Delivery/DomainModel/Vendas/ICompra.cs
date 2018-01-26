using Gadz.Shop.Commom.Model;
using Gadz.Shop.Delivery.DomainModel.Clientes;
using Gadz.Shop.Delivery.DomainModel.Enderecos;
using Gadz.Shop.Delivery.DomainModel.Produtos;
using System;
using System.Collections.Generic;

namespace Gadz.Shop.Delivery.DomainModel.Compras {
    public interface ICompra : IEntity {
        ICliente Cliente { get;  }
        IEndereco Endereco { get;  }
        IList<IProduto> Produtos { get; }
        DateTime DataDeEntrega { get; }
        DateTime DataDaCompra { get;  }
        StatusCompra Status { get; }
    }
}
