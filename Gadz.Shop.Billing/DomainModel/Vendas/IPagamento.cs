using System;
using Gadz.Shop.Commom.Model;

namespace Gadz.Shop.Billing.Model.Pagamentos {
    public interface IPagamento : IEntity {
        Identity BeneficiarioId { get; }
        DateTime DataPagamento { get; }
        DateTime DataVencimento { get; }
        string Descricao { get; }
        double Valor { get; }
    }
}