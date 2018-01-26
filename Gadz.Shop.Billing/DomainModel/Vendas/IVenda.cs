using System;
using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Billing.Model.Vendas {
    public interface IVenda : IEntity {
        Identity BeneficiarioId { get; }
        DateTime DataPagamento { get; }
        DateTime DataVencimento { get; }
        string Anotacoes { get; }
        double Valor { get; }
    }
}